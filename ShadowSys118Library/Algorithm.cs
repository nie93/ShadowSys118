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
            SystemSettings.LeadTime = 4;
        }

        internal static Output Execute(Inputs inputData, _InputsMeta inputMeta)
        {
            Output output = Output.CreateNew();
            DateTime runTime = DateTime.UtcNow;

            #region [ Message Output ]

            const bool EnableXmlFileLog = false;
            const bool EnableMainWindowMessageDisplay = true;

            #endregion

            #region [ Environment Settings ]

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
                frame = VoltVarController.DeserializeFromXml(InitSysConfigFrameFilePath);
                File.Delete(PrevSysConfigFrameFilePath);

                ActionsAdapter initAction = new ActionsAdapter();
                frame.ExecuteControl(initAction);
            }
            else
            {
                if (File.Exists(PrevSysConfigFrameFilePath))
                {
                    frame = VoltVarController.DeserializeFromXml(PrevSysConfigFrameFilePath);
                }
                else
                {
                    frame = VoltVarController.DeserializeFromXml(InitSysConfigFrameFilePath);
                }
            }

            #endregion

            ActionsAdapter action = new ActionsAdapter();

            frame.SubstationInformation.ConsecCap += 1;
            frame.SubstationInformation.ConsecTap += 1;
            frame.SubstationInformation.Ncdel += 1;
            frame.SubstationInformation.Ntdel += 1;

            #region [ Receive Control Decision from LVC ]

            action.ReadFromEcaInputData(inputData);

            frame.ExecuteControl(action);

            #endregion

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
                                                  frame.ControlCapacitorBanks[1].BusBkrV,
                                                  0,                                       // RegionalLoadIncrementPercentage
                                                  frame.ControlCapacitorBanks[0].CapBkrV,  // SnB34
                                                  frame.ControlCapacitorBanks[2].CapBkrV,  // SnB44
                                                  frame.ControlCapacitorBanks[3].CapBkrV,  // SnB45
                                                  frame.ControlCapacitorBanks[4].CapBkrV,  // SnB48
                                                  frame.ControlCapacitorBanks[5].CapBkrV,  // SnB74
                                                  frame.ControlCapacitorBanks[6].CapBkrV   // SnB105
                                                  );
                        
            frame.SerializeToXml(PrevSysConfigFrameFilePath);

            #endregion

            #region [ Convert Calculated Values to OutputData ]

            // Read LVC Measurement Values from python outputs
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

            // Read RVC Measurement Values from python outputs
            output.OutputData.StateSnB34CapBkrV = Convert.ToInt16(outputFrameList[14]);
            output.OutputData.StateSnB44CapBkrV = Convert.ToInt16(outputFrameList[15]);
            output.OutputData.StateSnB45CapBkrV = Convert.ToInt16(outputFrameList[16]);
            output.OutputData.StateSnB48CapBkrV = Convert.ToInt16(outputFrameList[17]);
            output.OutputData.StateSnB74CapBkrV = Convert.ToInt16(outputFrameList[18]);
            output.OutputData.StateSnB105CapBkrV = Convert.ToInt16(outputFrameList[19]);
            output.OutputData.MeasB1VoltV = Convert.ToDouble(outputFrameList[20]);
            output.OutputData.MeasB2VoltV = Convert.ToDouble(outputFrameList[21]);
            output.OutputData.MeasB3VoltV = Convert.ToDouble(outputFrameList[22]);
            output.OutputData.MeasB4VoltV = Convert.ToDouble(outputFrameList[23]);
            output.OutputData.MeasB5VoltV = Convert.ToDouble(outputFrameList[24]);
            output.OutputData.MeasB6VoltV = Convert.ToDouble(outputFrameList[25]);
            output.OutputData.MeasB7VoltV = Convert.ToDouble(outputFrameList[26]);
            output.OutputData.MeasB8VoltV = Convert.ToDouble(outputFrameList[27]);
            output.OutputData.MeasB9VoltV = Convert.ToDouble(outputFrameList[28]);
            output.OutputData.MeasB10VoltV = Convert.ToDouble(outputFrameList[29]);
            output.OutputData.MeasB11VoltV = Convert.ToDouble(outputFrameList[30]);
            output.OutputData.MeasB12VoltV = Convert.ToDouble(outputFrameList[31]);
            output.OutputData.MeasB13VoltV = Convert.ToDouble(outputFrameList[32]);
            output.OutputData.MeasB14VoltV = Convert.ToDouble(outputFrameList[33]);
            output.OutputData.MeasB15VoltV = Convert.ToDouble(outputFrameList[34]);
            output.OutputData.MeasB16VoltV = Convert.ToDouble(outputFrameList[35]);
            output.OutputData.MeasB17VoltV = Convert.ToDouble(outputFrameList[36]);
            output.OutputData.MeasB18VoltV = Convert.ToDouble(outputFrameList[37]);
            output.OutputData.MeasB19VoltV = Convert.ToDouble(outputFrameList[38]);
            output.OutputData.MeasB20VoltV = Convert.ToDouble(outputFrameList[39]);
            output.OutputData.MeasB21VoltV = Convert.ToDouble(outputFrameList[40]);
            output.OutputData.MeasB22VoltV = Convert.ToDouble(outputFrameList[41]);
            output.OutputData.MeasB23VoltV = Convert.ToDouble(outputFrameList[42]);
            output.OutputData.MeasB24VoltV = Convert.ToDouble(outputFrameList[43]);
            output.OutputData.MeasB25VoltV = Convert.ToDouble(outputFrameList[44]);
            output.OutputData.MeasB26VoltV = Convert.ToDouble(outputFrameList[45]);
            output.OutputData.MeasB27VoltV = Convert.ToDouble(outputFrameList[46]);
            output.OutputData.MeasB28VoltV = Convert.ToDouble(outputFrameList[47]);
            output.OutputData.MeasB29VoltV = Convert.ToDouble(outputFrameList[48]);
            output.OutputData.MeasB30VoltV = Convert.ToDouble(outputFrameList[49]);
            output.OutputData.MeasB31VoltV = Convert.ToDouble(outputFrameList[50]);
            output.OutputData.MeasB32VoltV = Convert.ToDouble(outputFrameList[51]);
            output.OutputData.MeasB33VoltV = Convert.ToDouble(outputFrameList[52]);
            output.OutputData.MeasB34VoltV = Convert.ToDouble(outputFrameList[53]);
            output.OutputData.MeasB35VoltV = Convert.ToDouble(outputFrameList[54]);
            output.OutputData.MeasB36VoltV = Convert.ToDouble(outputFrameList[55]);
            output.OutputData.MeasB37VoltV = Convert.ToDouble(outputFrameList[56]);
            output.OutputData.MeasB38VoltV = Convert.ToDouble(outputFrameList[57]);
            output.OutputData.MeasB39VoltV = Convert.ToDouble(outputFrameList[58]);
            output.OutputData.MeasB40VoltV = Convert.ToDouble(outputFrameList[59]);
            output.OutputData.MeasB41VoltV = Convert.ToDouble(outputFrameList[60]);
            output.OutputData.MeasB42VoltV = Convert.ToDouble(outputFrameList[61]);
            output.OutputData.MeasB43VoltV = Convert.ToDouble(outputFrameList[62]);
            output.OutputData.MeasB44VoltV = Convert.ToDouble(outputFrameList[63]);
            output.OutputData.MeasB45VoltV = Convert.ToDouble(outputFrameList[64]);
            output.OutputData.MeasB46VoltV = Convert.ToDouble(outputFrameList[65]);
            output.OutputData.MeasB47VoltV = Convert.ToDouble(outputFrameList[66]);
            output.OutputData.MeasB48VoltV = Convert.ToDouble(outputFrameList[67]);
            output.OutputData.MeasB49VoltV = Convert.ToDouble(outputFrameList[68]);
            output.OutputData.MeasB50VoltV = Convert.ToDouble(outputFrameList[69]);
            output.OutputData.MeasB51VoltV = Convert.ToDouble(outputFrameList[70]);
            output.OutputData.MeasB52VoltV = Convert.ToDouble(outputFrameList[71]);
            output.OutputData.MeasB53VoltV = Convert.ToDouble(outputFrameList[72]);
            output.OutputData.MeasB54VoltV = Convert.ToDouble(outputFrameList[73]);
            output.OutputData.MeasB55VoltV = Convert.ToDouble(outputFrameList[74]);
            output.OutputData.MeasB56VoltV = Convert.ToDouble(outputFrameList[75]);
            output.OutputData.MeasB57VoltV = Convert.ToDouble(outputFrameList[76]);
            output.OutputData.MeasB58VoltV = Convert.ToDouble(outputFrameList[77]);
            output.OutputData.MeasB59VoltV = Convert.ToDouble(outputFrameList[78]);
            output.OutputData.MeasB60VoltV = Convert.ToDouble(outputFrameList[79]);
            output.OutputData.MeasB61VoltV = Convert.ToDouble(outputFrameList[80]);
            output.OutputData.MeasB62VoltV = Convert.ToDouble(outputFrameList[81]);
            output.OutputData.MeasB63VoltV = Convert.ToDouble(outputFrameList[82]);
            output.OutputData.MeasB64VoltV = Convert.ToDouble(outputFrameList[83]);
            output.OutputData.MeasB65VoltV = Convert.ToDouble(outputFrameList[84]);
            output.OutputData.MeasB66VoltV = Convert.ToDouble(outputFrameList[85]);
            output.OutputData.MeasB67VoltV = Convert.ToDouble(outputFrameList[86]);
            output.OutputData.MeasB68VoltV = Convert.ToDouble(outputFrameList[87]);
            output.OutputData.MeasB69VoltV = Convert.ToDouble(outputFrameList[88]);
            output.OutputData.MeasB70VoltV = Convert.ToDouble(outputFrameList[89]);
            output.OutputData.MeasB71VoltV = Convert.ToDouble(outputFrameList[90]);
            output.OutputData.MeasB72VoltV = Convert.ToDouble(outputFrameList[91]);
            output.OutputData.MeasB73VoltV = Convert.ToDouble(outputFrameList[92]);
            output.OutputData.MeasB74VoltV = Convert.ToDouble(outputFrameList[93]);
            output.OutputData.MeasB75VoltV = Convert.ToDouble(outputFrameList[94]);
            output.OutputData.MeasB76VoltV = Convert.ToDouble(outputFrameList[95]);
            output.OutputData.MeasB77VoltV = Convert.ToDouble(outputFrameList[96]);
            output.OutputData.MeasB78VoltV = Convert.ToDouble(outputFrameList[97]);
            output.OutputData.MeasB79VoltV = Convert.ToDouble(outputFrameList[98]);
            output.OutputData.MeasB80VoltV = Convert.ToDouble(outputFrameList[99]);
            output.OutputData.MeasB81VoltV = Convert.ToDouble(outputFrameList[100]);
            output.OutputData.MeasB82VoltV = Convert.ToDouble(outputFrameList[101]);
            output.OutputData.MeasB83VoltV = Convert.ToDouble(outputFrameList[102]);
            output.OutputData.MeasB84VoltV = Convert.ToDouble(outputFrameList[103]);
            output.OutputData.MeasB85VoltV = Convert.ToDouble(outputFrameList[104]);
            output.OutputData.MeasB86VoltV = Convert.ToDouble(outputFrameList[105]);
            output.OutputData.MeasB87VoltV = Convert.ToDouble(outputFrameList[106]);
            output.OutputData.MeasB88VoltV = Convert.ToDouble(outputFrameList[107]);
            output.OutputData.MeasB89VoltV = Convert.ToDouble(outputFrameList[108]);
            output.OutputData.MeasB90VoltV = Convert.ToDouble(outputFrameList[109]);
            output.OutputData.MeasB91VoltV = Convert.ToDouble(outputFrameList[110]);
            output.OutputData.MeasB92VoltV = Convert.ToDouble(outputFrameList[111]);
            output.OutputData.MeasB93VoltV = Convert.ToDouble(outputFrameList[112]);
            output.OutputData.MeasB94VoltV = Convert.ToDouble(outputFrameList[113]);
            output.OutputData.MeasB95VoltV = Convert.ToDouble(outputFrameList[114]);
            output.OutputData.MeasB96VoltV = Convert.ToDouble(outputFrameList[115]);
            output.OutputData.MeasB97VoltV = Convert.ToDouble(outputFrameList[116]);
            output.OutputData.MeasB98VoltV = Convert.ToDouble(outputFrameList[117]);
            output.OutputData.MeasB99VoltV = Convert.ToDouble(outputFrameList[118]);
            output.OutputData.MeasB100VoltV = Convert.ToDouble(outputFrameList[119]);
            output.OutputData.MeasB101VoltV = Convert.ToDouble(outputFrameList[120]);
            output.OutputData.MeasB102VoltV = Convert.ToDouble(outputFrameList[121]);
            output.OutputData.MeasB103VoltV = Convert.ToDouble(outputFrameList[122]);
            output.OutputData.MeasB104VoltV = Convert.ToDouble(outputFrameList[123]);
            output.OutputData.MeasB105VoltV = Convert.ToDouble(outputFrameList[124]);
            output.OutputData.MeasB106VoltV = Convert.ToDouble(outputFrameList[125]);
            output.OutputData.MeasB107VoltV = Convert.ToDouble(outputFrameList[126]);
            output.OutputData.MeasB108VoltV = Convert.ToDouble(outputFrameList[127]);
            output.OutputData.MeasB109VoltV = Convert.ToDouble(outputFrameList[128]);
            output.OutputData.MeasB110VoltV = Convert.ToDouble(outputFrameList[129]);
            output.OutputData.MeasB111VoltV = Convert.ToDouble(outputFrameList[130]);
            output.OutputData.MeasB112VoltV = Convert.ToDouble(outputFrameList[131]);
            output.OutputData.MeasB113VoltV = Convert.ToDouble(outputFrameList[132]);
            output.OutputData.MeasB114VoltV = Convert.ToDouble(outputFrameList[133]);
            output.OutputData.MeasB115VoltV = Convert.ToDouble(outputFrameList[134]);
            output.OutputData.MeasB116VoltV = Convert.ToDouble(outputFrameList[135]);
            output.OutputData.MeasB117VoltV = Convert.ToDouble(outputFrameList[136]);
            output.OutputData.MeasB118VoltV = Convert.ToDouble(outputFrameList[137]);

            output.OutputData.StateLoad = Convert.ToDouble(inputData.LoadIncrementPercentage);


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
                    //_message.AppendLine($" ------------------ CsvInputAdapter ------------------ ");
                    //_message.AppendLine($"  LoadIncrementPercentage:  {inputData.LoadIncrementPercentage:0.0000} %");
                    //_message.AppendLine($" ------------------- ActionChannel ------------------- ");
                    //_message.AppendLine($"               ActTxRaise:  {inputData.ActTxRaise}");
                    //_message.AppendLine($"               ActTxLower:  {inputData.ActTxLower}");
                    //_message.AppendLine($"              ActSn1Close:  {inputData.ActSn1Close}");
                    //_message.AppendLine($"               ActSn1Trip:  {inputData.ActSn1Trip}");
                    //_message.AppendLine($"              ActSn2Close:  {inputData.ActSn2Close}");
                    //_message.AppendLine($"               ActSn2Trip:  {inputData.ActSn2Trip}");
                    //_message.AppendLine($" ---------------- MeasurementChannel ----------------- ");
                    //_message.AppendLine($"              MeasTxVoltV:  {output.OutputData.MeasTxVoltV:0.000} Volts");
                    //_message.AppendLine($"             MeasSn1VoltV:  {output.OutputData.MeasSn1VoltV:0.000} Volts");
                    //_message.AppendLine($"             MeasSn2VoltV:  {output.OutputData.MeasSn2VoltV:0.000} Volts");
                    //_message.AppendLine($"                MeasTxMwV:  {output.OutputData.MeasTxMwV:0.000} MW");
                    //_message.AppendLine($"               MeasTxMvrV:  {output.OutputData.MeasTxMvrV:0.000} MVar");
                    //_message.AppendLine($"               MeasGn1MwV:  {output.OutputData.MeasGn1MwV:0.000} MW");
                    //_message.AppendLine($"              MeasGn1MvrV:  {output.OutputData.MeasGn1MvrV:0.000} MVar");
                    //_message.AppendLine($"               MeasGn2MwV:  {output.OutputData.MeasGn2MwV:0.000} MW");
                    //_message.AppendLine($"              MeasGn2MvrV:  {output.OutputData.MeasGn2MvrV:0.000} MVar");
                    //_message.AppendLine($" ------------------- StateChannel -------------------- ");
                    _message.AppendLine($"                  StateLoad:  {output.OutputData.StateLoad} ");
                    //_message.AppendLine($"              StateTxTapV:  {output.OutputData.StateTxTapV}");
                    //_message.AppendLine($"          StateSn1CapBkrV:  {output.OutputData.StateSn1CapBkrV}");
                    //_message.AppendLine($"          StateSn2CapBkrV:  {output.OutputData.StateSn2CapBkrV}");
                    //_message.AppendLine($"          StateSn1BusBkrV:  {output.OutputData.StateSn1BusBkrV}");
                    //_message.AppendLine($"          StateSn2BusBkrV:  {output.OutputData.StateSn2BusBkrV}");
                    //_message.AppendLine($"          StateSnB34CapBkrV:  {output.OutputData.StateSnB34CapBkrV}");
                    //_message.AppendLine($"          StateSnB44CapBkrV:  {output.OutputData.StateSnB44CapBkrV}");
                    //_message.AppendLine($"          StateSnB45CapBkrV:  {output.OutputData.StateSnB45CapBkrV}");
                    //_message.AppendLine($"          StateSnB48CapBkrV:  {output.OutputData.StateSnB48CapBkrV}");
                    //_message.AppendLine($"          StateSnB74CapBkrV:  {output.OutputData.StateSnB74CapBkrV}");
                    //_message.AppendLine($"         StateSnB105CapBkrV:  {output.OutputData.StateSnB105CapBkrV}");
                    _message.AppendLine($" ------------------ RVCActionChannel ----------------- ");
                    _message.AppendLine($"                * :  | 34 | 44 | 45 | 48 | 74 | 105 |");
                    _message.AppendLine($"      ActSnB*Close:  |  {inputData.ActSnB34Close} |  {inputData.ActSnB44Close} |  {inputData.ActSnB45Close} |  {inputData.ActSnB48Close} |  {inputData.ActSnB74Close} |   {inputData.ActSnB105Close} |");
                    _message.AppendLine($"       ActSnB*Trip:  |  {inputData.ActSnB34Trip} |  {inputData.ActSnB44Trip} |  {inputData.ActSnB45Trip} |  {inputData.ActSnB48Trip} |  {inputData.ActSnB74Trip} |   {inputData.ActSnB105Trip} |");
                    _message.AppendLine($"  StateSnB*CapBkrV:  |  {output.OutputData.StateSnB34CapBkrV} |  {output.OutputData.StateSnB44CapBkrV} |  {output.OutputData.StateSnB45CapBkrV} |  {output.OutputData.StateSnB48CapBkrV} |  {output.OutputData.StateSnB74CapBkrV} |   {output.OutputData.StateSnB105CapBkrV} |");
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
