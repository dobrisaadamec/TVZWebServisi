using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MoviesWS.ConsumerProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            WSMovies.PublicClient proxy = new WSMovies.PublicClient();

            proxy.ClientCredentials.UserName.UserName = "user1";
            proxy.ClientCredentials.UserName.Password = "123456";
            try
            {
                var result = proxy.GetMovie2(2,"");

                Console.WriteLine("Ime filma:" + result.Name);
            } catch (FaultException fe) {
                Console.WriteLine(fe.Reason);
            }

            Task.Run(async () => {
                var res = await proxy.GetMovie2Async(2,"");
                Console.WriteLine("Godina:" + res.Year);
            });

            Console.WriteLine("Zadnja linija");


           Console.ReadKey();
        }
    }
}
