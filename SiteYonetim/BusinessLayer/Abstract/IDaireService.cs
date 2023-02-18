using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public   interface IDaireService
    {
        void DaireAdd(Daire daire);
       // void DaireDelete(Daire daire);
        //void DaireUpdate(Daire daire);
        List<Daire> GetList(int id);
       //Daire GetById(int id);
    }
}
