using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioay.WindowsService.Sample
{
    public static class Library
    {
        public static void WriteErrorLog(string message)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + " : " + message.Trim());
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }
    }
}
