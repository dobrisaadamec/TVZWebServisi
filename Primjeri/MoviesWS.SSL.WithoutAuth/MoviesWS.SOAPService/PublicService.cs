using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MoviesWS.Contracts;

namespace MoviesWS.SOAPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class PublicService : IPublicService
    {
        public Movie GetMovie(int Id)
        {
            Movie movie = new Movie();
            movie.Name = "Rambo 3";
            movie.Year = 1985;

            //throw new FaultException(new FaultReason("namjerna greška"));

            return movie;
        }

    }
}
