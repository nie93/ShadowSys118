# region [ Python Environment Setup ]

from __future__ import with_statement
from __future__ import division
from contextlib import contextmanager
import os, sys, csv, pdb

PSSE_LOCATION_34 = r"""C:\Program Files (x86)\PTI\PSSE34\PSSPY27"""
PSSE_LOCATION_33 = r"""C:\Program Files (x86)\PTI\PSSE33\PSSBIN"""
if os.path.isdir(PSSE_LOCATION_34):
    sys.path.append(PSSE_LOCATION_34)
    import psse34, psspy

else:
    os.environ['PATH'] = PSSE_LOCATION_33 + ';' + os.environ['PATH']
    sys.path.append(PSSE_LOCATION_33)
    import psspy

from psspy import _i, _f
from pprint import pprint
import numpy as np
import scipy as sp

import StringIO

import redirect
redirect.psse2py()

# endregion


@contextmanager
# region [ Defined Functions ]
def silence(file_object=None):
    """
    Discard stdout (i.e. write to null device) or
    optionally write to given file-like object.
    """
    if file_object is None:
        file_object = open(os.devnull, 'w')

    old_stdout = sys.stdout
    try:
        sys.stdout = file_object
        yield
    finally:
        sys.stdout = old_stdout


def get_branch_flow(from_bus_num, to_bus_num):
    brn_flow = []
    for i in range(0, 2):
        ierr, cmpval = psspy.brnflo(to_bus_num, from_bus_num, str(1))
        brn_flow.append(cmpval)
        ierr, cmpval = psspy.brnflo(to_bus_num, from_bus_num, str(2))
        brn_flow.append(cmpval)
    return brn_flow


def get_bus_voltage(bus_num):
    psspy.bsys(sid=1, numbus=len(bus_num), buses=bus_num)
    ierr, bus_voltage = psspy.abusreal(1, 1, ['PU'])
    bus_voltage = bus_voltage[0]
    return bus_voltage


def get_gen_active_power(gen_bus):
    psspy.bsys(sid=2, numbus=len(gen_bus), buses=gen_bus)
    ierr, Pgen = psspy.amachreal(sid=2, flag=1, string='O_PGEN')
    Pgen = Pgen[0]
    return Pgen


def get_gen_reactive_power(gen_bus):
    psspy.bsys(sid=2, numbus=len(gen_bus), buses=gen_bus)
    ierr, Qgen = psspy.amachreal(sid=2, flag=1, string='O_QGEN')
    Qgen = Qgen[0]
    return Qgen


def get_load_bus(bus_num):
    # Get the Load Buses Numbers
    psspy.bsys(0, 0, [0.2, 999.], 0, [], len(bus_num), bus_num, 0, [], 0, [])
    ierr, load_bus = psspy.alodbusint(sid=0, flag=1, string=['NUMBER'])
    load_bus = load_bus[0]
    return load_bus


def get_shunt_voltage(bus_num):
    psspy.bsys(sid=1, numbus=1, buses=bus_num[0])
    ierr, shunt_Pamplin_voltage = psspy.abusreal(1, 1, ['PU'])
    shunt_Pamplin_voltage = shunt_Pamplin_voltage[0][0]

    psspy.bsys(sid=1, numbus=1, buses=bus_num[1])
    ierr, shunt_Crewe_voltage = psspy.abusreal(1, 1, ['PU'])
    shunt_Crewe_voltage = shunt_Crewe_voltage[0][0]

    shunt_bus_voltage = [shunt_Pamplin_voltage, shunt_Crewe_voltage]
    return shunt_bus_voltage


def get_transformer_ratio(bus_num):
    psspy.bsys(sid=1, numbus=2, buses=bus_num)
    ierr, ratio = psspy.atrnreal(sid=1, owner=2, ties=1, flag=2, entry=1,
                                 string=['RATIO2'])
    return ratio[0]


def get_transformer_voltage(bus_num):
    psspy.bsys(sid=1, numbus=len(bus_num), buses=bus_num)
    ierr, bus_voltage = psspy.abusreal(1, 1, ['PU'])
    bus_voltage = bus_voltage[0]
    return bus_voltage


def set_capbank_breaker_value(bus_num, breaker_status):
    # Configure capacitor bank breaker value (Switching ON/OFF)
    for i in range(0, len(bus_num)):
        if breaker_status[i] == 0:
            if bus_num[i] == 34:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 0])
            elif bus_num[i] == 39:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 0])
            elif bus_num[i] == 44:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 10])
            elif bus_num[i] == 45:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 10])
            elif bus_num[i] == 48:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 0])
            elif bus_num[i] == 74:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 12])
            elif bus_num[i] == 105:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 0])
        elif breaker_status[i] == 1:
            # Capacity value of capacitor bank is given by PSS/E
            if bus_num[i] == 34:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 50])
            elif bus_num[i] == 39:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 50])
            elif bus_num[i] == 44:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 50])
            elif bus_num[i] == 45:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 50])
            elif bus_num[i] == 48:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 100])
            elif bus_num[i] == 74:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 100])
            elif bus_num[i] == 105:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 20])


def set_load_increment_percentage(bus_num, percentage):
    load_bus_num = get_load_bus(bus_num)
    psspy.bsys(0, 0, [0.0, 0.0], 0, [], len(load_bus_num), load_bus_num, 0, [],
               0, [])
    psspy.scal(sid=0, all=0, apiopt=0, status1=2, status3=1, status4=1,
               scalval1=percentage)


def set_transformer_ratio(bus_num, tap_value, ratio_step):
    ratio = get_transformer_ratio(bus_num)
    ratio[0] = ratio[0] - tap_value * ratio_step
    psspy.two_winding_chng_4(37, 38, r"""1""",
                             [_i, _i, _i, _i, _i, _i, _i, _i, 37, _i, _i, 1,
                              _i, _i, _i],
                             [_f, _f, _f, _f, _f, _f, ratio[0], _f, _f, _f, _f, _f,
                              _f, _f, _f, _f, _f, _f, _f, _f, _f, _f, _f, _f],
                             ["", ""])

# endregion

# region [ System Basics ]

# BASE_VOLTAGE = 115000
# CTRL_BUS_NUM = [314691, 314692, 314693, 314694, 314695]
# TRANSFORMER_TAP_RATIO_STEP = 0.007
# TRANSFORMER_BUS_NUM = [314691, 314692]
# GEN_BUS_NUM = [315153, 315154]
# SHUNT_BUS_NUM = [314521, 314519]

BASE_VOLTAGE = 138000
LOAD_BUS_NUM = [33, 34, 36, 39, 40]
TRANSFORMER_TAP_RATIO_STEP = 0.005
TRANSFORMER_BUS_NUM = [37, 38]
GEN_BUS_NUM = [46, 49]
LVC_SHUNT_BUS_NUM = [34, 39]
RVC_SHUNT_BUS_NUM = [34, 44, 45, 48, 74, 105]
ALL_BUS_NUM = range(1,119)

# endregion

if __name__ == '__main__':

    # region [ C# Environment Inputs ]

    MainFolderPath = sys.argv[1]   # C:\Users\niezj\Documents\dom\ShadowSys118\
    CaseFileName = sys.argv[2]     # IEEE_118_Bus.sav
    OutputsFileName = sys.argv[3]  # Outputs.csv
    LoadIncrementPercentage = float(sys.argv[4])  # 21
    StateTxTapV = int(sys.argv[5])      # 0
    StateSn1CapBkrV = int(sys.argv[6])  # 0
    StateSn2CapBkrV = int(sys.argv[7])  # 0
    StateSn1BusBkrV = int(sys.argv[8])  # 0
    StateSn2BusBkrV = int(sys.argv[9])  # 0
    RegionalLoadIncrementPercentage = float(sys.argv[10])   # 21
    StateSnB34CapBkrV = int(sys.argv[11])  # 0
    StateSnB44CapBkrV = int(sys.argv[12])  # 0
    StateSnB45CapBkrV = int(sys.argv[13])  # 0
    StateSnB48CapBkrV = int(sys.argv[14])  # 0
    StateSnB74CapBkrV = int(sys.argv[15])  # 0
    StateSnB105CapBkrV = int(sys.argv[16])  # 0

    # endregion

    # region [ Local Environment Testing ]

    # MainFolderPath = r"""C:\Users\niezj\Documents\dom\ShadowSys118"""
    # CaseFileName = r"""IEEE_118_Bus.sav"""
    # OutputsFileName = r"""Outputs.csv"""
    # LoadIncrementPercentage = float(30)
    # StateTxTapV = int(0)
    # StateSn1CapBkrV = int(0)
    # StateSn2CapBkrV = int(0)
    # StateSn1BusBkrV = int(1)
    # StateSn2BusBkrV = int(1)
    # RegionalLoadIncrementPercentage = float(21)
    # StateSnB34CapBkrV = int(0)
    # StateSnB44CapBkrV = int(0)
    # StateSnB45CapBkrV = int(0)
    # StateSnB48CapBkrV = int(0)
    # StateSnB74CapBkrV = int(0)
    # StateSnB105CapBkrV = int(0)


    # endregion

    # region [ Advanced Environment Setup ]
    LogFolderPath = os.path.join(MainFolderPath, "Log")
    PythonCodeFolderPath = os.path.join(MainFolderPath, "PythonCode")
    OutputsFilePath = os.path.join(LogFolderPath, OutputsFileName)
    CaseFilePath = os.path.join(PythonCodeFolderPath, CaseFileName)
    # endregion

    # region [ PSS/E System Configurations & Calculations ]

    with silence():
        psspy.psseinit(95000)
        psspy.case(CaseFilePath)
        set_transformer_ratio(TRANSFORMER_BUS_NUM, StateTxTapV,
                              TRANSFORMER_TAP_RATIO_STEP)
        set_capbank_breaker_value(LVC_SHUNT_BUS_NUM,
                                  [StateSn1CapBkrV, StateSn2CapBkrV])
        set_capbank_breaker_value(RVC_SHUNT_BUS_NUM,
                                  [StateSnB34CapBkrV, StateSnB44CapBkrV,
                                   StateSnB45CapBkrV, StateSnB48CapBkrV,
                                   StateSnB74CapBkrV, StateSnB105CapBkrV])
        set_load_increment_percentage(LOAD_BUS_NUM, LoadIncrementPercentage)
        set_load_increment_percentage(ALL_BUS_NUM, RegionalLoadIncrementPercentage)
        psspy.fdns()
        N = psspy.solved()

    # endregion

    if N == 0:

        _frame = []        # Get a Measurement frame

        # region [ Retrive LVC Data from PSS/E Calculations ]

        # Get the voltage at Farmville bus
        MeasTxVoltV = get_transformer_voltage(TRANSFORMER_BUS_NUM)

        # Get the voltage at Pamplin and Crewe buses
        shunt_bus_volt = get_shunt_voltage(LVC_SHUNT_BUS_NUM)
        MeasSn1VoltV = shunt_bus_volt[0]
        MeasSn2VoltV = shunt_bus_volt[1]

        # Get branch flow
        transformer_brn_flow = get_branch_flow(TRANSFORMER_BUS_NUM[0],
                                               TRANSFORMER_BUS_NUM[1])
        MeasTxMwV = transformer_brn_flow[0].real
        MeasTxMvrV = transformer_brn_flow[0].imag

        # Get the generator outputs
        Pgen = get_gen_active_power(GEN_BUS_NUM)
        Qgen = get_gen_reactive_power(GEN_BUS_NUM)
        MeasGn1MwV = Pgen[0]
        MeasGn1MvrV = Qgen[0]
        MeasGn2MwV = Pgen[1]
        MeasGn2MvrV = Qgen[1]

        # endregion

        # region [ Retrive RVC Data from PSS/E Calculations ]

        all_bus_volt = get_bus_voltage(ALL_BUS_NUM)

        MeasB1VoltV = all_bus_volt[0]
        MeasB2VoltV = all_bus_volt[1]
        MeasB3VoltV = all_bus_volt[2]
        MeasB4VoltV = all_bus_volt[3]
        MeasB5VoltV = all_bus_volt[4]
        MeasB6VoltV = all_bus_volt[5]
        MeasB7VoltV = all_bus_volt[6]
        MeasB8VoltV = all_bus_volt[7]
        MeasB9VoltV = all_bus_volt[8]
        MeasB10VoltV = all_bus_volt[9]
        MeasB11VoltV = all_bus_volt[10]
        MeasB12VoltV = all_bus_volt[11]
        MeasB13VoltV = all_bus_volt[12]
        MeasB14VoltV = all_bus_volt[13]
        MeasB15VoltV = all_bus_volt[14]
        MeasB16VoltV = all_bus_volt[15]
        MeasB17VoltV = all_bus_volt[16]
        MeasB18VoltV = all_bus_volt[17]
        MeasB19VoltV = all_bus_volt[18]
        MeasB20VoltV = all_bus_volt[19]
        MeasB21VoltV = all_bus_volt[20]
        MeasB22VoltV = all_bus_volt[21]
        MeasB23VoltV = all_bus_volt[22]
        MeasB24VoltV = all_bus_volt[23]
        MeasB25VoltV = all_bus_volt[24]
        MeasB26VoltV = all_bus_volt[25]
        MeasB27VoltV = all_bus_volt[26]
        MeasB28VoltV = all_bus_volt[27]
        MeasB29VoltV = all_bus_volt[28]
        MeasB30VoltV = all_bus_volt[29]
        MeasB31VoltV = all_bus_volt[30]
        MeasB32VoltV = all_bus_volt[31]
        MeasB33VoltV = all_bus_volt[32]
        MeasB34VoltV = all_bus_volt[33]
        MeasB35VoltV = all_bus_volt[34]
        MeasB36VoltV = all_bus_volt[35]
        MeasB37VoltV = all_bus_volt[36]
        MeasB38VoltV = all_bus_volt[37]
        MeasB39VoltV = all_bus_volt[38]
        MeasB40VoltV = all_bus_volt[39]
        MeasB41VoltV = all_bus_volt[40]
        MeasB42VoltV = all_bus_volt[41]
        MeasB43VoltV = all_bus_volt[42]
        MeasB44VoltV = all_bus_volt[43]
        MeasB45VoltV = all_bus_volt[44]
        MeasB46VoltV = all_bus_volt[45]
        MeasB47VoltV = all_bus_volt[46]
        MeasB48VoltV = all_bus_volt[47]
        MeasB49VoltV = all_bus_volt[48]
        MeasB50VoltV = all_bus_volt[49]
        MeasB51VoltV = all_bus_volt[50]
        MeasB52VoltV = all_bus_volt[51]
        MeasB53VoltV = all_bus_volt[52]
        MeasB54VoltV = all_bus_volt[53]
        MeasB55VoltV = all_bus_volt[54]
        MeasB56VoltV = all_bus_volt[55]
        MeasB57VoltV = all_bus_volt[56]
        MeasB58VoltV = all_bus_volt[57]
        MeasB59VoltV = all_bus_volt[58]
        MeasB60VoltV = all_bus_volt[59]
        MeasB61VoltV = all_bus_volt[60]
        MeasB62VoltV = all_bus_volt[61]
        MeasB63VoltV = all_bus_volt[62]
        MeasB64VoltV = all_bus_volt[63]
        MeasB65VoltV = all_bus_volt[64]
        MeasB66VoltV = all_bus_volt[65]
        MeasB67VoltV = all_bus_volt[66]
        MeasB68VoltV = all_bus_volt[67]
        MeasB69VoltV = all_bus_volt[68]
        MeasB70VoltV = all_bus_volt[69]
        MeasB71VoltV = all_bus_volt[70]
        MeasB72VoltV = all_bus_volt[71]
        MeasB73VoltV = all_bus_volt[72]
        MeasB74VoltV = all_bus_volt[73]
        MeasB75VoltV = all_bus_volt[74]
        MeasB76VoltV = all_bus_volt[75]
        MeasB77VoltV = all_bus_volt[76]
        MeasB78VoltV = all_bus_volt[77]
        MeasB79VoltV = all_bus_volt[78]
        MeasB80VoltV = all_bus_volt[79]
        MeasB81VoltV = all_bus_volt[80]
        MeasB82VoltV = all_bus_volt[81]
        MeasB83VoltV = all_bus_volt[82]
        MeasB84VoltV = all_bus_volt[83]
        MeasB85VoltV = all_bus_volt[84]
        MeasB86VoltV = all_bus_volt[85]
        MeasB87VoltV = all_bus_volt[86]
        MeasB88VoltV = all_bus_volt[87]
        MeasB89VoltV = all_bus_volt[88]
        MeasB90VoltV = all_bus_volt[89]
        MeasB91VoltV = all_bus_volt[90]
        MeasB92VoltV = all_bus_volt[91]
        MeasB93VoltV = all_bus_volt[92]
        MeasB94VoltV = all_bus_volt[93]
        MeasB95VoltV = all_bus_volt[94]
        MeasB96VoltV = all_bus_volt[95]
        MeasB97VoltV = all_bus_volt[96]
        MeasB98VoltV = all_bus_volt[97]
        MeasB99VoltV = all_bus_volt[98]
        MeasB100VoltV = all_bus_volt[99]
        MeasB101VoltV = all_bus_volt[100]
        MeasB102VoltV = all_bus_volt[101]
        MeasB103VoltV = all_bus_volt[102]
        MeasB104VoltV = all_bus_volt[103]
        MeasB105VoltV = all_bus_volt[104]
        MeasB106VoltV = all_bus_volt[105]
        MeasB107VoltV = all_bus_volt[106]
        MeasB108VoltV = all_bus_volt[107]
        MeasB109VoltV = all_bus_volt[108]
        MeasB110VoltV = all_bus_volt[109]
        MeasB111VoltV = all_bus_volt[110]
        MeasB112VoltV = all_bus_volt[111]
        MeasB113VoltV = all_bus_volt[112]
        MeasB114VoltV = all_bus_volt[113]
        MeasB115VoltV = all_bus_volt[114]
        MeasB116VoltV = all_bus_volt[115]
        MeasB117VoltV = all_bus_volt[116]
        MeasB118VoltV = all_bus_volt[117]

        # endregion

        # region [ Save Configurations and Calculated Values for LVC ]
        _frame.append(StateTxTapV)      # 0 -> PPA:48
        _frame.append(StateSn1CapBkrV)	# 1 -> PPA:49
        _frame.append(StateSn2CapBkrV)	# 2 -> PPA:50
        _frame.append(StateSn1BusBkrV)	# 3 -> PPA:51
        _frame.append(StateSn2BusBkrV)	# 4 -> PPA:52
        _frame.append(BASE_VOLTAGE * MeasTxVoltV[0]) # 5 -> PPA:53
        _frame.append(BASE_VOLTAGE * MeasSn1VoltV)   # 6 -> PPA:54
        _frame.append(BASE_VOLTAGE * MeasSn2VoltV)   # 7 -> PPA:55
        _frame.append(MeasTxMwV)	 #  8 -> PPA:56
        _frame.append(MeasTxMvrV)	 #  9 -> PPA:57
        _frame.append(MeasGn1MwV)	 # 10 -> PPA:58
        _frame.append(MeasGn1MvrV)	 # 11 -> PPA:59
        _frame.append(MeasGn2MwV)	 # 12 -> PPA:60
        _frame.append(MeasGn2MvrV)	 # 13 -> PPA:61
        # endregion

        # region [ Save Configurations and Calculated Values for RVC ]
        _frame.append(StateSnB34CapBkrV)   # 14 -> PPA:75
        _frame.append(StateSnB44CapBkrV)   # 15 -> PPA:76
        _frame.append(StateSnB45CapBkrV)   # 16 -> PPA:77
        _frame.append(StateSnB48CapBkrV)   # 17 -> PPA:78
        _frame.append(StateSnB74CapBkrV)   # 18 -> PPA:79
        _frame.append(StateSnB105CapBkrV)  # 19 -> PPA:80
        _frame.append(BASE_VOLTAGE * MeasB1VoltV)  # 20 -> PPA:81
        _frame.append(BASE_VOLTAGE * MeasB2VoltV)  # 21 -> PPA:82
        _frame.append(BASE_VOLTAGE * MeasB3VoltV)  # 22 -> PPA:83
        _frame.append(BASE_VOLTAGE * MeasB4VoltV)  # 23 -> PPA:84
        _frame.append(BASE_VOLTAGE * MeasB5VoltV)  # 24 -> PPA:85
        _frame.append(BASE_VOLTAGE * MeasB6VoltV)  # 25 -> PPA:86
        _frame.append(BASE_VOLTAGE * MeasB7VoltV)  # 26 -> PPA:87
        _frame.append(BASE_VOLTAGE * MeasB8VoltV)  # 27 -> PPA:88
        _frame.append(BASE_VOLTAGE * MeasB9VoltV)  # 28 -> PPA:89
        _frame.append(BASE_VOLTAGE * MeasB10VoltV)  # 29 -> PPA:90
        _frame.append(BASE_VOLTAGE * MeasB11VoltV)  # 30 -> PPA:91
        _frame.append(BASE_VOLTAGE * MeasB12VoltV)  # 31 -> PPA:92
        _frame.append(BASE_VOLTAGE * MeasB13VoltV)  # 32 -> PPA:93
        _frame.append(BASE_VOLTAGE * MeasB14VoltV)  # 33 -> PPA:94
        _frame.append(BASE_VOLTAGE * MeasB15VoltV)  # 34 -> PPA:95
        _frame.append(BASE_VOLTAGE * MeasB16VoltV)  # 35 -> PPA:96
        _frame.append(BASE_VOLTAGE * MeasB17VoltV)  # 36 -> PPA:97
        _frame.append(BASE_VOLTAGE * MeasB18VoltV)  # 37 -> PPA:98
        _frame.append(BASE_VOLTAGE * MeasB19VoltV)  # 38 -> PPA:99
        _frame.append(BASE_VOLTAGE * MeasB20VoltV)  # 39 -> PPA:100
        _frame.append(BASE_VOLTAGE * MeasB21VoltV)  # 40 -> PPA:101
        _frame.append(BASE_VOLTAGE * MeasB22VoltV)  # 41 -> PPA:102
        _frame.append(BASE_VOLTAGE * MeasB23VoltV)  # 42 -> PPA:103
        _frame.append(BASE_VOLTAGE * MeasB24VoltV)  # 43 -> PPA:104
        _frame.append(BASE_VOLTAGE * MeasB25VoltV)  # 44 -> PPA:105
        _frame.append(BASE_VOLTAGE * MeasB26VoltV)  # 45 -> PPA:106
        _frame.append(BASE_VOLTAGE * MeasB27VoltV)  # 46 -> PPA:107
        _frame.append(BASE_VOLTAGE * MeasB28VoltV)  # 47 -> PPA:108
        _frame.append(BASE_VOLTAGE * MeasB29VoltV)  # 48 -> PPA:109
        _frame.append(BASE_VOLTAGE * MeasB30VoltV)  # 49 -> PPA:110
        _frame.append(BASE_VOLTAGE * MeasB31VoltV)  # 50 -> PPA:111
        _frame.append(BASE_VOLTAGE * MeasB32VoltV)  # 51 -> PPA:112
        _frame.append(BASE_VOLTAGE * MeasB33VoltV)  # 52 -> PPA:113
        _frame.append(BASE_VOLTAGE * MeasB34VoltV)  # 53 -> PPA:114
        _frame.append(BASE_VOLTAGE * MeasB35VoltV)  # 54 -> PPA:115
        _frame.append(BASE_VOLTAGE * MeasB36VoltV)  # 55 -> PPA:116
        _frame.append(BASE_VOLTAGE * MeasB37VoltV)  # 56 -> PPA:117
        _frame.append(BASE_VOLTAGE * MeasB38VoltV)  # 57 -> PPA:118
        _frame.append(BASE_VOLTAGE * MeasB39VoltV)  # 58 -> PPA:119
        _frame.append(BASE_VOLTAGE * MeasB40VoltV)  # 59 -> PPA:120
        _frame.append(BASE_VOLTAGE * MeasB41VoltV)  # 60 -> PPA:121
        _frame.append(BASE_VOLTAGE * MeasB42VoltV)  # 61 -> PPA:122
        _frame.append(BASE_VOLTAGE * MeasB43VoltV)  # 62 -> PPA:123
        _frame.append(BASE_VOLTAGE * MeasB44VoltV)  # 63 -> PPA:124
        _frame.append(BASE_VOLTAGE * MeasB45VoltV)  # 64 -> PPA:125
        _frame.append(BASE_VOLTAGE * MeasB46VoltV)  # 65 -> PPA:126
        _frame.append(BASE_VOLTAGE * MeasB47VoltV)  # 66 -> PPA:127
        _frame.append(BASE_VOLTAGE * MeasB48VoltV)  # 67 -> PPA:128
        _frame.append(BASE_VOLTAGE * MeasB49VoltV)  # 68 -> PPA:129
        _frame.append(BASE_VOLTAGE * MeasB50VoltV)  # 69 -> PPA:130
        _frame.append(BASE_VOLTAGE * MeasB51VoltV)  # 70 -> PPA:131
        _frame.append(BASE_VOLTAGE * MeasB52VoltV)  # 71 -> PPA:132
        _frame.append(BASE_VOLTAGE * MeasB53VoltV)  # 72 -> PPA:133
        _frame.append(BASE_VOLTAGE * MeasB54VoltV)  # 73 -> PPA:134
        _frame.append(BASE_VOLTAGE * MeasB55VoltV)  # 74 -> PPA:135
        _frame.append(BASE_VOLTAGE * MeasB56VoltV)  # 75 -> PPA:136
        _frame.append(BASE_VOLTAGE * MeasB57VoltV)  # 76 -> PPA:137
        _frame.append(BASE_VOLTAGE * MeasB58VoltV)  # 77 -> PPA:138
        _frame.append(BASE_VOLTAGE * MeasB59VoltV)  # 78 -> PPA:139
        _frame.append(BASE_VOLTAGE * MeasB60VoltV)  # 79 -> PPA:140
        _frame.append(BASE_VOLTAGE * MeasB61VoltV)  # 80 -> PPA:141
        _frame.append(BASE_VOLTAGE * MeasB62VoltV)  # 81 -> PPA:142
        _frame.append(BASE_VOLTAGE * MeasB63VoltV)  # 82 -> PPA:143
        _frame.append(BASE_VOLTAGE * MeasB64VoltV)  # 83 -> PPA:144
        _frame.append(BASE_VOLTAGE * MeasB65VoltV)  # 84 -> PPA:145
        _frame.append(BASE_VOLTAGE * MeasB66VoltV)  # 85 -> PPA:146
        _frame.append(BASE_VOLTAGE * MeasB67VoltV)  # 86 -> PPA:147
        _frame.append(BASE_VOLTAGE * MeasB68VoltV)  # 87 -> PPA:148
        _frame.append(BASE_VOLTAGE * MeasB69VoltV)  # 88 -> PPA:149
        _frame.append(BASE_VOLTAGE * MeasB70VoltV)  # 89 -> PPA:150
        _frame.append(BASE_VOLTAGE * MeasB71VoltV)  # 90 -> PPA:151
        _frame.append(BASE_VOLTAGE * MeasB72VoltV)  # 91 -> PPA:152
        _frame.append(BASE_VOLTAGE * MeasB73VoltV)  # 92 -> PPA:153
        _frame.append(BASE_VOLTAGE * MeasB74VoltV)  # 93 -> PPA:154
        _frame.append(BASE_VOLTAGE * MeasB75VoltV)  # 94 -> PPA:155
        _frame.append(BASE_VOLTAGE * MeasB76VoltV)  # 95 -> PPA:156
        _frame.append(BASE_VOLTAGE * MeasB77VoltV)  # 96 -> PPA:157
        _frame.append(BASE_VOLTAGE * MeasB78VoltV)  # 97 -> PPA:158
        _frame.append(BASE_VOLTAGE * MeasB79VoltV)  # 98 -> PPA:159
        _frame.append(BASE_VOLTAGE * MeasB80VoltV)  # 99 -> PPA:160
        _frame.append(BASE_VOLTAGE * MeasB81VoltV)  # 100 -> PPA:161
        _frame.append(BASE_VOLTAGE * MeasB82VoltV)  # 101 -> PPA:162
        _frame.append(BASE_VOLTAGE * MeasB83VoltV)  # 102 -> PPA:163
        _frame.append(BASE_VOLTAGE * MeasB84VoltV)  # 103 -> PPA:164
        _frame.append(BASE_VOLTAGE * MeasB85VoltV)  # 104 -> PPA:165
        _frame.append(BASE_VOLTAGE * MeasB86VoltV)  # 105 -> PPA:166
        _frame.append(BASE_VOLTAGE * MeasB87VoltV)  # 106 -> PPA:167
        _frame.append(BASE_VOLTAGE * MeasB88VoltV)  # 107 -> PPA:168
        _frame.append(BASE_VOLTAGE * MeasB89VoltV)  # 108 -> PPA:169
        _frame.append(BASE_VOLTAGE * MeasB90VoltV)  # 109 -> PPA:170
        _frame.append(BASE_VOLTAGE * MeasB91VoltV)  # 110 -> PPA:171
        _frame.append(BASE_VOLTAGE * MeasB92VoltV)  # 111 -> PPA:172
        _frame.append(BASE_VOLTAGE * MeasB93VoltV)  # 112 -> PPA:173
        _frame.append(BASE_VOLTAGE * MeasB94VoltV)  # 113 -> PPA:174
        _frame.append(BASE_VOLTAGE * MeasB95VoltV)  # 114 -> PPA:175
        _frame.append(BASE_VOLTAGE * MeasB96VoltV)  # 115 -> PPA:176
        _frame.append(BASE_VOLTAGE * MeasB97VoltV)  # 116 -> PPA:177
        _frame.append(BASE_VOLTAGE * MeasB98VoltV)  # 117 -> PPA:178
        _frame.append(BASE_VOLTAGE * MeasB99VoltV)  # 118 -> PPA:179
        _frame.append(BASE_VOLTAGE * MeasB100VoltV)  # 119 -> PPA:180
        _frame.append(BASE_VOLTAGE * MeasB101VoltV)  # 120 -> PPA:181
        _frame.append(BASE_VOLTAGE * MeasB102VoltV)  # 121 -> PPA:182
        _frame.append(BASE_VOLTAGE * MeasB103VoltV)  # 122 -> PPA:183
        _frame.append(BASE_VOLTAGE * MeasB104VoltV)  # 123 -> PPA:184
        _frame.append(BASE_VOLTAGE * MeasB105VoltV)  # 124 -> PPA:185
        _frame.append(BASE_VOLTAGE * MeasB106VoltV)  # 125 -> PPA:186
        _frame.append(BASE_VOLTAGE * MeasB107VoltV)  # 126 -> PPA:187
        _frame.append(BASE_VOLTAGE * MeasB108VoltV)  # 127 -> PPA:188
        _frame.append(BASE_VOLTAGE * MeasB109VoltV)  # 128 -> PPA:189
        _frame.append(BASE_VOLTAGE * MeasB110VoltV)  # 129 -> PPA:190
        _frame.append(BASE_VOLTAGE * MeasB111VoltV)  # 130 -> PPA:191
        _frame.append(BASE_VOLTAGE * MeasB112VoltV)  # 131 -> PPA:192
        _frame.append(BASE_VOLTAGE * MeasB113VoltV)  # 132 -> PPA:193
        _frame.append(BASE_VOLTAGE * MeasB114VoltV)  # 133 -> PPA:194
        _frame.append(BASE_VOLTAGE * MeasB115VoltV)  # 134 -> PPA:195
        _frame.append(BASE_VOLTAGE * MeasB116VoltV)  # 135 -> PPA:196
        _frame.append(BASE_VOLTAGE * MeasB117VoltV)  # 136 -> PPA:197
        _frame.append(BASE_VOLTAGE * MeasB118VoltV)  # 137 -> PPA:198

        # endregion

        # region [ Create a new line in Output.csv file ]
        outputs_csvfile = open(OutputsFilePath, 'a')
        wcsv = csv.writer(outputs_csvfile, delimiter=',', lineterminator='\n')
        wcsv.writerow(_frame)
        outputs_csvfile.close()
        # endregion

        # region [ Return argument back to CSharp ]
        return_argv = '\n'.join(map(str,_frame))
        print(return_argv)
        # endregion

    else:
        print("*** System collapsed, power flow solution not found. ***")
