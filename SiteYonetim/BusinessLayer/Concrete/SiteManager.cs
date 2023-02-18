using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SiteManager : ISiteService
    {
        ISiteDal _siteDal;

        public SiteManager(ISiteDal siteDal)
        {
            _siteDal = siteDal;
        }

        public Site GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Site> GetList()
        {
            return _siteDal.GetListAll();

        }
        public List<Site> GetSiteByID(int id)
        {
            return _siteDal.GetListAll(x => x.SiteID == id);
        }

        public List<Site> GetSiteListByBilgi(int id)
        {
            return _siteDal.GetListAll(x => x.ID == id);
        }

       

        public List<Site> GetSiteWithCategory()
        {
            return _siteDal.GetListWithCategory();
        }

        public void SiteAdd(Site site)
        {
            throw new NotImplementedException();
        }

        public void SiteDelete(Site site)
        {
            throw new NotImplementedException();
        }

        public void SiteUpdate(Site site)
        {
            throw new NotImplementedException();
        }
    }
}
