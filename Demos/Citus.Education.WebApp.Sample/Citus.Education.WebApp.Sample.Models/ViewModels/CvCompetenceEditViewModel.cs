using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Citus.Education.WebApp.Sample.Models.ViewModels.App_LocalResources;

namespace Citus.Education.WebApp.Sample.Models.ViewModels
{
    public class CvCompetenceEditViewModel
    {
        public CvCompetenceEditViewModel()
        {
            Groups = new List<CvCompetenceGroupModel>();
            Rates = new List<CvCompetenceRateModel>();
            IsNew = true;
        }
        public int? Id { get; set; }

        [Display(Name="Oznaka")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Obavezno polje Oznaka")]
        [StringLength(3)]
        public string Code { get; set; }
        //[Required(ErrorMessage="Obavezno polje")]
        [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(ErrorMessages))]
        public string Name { get; set; }
        [DemoValidator]
        public string Description { get; set; }
        public int GroupId { get; set; }
        public int RateId { get; set; }
        public int PersonId { get; set; }
        public List<CvCompetenceGroupModel> Groups { get; set; }
        public List<CvCompetenceRateModel> Rates { get; set; }

        public bool IsNew { get; set; }

        public string Message { get; set; }
    }
}
