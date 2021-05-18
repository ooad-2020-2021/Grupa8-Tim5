using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public abstract class Korisnik
    {
        #region Atributi
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Grad { get; set; }
        public string[] Telefon { get; set; }
        public string[] Email { get; set; }
        // niz slika??
        public List<IRezervabilno> RezervisanePonude { get; set; }
        #endregion
    }
}
