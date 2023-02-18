using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class KiraciMalSahibi
    {
        [Key]
        public int KiraciID { get; set; }
       
        public int SahibID { get; set; }
        public string KiraciADSOYAD { get; set; }

        public string SahibADSOYAD { get; set; }
        public string KiraciTelefon { get; set; }
        public string SahipTelefon { get; set; }
        public string SahibMail { get; set; }
        public string KiraciMail { get; set; }
        public int DaireID { get; set; }
        public Daire Daire { get; set; }
        public List<Bilgi> Bilgis { get; set; }

    }
}
