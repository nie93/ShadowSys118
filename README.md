# ShadowSys118
This is the Analytic project of Shadow System using IEEE 118-bus system, generated using openECA 
Client v1.0.5.0.


## I/Os for LVC usage
| I/O | Name | DataType | PointTag | SignalType | SignalReference | ID (Assigned) |
| :-: | :--- | :------- | :------- | :--------: | :-------------- | :------------ |
| I | ResetSignal     | short | SS_118:RESET | DIGI | SS118-RESET | PPA:62 |
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


## I/Os for RVC usage
| I/O | Name | DataType | PointTag | SignalType | SignalReference | ID (Assigned) |
| :-: | :--- | :------- | :------- | :--------: | :-------------- | :------------ |
| I | ResetSignal     | short | SS_118:RESET | DIGI | SS118-RESET | PPA:62 |
| I | LoadIncrementPercentage | double | SS_118:LOADINCRE | DIGI | SS118-LOADINCRE | PPA:41 |
| I | ActSnB34Close  | short | SS_118:ACTSNB34CLOSE  | DIGI | SS118-ACTSNB34CLOSE  | PPA:63 |
| I | ActSnB44Close  | short | SS_118:ACTSNB44CLOSE  | DIGI | SS118-ACTSNB44CLOSE  | PPA:64 |
| I | ActSnB45Close  | short | SS_118:ACTSNB45CLOSE  | DIGI | SS118-ACTSNB45CLOSE  | PPA:65 |
| I | ActSnB48Close  | short | SS_118:ACTSNB48CLOSE  | DIGI | SS118-ACTSNB48CLOSE  | PPA:66 |
| I | ActSnB74Close  | short | SS_118:ACTSNB74CLOSE  | DIGI | SS118-ACTSNB74CLOSE  | PPA:67 |
| I | ActSnB105Close | short | SS_118:ACTSNB105CLOSE | DIGI | SS118-ACTSNB105CLOSE | PPA:68 |
| I | ActSnB34Trip   | short | SS_118:ACTSNB34TRIP   | DIGI | SS118-ACTSNB34TRIP   | PPA:69 |
| I | ActSnB44Trip   | short | SS_118:ACTSNB44TRIP   | DIGI | SS118-ACTSNB44TRIP   | PPA:70 |
| I | ActSnB45Trip   | short | SS_118:ACTSNB45TRIP   | DIGI | SS118-ACTSNB45TRIP   | PPA:71 |
| I | ActSnB48Trip   | short | SS_118:ACTSNB48TRIP   | DIGI | SS118-ACTSNB48TRIP   | PPA:72 |
| I | ActSnB74Trip   | short | SS_118:ACTSNB74TRIP   | DIGI | SS118-ACTSNB74TRIP   | PPA:73 |
| I | ActSnB105Trip  | short | SS_118:ACTSNB105TRIP  | DIGI | SS118-ACTSNB105TRIP  | PPA:74 |
| O | StateSnB34CapBkrV  | short | SS_118:STATESNB34CAPBKRV  | DIGI | SS118-STATESNB34CAPBKRV  | PPA:75 |
| O | StateSnB44CapBkrV  | short | SS_118:STATESNB44CAPBKRV  | DIGI | SS118-STATESNB44CAPBKRV  | PPA:76 |
| O | StateSnB45CapBkrV  | short | SS_118:STATESNB45CAPBKRV  | DIGI | SS118-STATESNB45CAPBKRV  | PPA:77 |
| O | StateSnB48CapBkrV  | short | SS_118:STATESNB48CAPBKRV  | DIGI | SS118-STATESNB48CAPBKRV  | PPA:78 |
| O | StateSnB74CapBkrV  | short | SS_118:STATESNB74CAPBKRV  | DIGI | SS118-STATESNB74CAPBKRV  | PPA:79 |
| O | StateSnB105CapBkrV | short | SS_118:STATESNB105CAPBKRV | DIGI | SS118-STATESNB105CAPBKRV | PPA:80 |
| O | MeasB1VoltV   | double | SS_118:MEASB1VOLTV   | VPHM | SS118-MEASB1VOLTV   | PPA:81 |
| . | ...           | ...    | ...                  | ...  | ...                 | ...  |
| O | MeasB118VoltV | double | SS_118:MEASB118VOLTV | VPHM | SS118-MEASB118VOLTV | PPA:198 |



## System Requirements
* openECA v1.0.5.0 or higher
* Visual Studio
* Python 2.7.x
* PSS/E 33 or PSS/E 34


