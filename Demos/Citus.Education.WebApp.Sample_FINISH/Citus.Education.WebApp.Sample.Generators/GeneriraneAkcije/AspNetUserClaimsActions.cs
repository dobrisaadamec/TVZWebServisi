using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using KaFotka.Helpers;


namespace KaFotka.DAL
{
	public class AspNetUserClaimsActions
	{
				/// <summary>
		        /// Dohvati iz baze sa opcijama za paging
		        /// </summary>
		        /// <param name="pagecount">koliko na stranici</param>
		        /// <param name="pageindex">koja stranica po redu</param>
		        /// <returns></returns>
				public List<AspNetUserClaims> GetAll(int pagecount, int pageindex)
		        {
		            List<AspNetUserClaims> lista = null;
		
		            using (Entities data = new Entities())
		            {
		                var items = data.AspNetUserClaims.Where(r => r.Deleted == false).OrderBy(r => r.Id).Skip(pagecount * (pageindex-1)).Take(pagecount);
		                lista = items.ToList();
		            }
		
		            return lista;
		        }
		
				/// <summary>
		        /// dohvati jedan po primary key-u
		        /// </summary>
		        /// <param name="guid"></param>
		        /// <returns></returns>
		        public AspNetUserClaims Get(int Id) {
		            AspNetUserClaims item = null;
		
		            using (Entities data = new Entities())
		            {
		                item = data.AspNetUserClaims.Where(r => r.Id == Id).FirstOrDefault();
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
		        public bool Save(AspNetUserClaims item)
		        {
		            bool uspjelo = false;
		
		            using (Entities  data = new Entities ())
		            {
		                data.AspNetUserClaims.Add(item);
		                //ako ima Id onda je update
		                if (item.Id != null)
		                {
		                    data.Entry<AspNetUserClaims>(item).State = System.Data.EntityState.Modified;
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
		        public bool Delete(AspNetUserClaims item)
		        {
		            bool uspjelo = false;
		
		            using (KaFotkaEntities data = new KaFotkaEntities())
		            {
		                item.Deleted = true;
						data.Entry<AspNetUserClaims>(item).State = System.Data.EntityState.Modified;
		                data.SaveChanges();
		
		                uspjelo = true;
		            }
		
		            return uspjelo;
		        }
		
				}
}
