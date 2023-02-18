using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public  interface ISiteService
    {
        void SiteAdd(Site site);
        void SiteDelete(Site site);
        void SiteUpdate(Site site);
        List<Site> GetList();
        Site GetById(int id);
        List<Site> GetSiteWithCategory();
        List<Site> GetSiteListByBilgi(int id);

        

    }
}
