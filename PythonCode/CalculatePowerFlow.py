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


def get_transformer_voltage(bus_num):
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
    psspy.bsys(0, 0, [0.2, 999.], 0, [], 5, bus_num, 0, [], 0, [])
    ierr, load_bus = psspy.alodbusint(sid=0, flag=1, string=['NUMBER'])
    load_bus = load_bus[0]
    return load_bus


def get_transformer_ratio(bus_num):
    psspy.bsys(sid=1, numbus=2, buses=bus_num)
    ierr, ratio = psspy.atrnreal(sid=1, owner=2, ties=1, flag=2, entry=1,
                                 string=['RATIO2'])
    return ratio[0]


def set_capbank_breaker_value(bus_num, breaker_status):
    # Configure capacitor bank breaker value (Switching ON/OFF)
    for i in range(0, len(bus_num)):
        if breaker_status[i] == 0:
            psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 0])
        elif breaker_status[i] == 1:
            # Capacity value of capacitor bank is given by PSS/E
            if bus_num[i] == 34:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 24.38])
            elif bus_num[i] == 39:
                psspy.shunt_data(bus_num[i], r"""1""", 1, [_f, 24.38])



def get_shunt_voltage(bus_num):
    psspy.bsys(sid=1, numbus=1, buses=bus_num[0])
    ierr, shunt_Pamplin_voltage = psspy.abusreal(1, 1, ['PU'])
    shunt_Pamplin_voltage = shunt_Pamplin_voltage[0][0]

    psspy.bsys(sid=1, numbus=1, buses=bus_num[1])
    ierr, shunt_Crewe_voltage = psspy.abusreal(1, 1, ['PU'])
    shunt_Crewe_voltage = shunt_Crewe_voltage[0][0]

    shunt_bus_voltage = [shunt_Pamplin_voltage, shunt_Crewe_voltage]
    return shunt_bus_voltage


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
TRANSFORMER_TAP_RATIO_STEP = 0.007
TRANSFORMER_BUS_NUM = [37, 38]
GEN_BUS_NUM = [46, 49]
SHUNT_BUS_NUM = [34, 39]

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
        set_capbank_breaker_value(SHUNT_BUS_NUM,
                                  [StateSn1CapBkrV, StateSn2CapBkrV])
        set_load_increment_percentage(LOAD_BUS_NUM, LoadIncrementPercentage)
        psspy.fdns()
        N = psspy.solved()

    # endregion

    if N == 0:

        # region [ Retrive Data from PSS/E Calculations ]

        # Get the voltage at Farmville bus
        MeasTxVoltV = get_transformer_voltage(TRANSFORMER_BUS_NUM)

        # Get the voltage at Pamplin and Crewe buses
        shunt_bus_volt = get_shunt_voltage(SHUNT_BUS_NUM)
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

        # region [ Create new line in Output.csv file ]
        # Get a Measurement frame
        _frame = []

        # Save Configuration Values
        _frame.append(StateTxTapV)      #0 -> PPA:48
        _frame.append(StateSn1CapBkrV)	#1 -> PPA:49
        _frame.append(StateSn2CapBkrV)	#2 -> PPA:50
        _frame.append(StateSn1BusBkrV)	#3 -> PPA:51
        _frame.append(StateSn2BusBkrV)	#4 -> PPA:52

        # Save Calculated Values
        _frame.append(BASE_VOLTAGE * MeasTxVoltV[0]) #5 -> PPA:53
        _frame.append(BASE_VOLTAGE * MeasSn1VoltV)   #6 -> PPA:54
        _frame.append(BASE_VOLTAGE * MeasSn2VoltV)   #7 -> PPA:55
        _frame.append(MeasTxMwV)	#8 -> PPA:56
        _frame.append(MeasTxMvrV)	#9 -> PPA:57
        _frame.append(MeasGn1MwV)	#10 -> PPA:58
        _frame.append(MeasGn1MvrV)	#11 -> PPA:59
        _frame.append(MeasGn2MwV)	#10 -> PPA:60
        _frame.append(MeasGn2MvrV)	#11 -> PPA:61

        # Save measurement values to Outputs.csv
        outputs_csvfile = open(OutputsFilePath, 'a')
        wcsv = csv.writer(outputs_csvfile, delimiter=',', lineterminator='\n')
        wcsv.writerow(_frame)
        outputs_csvfile.close()
        # endregion

    else:
        print("*** System collapsed, power flow solution not found. ***")
