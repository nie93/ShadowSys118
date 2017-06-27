import os, csv

def clear_log_xml_files(dir):
    listdir = os.listdir(dir)
    for item in listdir:
        if (item.startswith('Log_SysConfigFrame_') & item.endswith('.xml')):
            os.remove(os.path.join(dir, item))

def clear_only_data_in_outputs_file(filepath):
    f = open(filepath, 'rb')
    rcsv = csv.reader(f, delimiter=',', lineterminator='\n')
    header = rcsv.next()
    f.close()

    with open(filepath, 'wb') as csvfile:
        wcsv = csv.writer(csvfile, delimiter=',', lineterminator='\n')
        wcsv.writerow(header)

if __name__ == '__main__':
    dirPath = os.path.dirname(os.path.realpath(__file__))
    clear_log_xml_files(dirPath)
    clear_only_data_in_outputs_file(os.path.join(dirPath, 'Outputs.csv'))


