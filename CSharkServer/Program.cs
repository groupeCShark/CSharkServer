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
            Console.WriteLine("Press any Key to exit...");
            Console.ReadKey();

            host.Close();
        }
    }
}
