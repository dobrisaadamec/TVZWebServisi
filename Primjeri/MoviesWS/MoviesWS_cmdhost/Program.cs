using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MoviesWS_cmdhost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MoviesWS.SOAPService.PublicService), new Uri("http://127.0.0.1:8989/Movies")))
            {
                host.AddServiceEndpoint(typeof(MoviesWS.Contracts.IPublicService), new BasicHttpBinding(), "Public");
                host.Open();

                Console.WriteLine("Servis pokrenut. ENTER za zaustavljanje servisa!");
                Console.ReadLine();

            }
        }
    }
}
