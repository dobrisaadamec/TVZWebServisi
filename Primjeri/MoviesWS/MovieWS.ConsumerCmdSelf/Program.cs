using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MoviesWS.Contracts;

namespace MovieWS.ConsumerCmdSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            EndpointAddress ep = new EndpointAddress("http://127.0.0.1:8989/Movies/Public");
            IPublicService proxy = ChannelFactory<IPublicService>.CreateChannel(new BasicHttpBinding(), ep);

            Console.WriteLine("Film Id:");
            int Id = Convert.ToInt32(Console.ReadLine());
            try
            {
                Movie Rezultat = proxy.GetMovie(Id);
                Console.WriteLine(Rezultat.Name);
            }
            catch (FaultException f)
            {
                Console.WriteLine(f.Reason);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }

   

   
}
