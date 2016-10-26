using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using KaFotka.Helpers;


namespace KaFotka.DAL
{
	public class AspNetRolesActions
	{
				/// <summary>
		        /// Dohvati iz baze sa opcijama za paging
		        /// </summary>
		        /// <param name="pagecount">koliko na stranici</param>
		        /// <param name="pageindex">koja stranica po redu</param>
		        /// <returns></returns>
				public List<AspNetRoles> GetAll(int pagecount, int pageindex)
		        {
		            List<AspNetRoles> lista = null;
		
		            using (Entities data = new Entities())
		            {
		                var items = data.AspNetRoles.Where(r => r.Deleted == false).OrderBy(r => r.Id).Skip(pagecount * (pageindex-1)).Take(pagecount);
		                lista = items.ToList();
		            }
		
		            return lista;
		        }
		
				/// <summary>
		        /// dohvati jedan po primary key-u
		        /// </summary>
		        /// <param name="guid"></param>
		        /// <returns></returns>
		        public AspNetRoles Get(int Id) {
		            AspNetRoles item = null;
		
		            using (Entities data = new Entities())
		            {
		                item = data.AspNetRoles.Where(r => r.Id == Id).FirstOrDefault();
		            }
		
		            return item;
		        }
		
				 /// <summary>
		        /// spremi item
		        /// insert ako nema Id
		        /// update ako ima Id
		        /// </summary>
		        /// <param name="item">instanca entity objekta</param>
		        /// <returns></returns>
		        public bool Save(AspNetRoles item)
		        {
		            bool uspjelo = false;
		
		            using (Entities  data = new Entities ())
		            {
		                data.AspNetRoles.Add(item);
		                //ako ima Id onda je update
		                if (item.Id != null)
		                {
		                    data.Entry<AspNetRoles>(item).State = System.Data.EntityState.Modified;
		                }
		
		                data.SaveChanges();
		
		                uspjelo = true;
		            }
		
		            return uspjelo;
		        }
		
				/// <summary>
		        /// obriši item
		        /// nije brisanje već postavljanje Deleted polja na true
		        /// </summary>
		        /// <param name="item">instanca entity objekta</param>
		        /// <returns></returns>
		        public bool Delete(AspNetRoles item)
		        {
		            bool uspjelo = false;
		
		            using (KaFotkaEntities data = new KaFotkaEntities())
		            {
		                item.Deleted = true;
						data.Entry<AspNetRoles>(item).State = System.Data.EntityState.Modified;
		                data.SaveChanges();
		
		                uspjelo = true;
		            }
		
		            return uspjelo;
		        }
		
				}
}
