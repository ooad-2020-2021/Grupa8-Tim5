using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public class Hotel : Smještaj
    {
        #region Atributi

        protected List<string> ObjektiHotela { get; set; }
        protected string TipSobe { get; set; }

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
