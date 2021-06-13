using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    abstract public class Prevoz : Rezervabilno
    {
        #region Atributi

        [DataType(DataType.Text)]
        protected string Ishodište { get; set; }

        [DataType(DataType.Text)]
        protected string Odredište { get; set; }

        [DataType(DataType.Text)]
        protected string Prevoznik { get; set; }

        [DataType(DataType.Duration)]
        [Display(Name = "Trajanje (min): ")]
        protected int TrajanjeUMinutama { get; set; }

        protected bool Dvosmjeran { get; set; }

        #endregion
    }
}
