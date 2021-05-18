using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public class Apartman : Smještaj
    {
        #region Atributi

        protected string PozdravnaPoruka { get; set; }
        protected string Domaćin { get; set; }

        // OVO ISPOD NE VALJA !!!
        public override void Dodaj(IRezervabilno dio)
        {
            throw new NotImplementedException();
        }

        public override void Obrisi(IRezervabilno dio)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
