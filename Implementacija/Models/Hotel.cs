using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public class Hotel : Smještaj
    {
        [DataType(DataType.MultilineText)]
        [Display(Name = "Objekti hotela: ")]
        protected List<string> ObjektiHotela { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Tip sobe: ")]
        protected string TipSobe { get; set; }

    }
}
