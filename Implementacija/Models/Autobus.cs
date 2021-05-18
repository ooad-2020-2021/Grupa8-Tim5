using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public class Autobus : Prevoz
    {
        #region Konstruktor

        public Autobus() {}

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

        #region Metode
        #endregion
    }
}
