using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharkServer
{
    public static class LogManager
    {
        public static bool WriteLogMessage(string Message)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "log/logs.txt", true))
            {
                file.WriteLine("<" + DateTime.Now.ToString() + "> " + Message);
            }
            return true;
        }
        public static bool ReadLogMessage(int index)
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory + "log/logs.txt", true))
            {
                for (int i = 1; i <= index; i++)
                {
                    
                    Console.WriteLine(file.ReadLine());
                }
            }
                return true;
        }
    }
}