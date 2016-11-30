using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharkServer
{
    static class Parser
    {
        static public void parse(string input, CSharkServiceImpl csharkService)
        {
            input = input.ToLower();
            int commandEndIndex = input.IndexOf(' ');
            string command = String.Empty;
            string commandArg = String.Empty;
            int args = 0;
            if (commandEndIndex>-1)
            {
                command = input.Substring(0, commandEndIndex);
                commandArg = input.Substring(commandEndIndex + 1, input.Length - commandEndIndex - 1); //CommandArg est un string, il faut le convertir en int
                bool parsed = Int32.TryParse(commandArg, out args);

                if (!parsed)
                    Console.WriteLine("'{0}' could not be parsed to an int.\n", commandArg);
            }
            else
            {
                command = input;
            }
            switch (command)
            {
                case "exit":
                    {
                        try
                        {
                            Environment.Exit(0);
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Failed exit. Sorry.");
                            Console.WriteLine(e.ToString());
                            Console.WriteLine();
                            break;                      
                        }
                    }
                case "help":
                    {
                        Console.WriteLine("------------------------Command List------------------------");
                        Console.WriteLine("exit : exits the app, closes the server");
                        Console.WriteLine("help : displays a list of commands");
                        Console.WriteLine("logs X : displays the X last log line");
                        Console.WriteLine("userlist : displays a list of users");
                        Console.WriteLine();
                        break;
                    }
                case "logs":
                    try
                    {
                        LogManager.ReadLogMessage(args); //TODO: convertir commandArg en int
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        break;
                    }
                case "userlist":
                    {
                        try
                        {
                            if (csharkService.LoggedUsers.Length>0)
                            {
                                foreach (var user in csharkService.LoggedUsers)
                                {
                                    Console.WriteLine(user.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("No user logged in");
                            }
                            Console.WriteLine();
                            
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                            break;
                        }
                    }
                default:
                    {
                        Console.WriteLine("Command unknown. Enter help for a list of commands");
                        Console.WriteLine();
                        break;
                    }
            }
        }
    }
}
