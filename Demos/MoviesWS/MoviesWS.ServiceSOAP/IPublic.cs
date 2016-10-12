using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MoviesWS.ServiceSOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPublic
    {
        [OperationContract]
        string GetMovieName(int Id, string Search);
        [OperationContract]
        Movie GetMovie2(int Id, string Search);
        [OperationContract]
        bool OrderMovie(Movie Id);
    }

   
}
