using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using ECAClientFramework;
using ECAClientUtilities.API;
using ShadowSys118.Adapters;
using ShadowSys118.Model.SS118Data;
using ShadowSys118.PythonScript;
using ShadowSys118.VcControlDevice;

namespace ShadowSys118
{
    public static class Algorithm
    {
        public static Hub API { get; set; }

        internal class Output
        {
            public Outputs OutputData = new Outputs();
            public _OutputsMeta OutputMeta = new _OutputsMeta();
            public static Func<Output> CreateNew { get; set; } = () => new Output();
        }

        public static void UpdateSystemSettings()
        {
            SystemSettings.InputMapping = "SS118Data_InputMapping";
            SystemSettings.OutputMapping = "SS118Data_OutputMapping";
            SystemSettings.ConnectionString = @"server=localhost:6190; interface=0.0.0.0";
            SystemSettings.FramesPerSecond = 1;
            SystemSettings.LagTime = 1;
            SystemSettings.LeadTime = 1;
        }

        internal static Output Execute(Inputs inputData, _InputsMeta inputMeta)
        {
            Output output = Output.CreateNew();
            DateTime runTime = DateTime.UtcNow;

            #region [ Environment Settings ]
            const bool EnableXmlFileLog = false;
            const bool EnableMainWindowMessageDisplay = true;

            string MainFolderPath = (@"C:\Users\niezj\Documents\dom\ShadowSys118\");
            string ActionChannelFolderPath = Path.Combine(MainFolderPath, @"ActionChannel");
            string DataFolderPath = Path.Combine(MainFolderPath, @"Data");
            string LogFolderPath = Path.Combine(MainFolderPath, @"Log");
            string ConfigurationFolderPath = Path.Combine(MainFolderPath, @"ShadowSysConfiguration");
            string ProjFolderPath = Path.Combine(MainFolderPath, @"ShadowSysLibrary");
            string PythonCodeFolderPath = Path.Combine(MainFolderPath, @"PythonCode");

            string CaseFileName = "IEEE_118_Bus.sav";
            string CsvOutputsFileName = "Outputs.csv";
            string ConfigurationFileName = "Configurations.xml";
            string InitSysConfigFrameFileName = "init_SysConfigFrame.xml";
            string PrevSysConfigFrameFileName = "prev_SysConfigFrame.xml";

            string CaseFilePath = Path.Combine(PythonCodeFolderPath, CaseFileName);
            string CsvOutputsFilePath = Path.Combine(LogFolderPath, CsvOutputsFileName);
            string ConfigurationFilePath = Path.Combine(ConfigurationFolderPath, ConfigurationFileName);
            string InitSysConfigFrameFilePath = Path.Combine(ConfigurationFolderPath, InitSysConfigFrameFileName);
            string PrevSysConfigFrameFilePath = Path.Combine(ConfigurationFolderPath, PrevSysConfigFrameFileName);
            #endregion

            #region [ Update Configurations of Controlled Devices ]

            VoltVarController frame = new VoltVarController();

            // Read System Initial Configuration from XML file            
            if (inputData.ResetSignal != 0)
            {
                MainWindow.WriteMessage($"Initialized Local Voltage Controller Test #{inputData.ResetSignal}");
                InitSysConfigFrameFileName = $"init_SysConfigFrame_test{inputData.ResetSignal}.xml";
                InitSysConfigFrameFilePath = Path.Combine(ConfigurationFolderPath, InitSysConfigFrameFileName);
                File.Delete(PrevSysConfigFrameFilePath);
                frame = VoltVarController.DeserializeFromXml(InitSysConfigFrameFilePath);
                inputData.ActTxRaise = 0;
                inputData.ActTxLower = 0;
                inputData.ActSn1Close = 0;
                inputData.ActSn1Trip = 0;
                inputData.ActSn2Close = 0;
                inputData.ActSn2Trip = 0;
                ActionsAdapter initAction = new ActionsAdapter();
                initAction.ReadFromEcaInputData(inputData);
                frame.ExecuteControl(initAction);
            }
            else
            {
                frame = VoltVarController.DeserializeFromXml(PrevSysConfigFrameFilePath);
            }

            #endregion

            #region [ PSEUDO: Update Configurations of Controlled Devices ]

            frame.SubstationInformation.ConsecCap += 1;
            frame.SubstationInformation.ConsecTap += 1;
            frame.SubstationInformation.Ncdel += 1;
            frame.SubstationInformation.Ntdel += 1;

            StringBuilder devMessage = new StringBuilder();

            string ActionChannelFilePath = Path.Combine(ActionChannelFolderPath, "act.xml");
            ActionsAdapter action = new ActionsAdapter();

            // Read Action from XML file
            if (File.Exists(ActionChannelFilePath))
            {
                action = ActionsAdapter.DeserializeFromXml(ActionChannelFilePath);
                File.Delete(ActionChannelFilePath);
            }

            action.ReadFromEcaInputData(inputData);

            #endregion


            //frame.ExecuteControl(action);

            #region [ Pending: Avoid logic conflict before execute control ]

            #endregion

            #region [ Run Power Flow Calculation using PSS/E ]
            // Call Python script to run power flow calculation
            PythonScripts Python = new PythonScripts();
            List<string> outputFrameList = new List<string>();
            outputFrameList = Python.RunPythonCmd(Path.Combine(PythonCodeFolderPath, "CalculatePowerFlow.py"),
                                                  MainFolderPath,
                                                  CaseFileName,
                                                  CsvOutputsFileName,
                                                  inputData.LoadIncrementPercentage,
                                                  frame.ControlTransformers[0].TapV,
                                                  frame.ControlCapacitorBanks[0].CapBkrV,
                                                  frame.ControlCapacitorBanks[1].CapBkrV,
                                                  frame.ControlCapacitorBanks[0].BusBkrV,
                                                  frame.ControlCapacitorBanks[1].BusBkrV);
            
            frame.SerializeToXml(PrevSysConfigFrameFilePath);

            #endregion

            #region [ Convert Calculated Values to OutputData ]

            // Read Measurement Values from python outputs
            output.OutputData.StateTxTapV = Convert.ToInt16(outputFrameList[0]);
            output.OutputData.StateSn1CapBkrV = Convert.ToInt16(outputFrameList[1]);
            output.OutputData.StateSn2CapBkrV = Convert.ToInt16(outputFrameList[2]);
            output.OutputData.StateSn1BusBkrV = Convert.ToInt16(outputFrameList[3]);
            output.OutputData.StateSn2BusBkrV = Convert.ToInt16(outputFrameList[4]);
            output.OutputData.MeasTxVoltV = Convert.ToDouble(outputFrameList[5]);
            output.OutputData.MeasSn1VoltV = Convert.ToDouble(outputFrameList[6]);
            output.OutputData.MeasSn2VoltV = Convert.ToDouble(outputFrameList[7]);
            output.OutputData.MeasTxMwV = Convert.ToDouble(outputFrameList[8]);
            output.OutputData.MeasTxMvrV = Convert.ToDouble(outputFrameList[9]);
            output.OutputData.MeasGn1MwV = Convert.ToDouble(outputFrameList[10]);
            output.OutputData.MeasGn1MvrV = Convert.ToDouble(outputFrameList[11]);
            output.OutputData.MeasGn2MwV = Convert.ToDouble(outputFrameList[12]);
            output.OutputData.MeasGn2MvrV = Convert.ToDouble(outputFrameList[13]);
            
            #endregion


            try
            {
                // TODO: Implement your algorithm here...
                // You can also write messages to the main window:

                #region [ Write Xml Log File ]
                if (EnableXmlFileLog)
                {
                    string ConfigFrameXMLLogFileName = $"Log_SysConfigFrame_{DateTime.UtcNow:yyMMdd_HHmmss}.xml";
                    string ConfigFrameXMLLogFilePath = Path.Combine(LogFolderPath, ConfigFrameXMLLogFileName);
                    frame.SerializeToXml(ConfigFrameXMLLogFilePath);
                }
                #endregion

                #region [ Write openECA Client Windows Message ]
                if (EnableMainWindowMessageDisplay)
                {
                    StringBuilder _message = new StringBuilder();
                    _message.AppendLine($" ================ ShadowSys Analytics ================"); 
                    _message.AppendLine($"                 Run Time:  {runTime:yyyy-MM-dd HH:mm:ss.fff}");
                    _message.AppendLine($"          Completion Time:  {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss.fff}");
                    _message.AppendLine($"      InputData Timestamp:  {inputMeta.LoadIncrementPercentage.Timestamp:yyyy-MM-dd HH:mm:ss.fff}");
                    _message.AppendLine($"     OutputData Timestamp:  {output.OutputMeta.MeasGn1MvrV.Timestamp:yyyy-MM-dd HH:mm:ss.fff}");
                    _message.AppendLine($" ------------------ CsvInputAdapter ------------------ ");
                    _message.AppendLine($"  LoadIncrementPercentage:  {inputData.LoadIncrementPercentage:0.0000} %");
                    _message.AppendLine($" ------------------- ActionChannel ------------------- ");
                    _message.AppendLine($"               ActTxRaise:  {inputData.ActTxRaise}");
                    _message.AppendLine($"               ActTxLower:  {inputData.ActTxLower}");
                    _message.AppendLine($"              ActSn1Close:  {inputData.ActSn1Close}");
                    _message.AppendLine($"               ActSn1Trip:  {inputData.ActSn1Trip}");
                    _message.AppendLine($"              ActSn2Close:  {inputData.ActSn2Close}");
                    _message.AppendLine($"               ActSn2Trip:  {inputData.ActSn2Trip}");
                    _message.AppendLine($" ---------------- MeasurementChannel ----------------- ");
                    _message.AppendLine($"              MeasTxVoltV:  {output.OutputData.MeasTxVoltV:0.000} Volts");
                    _message.AppendLine($"             MeasSn1VoltV:  {output.OutputData.MeasSn1VoltV:0.000} Volts");
                    _message.AppendLine($"             MeasSn2VoltV:  {output.OutputData.MeasSn2VoltV:0.000} Volts");
                    _message.AppendLine($"                MeasTxMwV:  {output.OutputData.MeasTxMwV:0.000} MW");
                    _message.AppendLine($"               MeasTxMvrV:  {output.OutputData.MeasTxMvrV:0.000} MVar");
                    _message.AppendLine($"               MeasGn1MwV:  {output.OutputData.MeasGn1MwV:0.000} MW");
                    _message.AppendLine($"              MeasGn1MvrV:  {output.OutputData.MeasGn1MvrV:0.000} MVar");
                    _message.AppendLine($"               MeasGn2MwV:  {output.OutputData.MeasGn2MwV:0.000} MW");
                    _message.AppendLine($"              MeasGn2MvrV:  {output.OutputData.MeasGn2MvrV:0.000} MVar");
                    //_message.AppendLine($" ------------------- StateChannel -------------------- ");
                    //_message.AppendLine($"              StateTxTapV:  {output.OutputData.StateTxTapV}");
                    //_message.AppendLine($"          StateSn1CapBkrV:  {output.OutputData.StateSn1CapBkrV}");
                    //_message.AppendLine($"          StateSn2CapBkrV:  {output.OutputData.StateSn2CapBkrV}");
                    //_message.AppendLine($"          StateSn1BusBkrV:  {output.OutputData.StateSn1BusBkrV}");
                    //_message.AppendLine($"          StateSn2BusBkrV:  {output.OutputData.StateSn2BusBkrV}");
                    _message.AppendLine($" =====================================================");
                    MainWindow.WriteMessage(_message.ToString());
                }

                #endregion

            }
            catch (Exception ex)
            {
                // Display exceptions to the main window
                MainWindow.WriteError(new InvalidOperationException($"Algorithm exception: {ex.Message}", ex));
            }

            return output;
        }
    }
}
