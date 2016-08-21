using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Logger
    {
        private static Logger log = new Logger();
        private Logger()
        {

        }
        public void LogInfo(string message)
        {
            string path = @"C:\Users\BURCAK\Documents\Visual Studio 2015\Projects\DesignPatterns\DesignPatterns\sistem.log";

            StreamWriter sw;
            using (sw = File.AppendText(path))
            {
                sw.WriteLine(message);
                sw.Close();
            }
        }

        public static Logger getInstance()
        {
            return log;
        }
    }
}