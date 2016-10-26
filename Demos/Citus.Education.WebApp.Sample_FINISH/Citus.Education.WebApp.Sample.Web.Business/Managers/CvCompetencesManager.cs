using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Citus.Education.WebApp.Sample.Common.Exstensions;
using Citus.Education.WebApp.Sample.Models;
using Citus.Education.WebApp.Sample.Models.Shared;
using Citus.Education.WebApp.Sample.DataAccess;
using Citus.Education.WebApp.Sample.Models.ViewModels;
using Citus.Education.WebApp.Sample.Common;
using Citus.Education.WebApp.Sample.Models.DataTables;
using System.Linq.Dynamic;

namespace Citus.Education.WebApp.Sample.Business.Managers
{
    public class CvCompetencesManager
    {
        public static DBActionResult Save(CvCompetenceModel model)
        {
            LogHelper.LogError("Test pisanja greške u CvCompetencesManager.Save");

            DBActionResult result = new DBActionResult();
            try
            {
                using (Entities db = new Entities())
                {
                    CvCompetence entity = model.TranslateTo<CvCompetence>();
                    db.CvCompetences.Add(entity);

                    if (entity.Id != 0)
                    {
                        //attach entity and save
                        db.Entry<CvCompetence>(entity).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();

                    result.ActionSucceed = true;
                    result.EntityId = entity.Id;
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex);
            }

            return result;
        }

        public static CvCompetenceEditViewModel GetCvCompetence(int? competenceId)
        {

            CvCompetenceEditViewModel model = new CvCompetenceEditViewModel();

            using (var db = new Entities())
            {
                //edit postojećeg inače je novi
                if (competenceId.HasValue)
                {
                    model.IsNew = false;
                    var competence = db.CvCompetences.FirstOrDefault(x => x.Id == competenceId);

                    if (competence != null)
                    {
                        model = competence.TranslateTo<CvCompetenceEditViewModel>();
                    }
                }
                //groups
                var groups = db.CvCompetencesGroups.Where(x => x.Active == true);
                foreach (var group in groups)
                {
                    CvCompetenceGroupModel g = group.TranslateTo<CvCompetenceGroupModel>();
                    model.Groups.Add(g);
                }
                //rates
                var rates = db.CvCompetencesRates.Where(x => x.Active == true);
                foreach (var rate in rates)
                {
                    CvCompetenceRateModel r = rate.TranslateTo<CvCompetenceRateModel>();
                    model.Rates.Add(r);
                }
            }

            return model;
        }

        public static List<CvCompetenceModel> GetCvCompetenceAll()
        {

            List<CvCompetenceModel> items = new List<CvCompetenceModel>();

            using (var db = new Entities())
            {
                var entityItems = db.CvCompetences.ToList();
                foreach (var item in entityItems)
                {
                    items.Add(item.TranslateTo<CvCompetenceModel>());
                }
            }

            return items;
        }

        public static DataTablesResponseModel<DataTableCvCompetenceModel> GetCvCompetenceDataTable(int pageSize, int position, string search, int sortColumnId, string sortDirection)
        {
            List<DataTableCvCompetenceModel> items = new List<DataTableCvCompetenceModel>();

            // Set the total count
            // so GridView knows how many pages to create
            int totalCount = 0;


            using (var db = new Entities())
            {

                totalCount = db.CvCompetences.Count();

                var query = db.CvCompetences.Where(x => x.Id != null);
                if (search != String.Empty)
                {
                    query = query.Where(x => x.Name.Contains(search) || x.Description.Contains(search));
                }

                string sortColumn = "Code";

                switch (sortColumnId)
                {
                    case 1:
                        sortColumn = "Name";
                        break;
                    case 2:
                        sortColumn = "Description";
                        break;
                    default:

                        break;
                }

                string direction = (sortDirection == "DESC") ? "DESC" : "ASC";
                // Apply sorting:
                //dynamic from System.Linq.Dynamic in Common Exstensions
                query = query.OrderBy(sortColumn + " " + sortDirection);
               
                //paging
                query = query.Skip(position).Take(pageSize);

                int actionCounter = 1;
                foreach (var item in query.ToList())
                {
                    items.Add(new DataTableCvCompetenceModel
                    {
                        Code = item.Code,
                        Name = item.Name,
                        Description = item.Description,
                        //Action = "/Admin/CvCompetenceEdit/" + item.Id.ToString()
                        Action = item.Id.ToString()
                    });
                    actionCounter++;
                }
            }


            DataTablesResponseModel<DataTableCvCompetenceModel> model = new DataTablesResponseModel<DataTableCvCompetenceModel>(items, totalCount, totalCount, 0);

            return model;
        }
    }
}
