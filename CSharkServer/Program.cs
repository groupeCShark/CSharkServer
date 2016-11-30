using System;
using System.ServiceModel;

namespace CSharkServer
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager.CheckLogDirectory(); //vérifier l'éxistence du dossier log et le créer si inexistant

            CSharkServiceImpl csharkService = new CSharkServiceImpl();
            ServiceHost host = new ServiceHost(csharkService);
            try
            {
                host.Open(); //démarrage du service
            }

            catch (Exception e)
            {
                Console.WriteLine("Failed to launch server: {0}", e.ToString());
            }

            Console.WriteLine("Server CShark is running...");
            Console.WriteLine("Enter a command - enter help for command list");
            while (true)
            {
                Parser.parse(Console.ReadLine(),csharkService);
            }
            //host.Close(); // commenté car la fermeture est gérée par la commande exit
        }
    }
}
