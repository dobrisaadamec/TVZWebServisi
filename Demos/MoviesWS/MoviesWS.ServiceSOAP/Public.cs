using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace MoviesWS.ServiceSOAP
{

    public class Public : IPublic
    {
        public Movie GetMovie2(int Id, string Search)
        {
            //throw new FaultException(new FaultReason("neka greška"));
            Thread.Sleep(100);
            return new Movie { Id = 1, Name = "Ništa", Year = 2016 };

            

            //return movie;
        }

        public string GetMovieName(int Id, string Search)
        {
            return "Rambo 3";
        }

        public bool OrderMovie(Movie Id)
        {
            //TODO: spremi u bazu
            return true;
        }
    }

}
