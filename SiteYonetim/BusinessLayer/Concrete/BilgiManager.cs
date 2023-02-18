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
    public class BilgiManager : IBilgiService
    {
        IBilgiDal _bilgidal;

        public BilgiManager(IBilgiDal bilgidal)
        {
            _bilgidal = bilgidal;
        }

        public void BilgiAdd(Bilgi bilgi)
        {
            _bilgidal.Insert(bilgi);
        }
    }
}
