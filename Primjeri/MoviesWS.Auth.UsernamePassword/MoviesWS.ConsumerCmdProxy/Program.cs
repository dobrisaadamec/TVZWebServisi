using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MoviesWS.ConsumerCmdProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            WSMoviesPublic.PublicServiceClient proxy = new WSMoviesPublic.PublicServiceClient();

            proxy.ClientCredentials.UserName.UserName = "user1";
            proxy.ClientCredentials.UserName.Password = "123456";
            try
            {
                var result = proxy.GetMovie(2);
                Console.WriteLine(result.Name);
            } catch (Exception fe)
            {
                Console.WriteLine(fe.InnerException.Message);
            }


            Task.Run(async () =>
            {
                // Do any async anything you need here without worry
                var res = await proxy.GetMovieAsync(3);
                Console.WriteLine(res.Name);

            }).Wait();

            Console.ReadLine();
        }
    }
}
