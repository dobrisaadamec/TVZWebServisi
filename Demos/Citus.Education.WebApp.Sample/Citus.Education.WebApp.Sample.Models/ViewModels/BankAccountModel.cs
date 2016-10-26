using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Citus.Education.WebApp.Sample.Models.ViewModels
{
    public class BankAccountModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Obavezno polje")]
        [StringLength(5)]
        [Display(Name = "Naziv/Ime")]
        public string Name { get; set; }

        [Editable(false)]
        public string Code { get; set; }
        public string IBAN { get; set; }
        public string Status { get; set; }
    }
}