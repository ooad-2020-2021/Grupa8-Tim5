using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public abstract class Smještaj : Rezervabilno
    {
        [DataType(DataType.Text)]
        protected string Adresa { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Kratki opis: ")]
        protected string KratkiOpis { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Broj telefona: ")]
        protected string BrTelefona { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Detaljan opis: ")]
        protected string DetaljniOpis { get; set; }

        [DataType(DataType.MultilineText)]
        protected List<string> Pogodnosti { get; set; }

        [Display(Name = "Za broj osoba: ")]
        protected int BrojOsoba { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Kućni red: ")]
        protected List<string> KućniRed { get; set; }
    }
}
