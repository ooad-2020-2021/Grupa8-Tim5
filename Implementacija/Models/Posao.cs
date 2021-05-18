using System;
using System.Collections.Generic;
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
        protected string BankovniRačun { get; set; }
        protected string Ime { get; set; }
        protected DateTime VrijemeRegistracije { get; set; }
        protected List<IRezervabilno> Proizvodi { get; set; }
        protected bool Odobren { get; set; }
        protected double StanjeRacuna { get; set; }
        protected double Ocjena { get; set; }
        #endregion

        #region Metode
        public virtual int getStarost()
        {
            return (int)(DateTime.Now - VrijemeRegistracije).TotalDays;
        }

        public virtual List<IRezervabilno> getAktivnePonude()
        {
            return Proizvodi.Where(x => x.isAktivno()).ToList();
        }

        public virtual List<IRezervabilno> getPonudePredIstek()
        {
            return Proizvodi.Where(x => x.isZadnjiDan()).ToList();
        }

        #endregion
    }
}
