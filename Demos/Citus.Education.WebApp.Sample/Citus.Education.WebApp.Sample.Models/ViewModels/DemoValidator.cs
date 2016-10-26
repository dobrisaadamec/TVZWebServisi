using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citus.Education.WebApp.Sample.Models.ViewModels
{
    public class DemoValidator: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            //TODO: završiti!!!!!
            return true;
        }

    }
}
