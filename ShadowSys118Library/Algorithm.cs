using System;
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
            SystemSettings.FramesPerSecond = 2;
            SystemSettings.LagTime = 3;
            SystemSettings.LeadTime = 1;
        }

        internal static Output Execute(Inputs inputData, _InputsMeta inputMeta)
        {
            Output output = Output.CreateNew();

            #region [ Environment Settings ]
            const bool EnableXmlFileLog = false;
            const bool EnableMainWindowMessageDisplay = false;

            string MainFolderPath = (@"C:\Users\niezj\Documents\dom\ShadowSys118\");
            string DataFolderPath = Path.Combine(MainFolderPath, @"Data");
            string LogFolderPath = Path.Combine(MainFolderPath, @"Log");
            string ConfigurationFolderPath = Path.Combine(MainFolderPath, @"ShadowSysConfiguration");
            string ProjFolderPath = Path.Combine(MainFolderPath, @"ShadowSysLibrary");
            string PythonCodeFolderPath = Path.Combine(MainFolderPath, @"PythonCode");

            string CaseFileName = "IEEE_118_Bus.sav";
            string CsvOutputsFileName = "Outputs.csv";
            //string ConfigurationFileName = "Configurations.xml";
            //string CtrlDecisionFrameFileName = "ctrl_SysConfigFrame.xml";
            //string InitSysConfigFrameFileName = "init_SysConfigFrame.xml";
            //string PrevSysConfigFrameFileName = "prev_SysConfigFrame.xml";

            string CaseFilePath = Path.Combine(PythonCodeFolderPath, CaseFileName);
            string CsvOutputsFilePath = Path.Combine(LogFolderPath, CsvOutputsFileName);
            //string ConfigurationFilePath = Path.Combine(ConfigurationFolderPath, ConfigurationFileName);
            //string CtrlDecisionFrameFilePath = Path.Combine(ConfigurationFolderPath, CtrlDecisionFrameFileName);
            //string InitSysConfigFrameFilePath = Path.Combine(ConfigurationFolderPath, InitSysConfigFrameFileName);
            //string PrevSysConfigFrameFilePath = Path.Combine(ConfigurationFolderPath, PrevSysConfigFrameFileName);
            #endregion

            #region [ NOT IMPLEMENTED YET: Update Configurations of Controlled Devices ]

            VoltVarController frame = new VoltVarController();

            //// Read System Configuration from XML file
            //if (File.Exists(CtrlDecisionFrameFilePath))
            //{
            //    frame = VoltVarController.DeserializeFromXml(CtrlDecisionFrameFilePath);
            //}
            //else
            //{
            //    if (File.Exists(PrevSysConfigFrameFilePath))
            //    {
            //        frame = VoltVarController.DeserializeFromXml(PrevSysConfigFrameFilePath);
            //    }
            //    else
            //    {
            //        frame = VoltVarController.DeserializeFromXml(InitSysConfigFrameFilePath);
            //    }
            //}

            //frame.SerializeToXml(PrevSysConfigFrameFilePath);

            #endregion

            #region [ PSEUDO: Update Configurations of Controlled Devices ]

            output.OutputData.StateTxTapV = 0;
            output.OutputData.StateSn1CapBkrV = 0;
            output.OutputData.StateSn2CapBkrV = 0;
            output.OutputData.StateSn1BusBkrV = 1;
            output.OutputData.StateSn2BusBkrV = 1;

            #endregion


            #region [ Run Power Flow Calculation using PSS/E ]
            // Call Python script to run power flow calculation
            PythonScripts Python = new PythonScripts();
            Python.RunPythonCmd(Path.Combine(PythonCodeFolderPath, "CalculatePowerFlow.py"),
                                MainFolderPath,
                                CaseFileName,
                                CsvOutputsFileName,
                                inputData.LoadIncrementPercentage,
                                output.OutputData.StateTxTapV,     //frame.ControlTransformers[0].TapV,
                                output.OutputData.StateSn1CapBkrV, //frame.ControlTransformers[1].TapV,
                                output.OutputData.StateSn2CapBkrV, //frame.ControlCapacitorBanks[0].CapBkrV,
                                output.OutputData.StateSn1BusBkrV, //frame.ControlCapacitorBanks[1].CapBkrV,
                                output.OutputData.StateSn2BusBkrV  //frame.ControlCapacitorBanks[0].BusBkrV,                                                                  
                                );

            #endregion



            #region [ Output Calculated Values to Metadata ]
            // Read Measurement Values from CSV file
            CsvLineAdapter CsvLineReader = new CsvLineAdapter();
            CsvLineReader.ReadCsvLastLine(CsvOutputsFilePath);
            output.OutputData.StateTxTapV = Convert.ToInt16(CsvLineReader.LineArray[0]);
            output.OutputData.StateSn1CapBkrV = Convert.ToInt16(CsvLineReader.LineArray[1]);
            output.OutputData.StateSn2CapBkrV = Convert.ToInt16(CsvLineReader.LineArray[2]);
            output.OutputData.StateSn1BusBkrV = Convert.ToInt16(CsvLineReader.LineArray[3]);
            output.OutputData.StateSn2BusBkrV = Convert.ToInt16(CsvLineReader.LineArray[4]);
            output.OutputData.MeasTxVoltV = Convert.ToDouble(CsvLineReader.LineArray[5]);
            output.OutputData.MeasSn1VoltV = Convert.ToDouble(CsvLineReader.LineArray[6]);
            output.OutputData.MeasSn2VoltV = Convert.ToDouble(CsvLineReader.LineArray[7]);
            output.OutputData.MeasTxMwV = Convert.ToDouble(CsvLineReader.LineArray[8]);
            output.OutputData.MeasTxMvrV = Convert.ToDouble(CsvLineReader.LineArray[9]);
            output.OutputData.MeasGn1MwV = Convert.ToDouble(CsvLineReader.LineArray[10]);
            output.OutputData.MeasGn1MvrV = Convert.ToDouble(CsvLineReader.LineArray[11]);
            output.OutputData.MeasGn2MwV = Convert.ToDouble(CsvLineReader.LineArray[12]);
            output.OutputData.MeasGn2MvrV = Convert.ToDouble(CsvLineReader.LineArray[13]);

            #endregion


            try
            {
                // TODO: Implement your algorithm here...
                // You can also write messages to the main window:

                #region [ Write Xml Log File ]
                //if (EnableXmlFileLog)
                //{
                //    string ConfigFrameXMLLogFileName = $"Log_SysConfigFrame_{DateTime.UtcNow:yyMMdd_HHmmss}.xml";
                //    string ConfigFrameXMLLogFilePath = Path.Combine(LogFolderPath, ConfigFrameXMLLogFileName);
                //    frame.SerializeToXml(ConfigFrameXMLLogFilePath);
                //}
                #endregion

                #region [ Write openECA Client Windows Message ]
                if (EnableMainWindowMessageDisplay)
                {
                    StringBuilder _message = new StringBuilder();
                    _message.Append($"\n ================ ShadowSys Analytics ================");
                    _message.Append($"\n                 Run Time:  {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}");
                    _message.Append($"\n  LoadIncrementPercentage:  {inputData.LoadIncrementPercentage:0.0000} %");
                    _message.Append($"\n -----------------------------------------------------");
                    _message.Append($"\n              StateTxTapV:  {output.OutputData.StateTxTapV}");
                    _message.Append($"\n          StateSn1CapBkrV:  {output.OutputData.StateSn1CapBkrV}");
                    _message.Append($"\n          StateSn2CapBkrV:  {output.OutputData.StateSn2CapBkrV}");
                    _message.Append($"\n          StateSn1BusBkrV:  {output.OutputData.StateSn1BusBkrV}");
                    _message.Append($"\n          StateSn2BusBkrV:  {output.OutputData.StateSn2BusBkrV}");
                    _message.Append($"\n              MeasTxVoltV:  {output.OutputData.MeasTxVoltV:0.000} Volts");
                    _message.Append($"\n             MeasSn1VoltV:  {output.OutputData.MeasSn1VoltV:0.000} Volts");
                    _message.Append($"\n             MeasSn2VoltV:  {output.OutputData.MeasSn2VoltV:0.000} Volts");
                    _message.Append($"\n                MeasTxMwV:  {output.OutputData.MeasTxMwV:0.000} MW");
                    _message.Append($"\n               MeasTxMvrV:  {output.OutputData.MeasTxMvrV:0.000} MVar");
                    _message.Append($"\n               MeasGn1MwV:  {output.OutputData.MeasGn1MwV:0.000} MW");
                    _message.Append($"\n              MeasGn1MvrV:  {output.OutputData.MeasGn1MvrV:0.000} MVar");
                    _message.Append($"\n               MeasGn2MwV:  {output.OutputData.MeasGn2MwV:0.000} MW");
                    _message.Append($"\n              MeasGn2MvrV:  {output.OutputData.MeasGn2MvrV:0.000} MVar");
                    _message.Append($"\n =====================================================");
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
