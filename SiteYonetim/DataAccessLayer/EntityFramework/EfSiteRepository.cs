using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfSiteRepository : GenericRepository<Site>, ISiteDal
    {
        public List<Site> GetListWithCategory()
        {
           using (var c=new Context())
            {
                return c.Sites.Include(x => x.Category).ToList();

            }
        }
    }
}
