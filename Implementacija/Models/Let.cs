using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public class Let : Prevoz
    {
        [DataType(DataType.Text)]
        [Display(Name = "Broj leta: ")]
        protected string BrojLeta { get; set; }

        [Display(Name = "WiFi dostupan?")]
        protected bool WiFi { get; set; }

        [Display(Name = "Legroom dužina (cm): ")]
        protected int LegroomCM { get; set; }

        [Display(Name = "Širina sjedišta (cm): ")]
        protected int ŠirinaSjedištaCM { get; set; }

        [Display(Name = "Max dozvoljeni carry-on prtljag (kg): ")]
        protected int MaxPrtljagKG { get; set; }
    }
}
