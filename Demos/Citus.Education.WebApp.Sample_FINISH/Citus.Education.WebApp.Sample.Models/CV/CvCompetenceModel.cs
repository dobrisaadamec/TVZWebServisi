using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citus.Education.WebApp.Sample.Models
{
    public class CvCompetenceModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GroupId { get; set; }
        public int RateId { get; set; }
        public int PersonId { get; set; }
    }
}
