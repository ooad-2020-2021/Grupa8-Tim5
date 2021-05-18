using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    abstract public class Prevoz : BasicRezervabilno
    {
        #region Atributi

        protected string Ishodište { get; set; }
        protected string Odredište { get; set; }
        protected string Prevoznik { get; set; }
        protected int TrajanjeUMinutama { get; set; }
        protected bool Dvosmjeran { get; set; }

        #endregion
    }
}
