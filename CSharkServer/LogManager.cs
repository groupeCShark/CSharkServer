using System;
using System.IO;
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
                
                List<string> logList =  new List<string>();
                string line = file.ReadLine();
                while (line!=null)
                {
                    logList.Add(line);
                    line =file.ReadLine();
                }
                int lastLog = logList.Count;
                Console.WriteLine(lastLog);
                for (int i = Math.Min(index,lastLog); i >= 1; i--)
                {
                    Console.WriteLine(logList[lastLog - i]);
                }
            }
                return true;
        }
        public static void CheckLogDirectory()
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "log";
                if(Directory.Exists(path))
                { return; }
                else
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("log directory successfully created at {0}.", Directory.GetCreationTime(path));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("failed to check log directory existence: {0}", e.ToString());
            }
        }
    }
}