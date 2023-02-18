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
    public class DaireManager : IDaireService
    {
        IDaireDal _daireDal;

        public DaireManager(IDaireDal daireDal)
        {
            _daireDal = daireDal;
        }

        public void DaireAdd(Daire daire)
        {
            _daireDal.Insert(daire);
        }

        public List<Daire> GetList(int id)
        {
            return _daireDal.GetListAll(x => x.SiteID == id);
        }
    }
}
