using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MoviesWS.ServiceSOAP
{
    public class UsernameValidator: UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (null == userName || null == password)
            {
                throw new FaultException("Niste poslali podatke");
            }

            //logika za test sa zadnim username/password parom
            if (!(userName == "user1" && password == "123456"))
            {
                // vrati grešku konzumnetu
                throw new FaultException("Nije dobar username ili password");
            }
        }
    }
}
