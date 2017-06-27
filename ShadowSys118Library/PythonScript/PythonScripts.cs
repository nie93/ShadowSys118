using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;


namespace ShadowSys118.PythonScript
{
    public class PythonScripts
    {
        public List<string> RunPythonCmd(string cmd, string mainfolderpath, string casename, string outfilename, double scal, int txtapv, int sn1capbkrv, int sn2capbkrv, int sn1busbkrv, int sn2busbkrv)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Python27\pythonw.exe";
            start.Arguments = $"{cmd} {mainfolderpath} {casename} {outfilename} ";
            start.Arguments += $"{scal} {txtapv} {sn1capbkrv} {sn2capbkrv} {sn1busbkrv} {sn2busbkrv} ";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    var list = new List<string>();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                    return list;
                }
            }
        }        
    }
}
