using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MoviesWS.HostCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MoviesWS.ServiceSOAP.Public), new Uri("http://127.0.0.1:8989/Movies")))
            {
                host.AddServiceEndpoint(typeof(MoviesWS.ServiceSOAP.IPublic), new BasicHttpBinding(), "Public");

                host.Open();

                Console.WriteLine("Evo se vrtim na http://127.0.0.1:8989/Movies");
                Console.ReadLine();
            }
        }
    } 
}
