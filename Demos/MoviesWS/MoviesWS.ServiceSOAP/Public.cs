using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MoviesWS.ServiceSOAP
{

    public class Public : IPublic
    {
        public Movie GetMovie(int Id)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovie(int Id, string Search)
        {
            Movie movie = new Movie { Id = 1, Name = "Ništa", Year = 2016 };

            return movie;
        }

        public string GetMovieName(int Id)
        {
            return "Rambo 3";
        }

        public string GetMovieName(int Id, string Search)
        {
            throw new NotImplementedException();
        }

        public bool SaveMovie(Movie Id)
        {
            //TODO: spremi u bazu
            return true;
        }
    }
}
