using System;
using System.ServiceModel;

namespace CSharkServer
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharkServiceImpl csharkService = new CSharkServiceImpl();
            ServiceHost host = new ServiceHost(csharkService);

            host.Open();

            Console.WriteLine("Server CShark is running...");
            Console.WriteLine("Enter a command - enter help for command list");
            while (true)
            {
                Parser.parse(Console.ReadLine(),csharkService);
            }
            //host.Close();
        }
    }
}
