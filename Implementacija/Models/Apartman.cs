using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public class Apartman : Smještaj
    {
        [DataType(DataType.Text)]
        [Display(Name = "Pozdravna poruka: ")]
        protected string PozdravnaPoruka { get; set; }

        protected Posao Domaćin { get; set; }
    }
}
