using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Site
    {
        [Key]
        public int SiteID { get; set; }
        public string SiteAD { get; set; }
        public string SiteIL { get; set; }
        public string SiteADRES { get; set; }
        public string SiteISITUR { get; set; }
        public string SiteImage { get; set; }
        public string SiteAciklama { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int ID { get; set; }
        public Bilgi Bilgi { get; set; }

       


        public List<Daire> Daires { get; set; }


    }
}
