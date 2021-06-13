using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{ 
    public abstract class Posao
    {
        #region Atributi
        protected bool LegalnoRegistrovan { get; set; }
        protected bool PorezniObveznik { get; set; }
        protected bool Osiguran { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Broj telefona: ")]
        protected String BrTelefona { get; set; }

        [DataType(DataType.ImageUrl)]
        protected string Slika { get; set; }

        [DataType(DataType.CreditCard)]
        [Display(Name = "Broj bankovnog računa: ")]
        protected string BankovniRačun { get; set; }

        [DataType(DataType.Text)]
        protected string Ime { get; set; }

        [DataType(DataType.DateTime)]
        protected DateTime VrijemeRegistracije { get; set; }

        protected List<Rezervabilno> Proizvodi { get; set; }
        protected bool Odobren { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Stanje računa: ")]
        protected double StanjeRacuna { get; set; }

        protected double Ocjena { get; set; }
        #endregion

        #region Metode
        public virtual int getStarost()
        {
            return (int)(DateTime.Now - VrijemeRegistracije).TotalDays;
        }

        public virtual List<Rezervabilno> getAktivnePonude()
        {
            return Proizvodi.Where(x => x.IsAktivna()).ToList();
        }

        public virtual List<Rezervabilno> getPonudePredIstek()
        {
            return Proizvodi.Where(x => x.IsZadnjiDan()).ToList();
        }

        #endregion
    }
}
