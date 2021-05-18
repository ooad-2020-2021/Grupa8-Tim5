using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public class Ponuda : BasicRezervabilno
    {
        #region Atributi

        private List<IRezervabilno> Sadržaj { get; set; }
        private bool Spremna { get; set; }

        #endregion

        #region Konstruktor

        public Ponuda()
        {
            Sadržaj = new List<IRezervabilno>();
            Spremna = false;
        }

        #endregion

        #region Metode

        public override void setCijenaSPopustom(int p)
        {
            foreach (IRezervabilno q in Sadržaj) q.setCijenaSPopustom(p);
        }

        public override double UkupnaCijena()
        {
            double total = 0;
            foreach (IRezervabilno q in Sadržaj) total += q.UkupnaCijena();
            return total;
        }

        public override double UkupnaCijenaSPopustom(int p)
        {
            double total = 0;
            foreach (IRezervabilno q in Sadržaj) total += q.UkupnaCijenaSPopustom(p);
            return total;
        }

        public override void Dodaj(IRezervabilno dio)
        {
            Sadržaj.Add(dio);
        }

        public override void Obrisi(IRezervabilno dio)
        {
            Sadržaj.Remove(dio);
        }

        #endregion
    }
}
