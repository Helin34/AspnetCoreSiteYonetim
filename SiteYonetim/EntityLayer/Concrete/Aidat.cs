using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Aidat
    {
        [Key]
        public int AidatID { get; set; }
        public string AidatAYLAR { get; set; }

        public int DaireID { get; set; }
        public Daire Daire { get; set; }
        public List<Bilgi> Bilgis { get; set; }
    }
}
