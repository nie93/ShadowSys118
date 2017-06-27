# TODO List for ShadowSys118 Solution

Zhijie Nie, 2017-06-27

## Program Development
* (PSS/E) Choose a localized area for voltage control in 118-bus System
* (openECA) Create **Measurements** for IEEE 118-bus System by adding queries to `SampleDataSet.sql` 
script
* (openECA) Backup `ConnectionString` for Input Adapters
* (openECA) Reserve **ActionsChannel** for Actions of RAISE, LOWER, CLOSE, TRIP


## Documentation

| I/O | Name | DataType | PointTag | SignalType | SignalReference |
| :-: | :--- | :------- | :------- | :--------: | :-------------- |
| I | LoadIncrementPercentage | double | SS_118:LOADINCRE | DIGI | SSVIR-LOADINCRE |
| I | ActRaise        | short  | SS_118:ACTRAISE        | DIGI | SS118-ACTRAISE |
| I | ActLower        | short  | SS_118:ACTLOWER        | DIGI | SS118-ACTLOWER |
| I | ActClose        | short  | SS_118:ACTCLOSE        | DIGI | SS118-ACTCLOSE |
| I | ActTrip         | short  | SS_118:ACTTRIP         | DIGI | SS118-ACTTRIP  |
| O | StateTxTapV     | short  | SS_118:STATETXTAPV     | DIGI | SS118-STATETXTAPV |
| O | StateSn1CapBkrV | short  | SS_118:STATESN1CAPBKRV | DIGI | SS118-STATESN1CAPBKRV |
| O | StateSn2CapBkrV | short  | SS_118:STATESN2CAPBKRV | DIGI | SS118-STATESN2CAPBKRV |
| O | StateSn1BusBkrV | short  | SS_118:STATESN1BUSBKRV | DIGI | SS118-STATESN1BUSBKRV |
| O | StateSn2BusBkrV | short  | SS_118:STATESN2BUSBKRV | DIGI | SS118-STATESN2BUSBKRV |
| O | MeasTxVoltV     | double | SS_118:MEASTXVOLTV     | VPHM | SS118-MEASTXVOLTV  |
| O | MeasSn1VoltV    | double | SS_118:MEASSN1VOLTV    | VPHM | SS118-MEASSN1VOLTV |
| O | MeasSn2VoltV    | double | SS_118:MEASSN2VOLTV    | VPHM | SS118-MEASSN2VOLTV |
| O | MeasTxMwV       | double | SS_118:MEASTXMWV       | CALC | SS118-MEASTXMWV    |
| O | MeasTxMvrV      | double | SS_118:MEASTXMVRV      | CALC | SS118-MEASTXMVRV   |
| O | MeasGnMwV       | double | SS_118:MEASGNMWV       | CALC | SS118-MEASGNMWV    |
| O | MeasGnMvrV      | double | SS_118:MEASGNMVRV      | CALC | SS118-MEASGNMVRV   |


## Coding Improvements


## Need to Knows
* TestHarness is just a tool for developing an analytic - the actual end product will be an 
**installable Windows service**.


## Issues


## Completed Tasks