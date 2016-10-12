using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace MoviesWS.Contracts
{
    [ServiceContract]
    public interface IPublicService
    {
        [OperationContract]
        Movie GetMovie(int Id);
    }
}
