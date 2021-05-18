using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public class Rezervacija
    {
        #region Ctori
        public Rezervacija() { }
        #endregion

        #region Atributi
        private Korisnik Registrovao { get; set; }
        private IRezervabilno Putovanje { get; set; }
        private DateTime DatumRezervacije { get; set; }
        private DateTime RokZaBesplatnoOtkazivanjen { get; set; }
        private double PenalOtkazivanja { get; set; }
        private bool RezervacijaZaTreceLice { get; set; }
        private List<string> DodatniZahtjevi { get; set; }
        #endregion

        #region Metode
        public void rezervisi()
        {
            // ovdje treba simulirati placanje, no te klase nisu implementirane

            Registrovao.RezervisanePonude.Add(Putovanje);
        }
        public void otkazi()
        {
            // rollback transakcije placanja, s eventualno obracunatim penalima

            Registrovao.RezervisanePonude.Remove(Putovanje);
        }

        public void Dodaj(IRezervabilno dio)
        {
            Putovanje.Dodaj(dio);
        }

        public void Obrisi(IRezervabilno dio)
        {
            Putovanje.Obrisi(dio);
        }
        #endregion
    }
}
