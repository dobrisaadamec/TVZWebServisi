using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesWS.ConsumerCmdProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            WSMoviesPublic.PublicServiceClient proxy = new WSMoviesPublic.PublicServiceClient();
            var result = proxy.GetMovie(2);

            Console.WriteLine(result.Name);
            Console.ReadLine();
        }
    }
}
