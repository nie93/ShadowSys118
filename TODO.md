# TODO List for ShadowSys118 Solution

Zhijie Nie, 2017-06-27

## Program Development
* (C#) Implement `VoltVarController` class to ShadowSys118



## Documentation

| I/O | Name | DataType | PointTag | SignalType | SignalReference | ID (Assigned) |
| :-: | :--- | :------- | :------- | :--------: | :-------------- | :------------ |
| I | LoadIncrementPercentage | double | SS_118:LOADINCRE | DIGI | SS118-LOADINCRE | PPA:41 |
| I | ActTxRaise      | short  | SS_118:ACTTXRAISE      | DIGI | SS118-ACTXRAISE   | PPA:42 |
| I | ActTxLower      | short  | SS_118:ACTTXLOWER      | DIGI | SS118-ACTTXLOWER  | PPA:43 |
| I | ActSn1Close     | short  | SS_118:ACTSN1CLOSE     | DIGI | SS118-ACTSN1CLOSE | PPA:44 |
| I | ActSn1Trip      | short  | SS_118:ACTSN1TRIP      | DIGI | SS118-ACTSN1TRIP  | PPA:45 |
| I | ActSn2Close     | short  | SS_118:ACTSN2CLOSE     | DIGI | SS118-ACTSN2CLOSE | PPA:46 |
| I | ActSn2Trip      | short  | SS_118:ACTSN2TRIP      | DIGI | SS118-ACTSN2TRIP  | PPA:47 |
| O | StateTxTapV     | short  | SS_118:STATETXTAPV     | DIGI | SS118-STATETXTAPV | PPA:48 |
| O | StateSn1CapBkrV | short  | SS_118:STATESN1CAPBKRV | DIGI | SS118-STATESN1CAPBKRV | PPA:49 |
| O | StateSn2CapBkrV | short  | SS_118:STATESN2CAPBKRV | DIGI | SS118-STATESN2CAPBKRV | PPA:50 |
| O | StateSn1BusBkrV | short  | SS_118:STATESN1BUSBKRV | DIGI | SS118-STATESN1BUSBKRV | PPA:51 |
| O | StateSn2BusBkrV | short  | SS_118:STATESN2BUSBKRV | DIGI | SS118-STATESN2BUSBKRV | PPA:52 |
| O | MeasTxVoltV     | double | SS_118:MEASTXVOLTV     | VPHM | SS118-MEASTXVOLTV  | PPA:53 |
| O | MeasSn1VoltV    | double | SS_118:MEASSN1VOLTV    | VPHM | SS118-MEASSN1VOLTV | PPA:54 |
| O | MeasSn2VoltV    | double | SS_118:MEASSN2VOLTV    | VPHM | SS118-MEASSN2VOLTV | PPA:55 |
| O | MeasTxMwV       | double | SS_118:MEASTXMWV       | CALC | SS118-MEASTXMWV    | PPA:56 |
| O | MeasTxMvrV      | double | SS_118:MEASTXMVRV      | CALC | SS118-MEASTXMVRV   | PPA:57 |
| O | MeasGn1MwV      | double | SS_118:MEASGN1MWV      | CALC | SS118-MEASGN1MWV   | PPA:58 |
| O | MeasGn1MvrV     | double | SS_118:MEASGN1MVRV     | CALC | SS118-MEASGN1MVRV  | PPA:59 |
| O | MeasGn2MwV      | double | SS_118:MEASGN2MWV      | CALC | SS118-MEASGN2MWV   | PPA:60 |
| O | MeasGn2MvrV     | double | SS_118:MEASGN2MVRV     | CALC | SS118-MEASGN2MVRV  | PPA:61 |

```sql
-- Shadow System for 118 bus system (ShadowSys118)
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:LOADINCRE', 9, NULL, 'SS118-LOADINCRE', 'Shadow System for 118-bus system - Load Increment in percentage', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTTXRAISE', 9, NULL, 'SS118-ACTTXRAISE', 'Shadow System for 118-bus system - Action flag of raising load-tap-changer ActTxRaise', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTTXLOWER', 9, NULL, 'SS118-ACTTXLOWER', 'Shadow System for 118-bus system - Action flag of lowering load-tap-changer ActTxLower', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSN1CLOSE', 9, NULL, 'SS118-ACTSN1CLOSE', 'Shadow System for 118-bus system - Action flag of closing capacitor bank 1 circuit breaker ActSn1Close', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSN1TRIP', 9, NULL, 'SS118-ACTSN1TRIP', 'Shadow System for 118-bus system - Action flag of tripping capacitor bank 1 circuit breaker ActSn1Trip', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSN2CLOSE', 9, NULL, 'SS118-ACTSN2CLOSE', 'Shadow System for 118-bus system - Action flag of closing capacitor bank 2 circuit breaker ActSn2Close', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSN2TRIP', 9, NULL, 'SS118-ACTSN2TRIP', 'Shadow System for 118-bus system - Action flag of tripping capacitor bank 2 circuit breaker ActSn2Trip', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATETXTAPV', 9, NULL, 'SS118-STATETXTAPV', 'Shadow System for 118-bus system - Transformer load-tap-changer state value StateTxTapV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESN1CAPBKRV', 9, NULL, 'SS118-STATESN1CAPBKRV', 'Shadow System for 118-bus system - Capacitor bank 1 shunt circuit breaker state value StateSn1CapBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESN2CAPBKRV', 9, NULL, 'SS118-STATESN2CAPBKRV', 'Shadow System for 118-bus system - Capacitor bank 2 shunt circuit breaker state value StateSn2CapBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESN1BUSBKRV', 9, NULL, 'SS118-STATESN1BUSBKRV', 'Shadow System for 118-bus system - Capacitor bank 1 bus circuit breaker state value StateSn1BusBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESN2BUSBKRV', 9, NULL, 'SS118-STATESN2BUSBKRV', 'Shadow System for 118-bus system - Capacitor bank 2 bus circuit breaker state value StateSn2BusBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASTXVOLTV', 3, NULL, 'SS118-MEASTXVOLTV', 'Shadow System for 118-bus system - Transformer high-side bus voltage value MeasTxVoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASSN1VOLTV', 3, NULL, 'SS118-MEASSN1VOLTV', 'Shadow System for 118-bus system - Capacitor bank 1  local bus voltage value MeasSn1VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASSN2VOLTV', 3, NULL, 'SS118-MEASSN2VOLTV', 'Shadow System for 118-bus system - Capacitor bank 2  local bus voltage value MeasSn2VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASTXMWV', 10, NULL, 'SS118-MEASTXMWV', 'Shadow System for 118-bus system -  Transformer transferred active power MeasTxMwV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASTXMVRV', 10, NULL, 'SS118-MEASTXMVRV', 'Shadow System for 118-bus system -  Transformer transferred reactive power MeasTxMvrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASGN1MWV', 10, NULL, 'SS118-MEASGN1MWV', 'Shadow System for 118-bus system -  Generator 1 transferred active power MeasGn1MwV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASGN1MVRV', 10, NULL, 'SS118-MEASGN1MVRV', 'Shadow System for 118-bus system -  Generator 1 transferred reactive power MeasGn1MvrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASGN2MWV', 10, NULL, 'SS118-MEASGN2MWV', 'Shadow System for 118-bus system -  Generator 2 transferred active power MeasGn2MwV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASGN2MVRV', 10, NULL, 'SS118-MEASGN2MVRV', 'Shadow System for 118-bus system -  Generator 2 transferred reactive power MeasGn2MvrV', 1);

```

## Coding Improvements


## Need to Knows
* TestHarness is just a tool for developing an analytic - the actual end product will be an 
**installable Windows service**.


## Backup - Input Adapters `ConnectionString` 

### SSCSV
```
Filename=C:\Program Files\openECA\Server\20170626_ShadowSys_Inputs.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:1; 2 = PPA:2}
```

### LVCCSV
```
Filename=C:\Program Files\openECA\Server\20170608_LVC_Inputs.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:21; 2 = PPA:22; 3 = PPA:23; 4 = PPA:24; 5 = PPA:25; 6 = PPA:26; 7 = PPA:27; 8 = PPA:28; 9 = PPA:29; 10 = PPA:30; 11 = PPA:31; 12 = PPA:32}
```
### SS118CSV
```
Filename=C:\Program Files\openECA\Server\20170620_ShadowSys_Inputs.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 2 = PPA:41}
```

## Issues


## Completed Tasks
* (PSS/E) Choose a localized area for voltage control in 118-bus System
* (openECA) Reserve **ActionsChannel** for Actions of RAISE, LOWER, CLOSE, TRIP
* (openECA) Create **Measurements** for IEEE 118-bus System by adding queries to `SampleDataSet.sql` 
script
* (openECA) Backup `ConnectionString` for Input Adapters