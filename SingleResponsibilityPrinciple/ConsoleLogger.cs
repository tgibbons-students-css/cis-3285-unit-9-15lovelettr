using System;
using System.IO;

using SingleResponsibilityPrinciple.Contracts;

namespace SingleResponsibilityPrinciple
{
    public class ConsoleLogger : ILogger
    {
        public void LogWarning(string message, params object[] args)
        {
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine("<log><type>WARN</type><message>" + message + "</message></log> ", args);
            }
            Console.WriteLine(string.Concat("WARN: ", message), args);
        }

        public void LogInfo(string message, params object[] args)
        {
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine("<log><type>INFO</type><message>" + message + "</message></log> ", args);
            }
            Console.WriteLine(string.Concat("INFO: ", message), args);
        }
    }
}
