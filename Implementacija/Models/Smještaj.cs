using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public abstract class Smještaj : BasicRezervabilno
    {
        #region Atributi

        protected string Adresa { get; set; }
        protected string KratkiOpis { get; set; }
        protected string DetaljniOpis { get; set; }
        protected List<string> Pogodnosti { get; set; }
        protected int BrojOsoba { get; set; }
        protected List<string> KućniRed { get; set; }

        #endregion
    }
}
