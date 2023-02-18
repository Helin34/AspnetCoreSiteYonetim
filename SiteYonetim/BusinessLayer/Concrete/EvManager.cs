
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
   public  class EvManager:IEvService
    {
        IEvDal _evdal;

        public EvManager(IEvDal evdal)
        {
            _evdal = evdal;
        }

        public void AddEv(Ev ev)
        {
            _evdal.Insert(ev);

        }
    }
}
