using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Daire
    {
        [Key]
        public int DaireID { get; set; }
        public string BlokNUMARA { get; set; }

        public string DaireNUMARA { get; set; }
        public string DaireKAT { get; set; }
        public string DaireALAN { get; set; }
        public string DaireACIKLAMA { get; set; }
        public string DaireImage { get; set; }

        public int SiteID { get; set; }
        public Site Site { get; set; }
       
        public List<KiraciMalSahibi> KiraciMalSahibis { get; set; }
        public List<Aidat> Aidats { get; set; }
        public List<Bilgi> Bilgis { get; set; }

    }
}
