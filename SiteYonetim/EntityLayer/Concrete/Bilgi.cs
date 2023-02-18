using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Bilgi
    {
        [Key]
        public int ID { get; set; }
        public string YoneticiName{ get; set; }
        public string YoneticiMail { get; set; }
        public string  EvSahibiName { get; set; }
        public string EvSahibiMail { get; set; }
        public string KiraciName { get; set; }
        public string KiraciMail { get; set; }
        public string  YoneticiPassword { get; set; }
        public string KiraciPassword { get; set; }
        public string EvSahibiPassword { get; set; }

        public List<Site> Sites { get; set; }
       

        public Daire Daire { get; set; }
        public Aidat Aidat { get; set; }
        public Gider Gider { get; set; }
        public KiraciMalSahibi KiraciMalSahibi { get; set; }



    }
}
