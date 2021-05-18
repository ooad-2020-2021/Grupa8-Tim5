using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public class Let : Prevoz
    {
        public Let() {}

        #region Atributi
        protected string BrojLeta { get; set; }
        protected bool WiFi { get; set; }
        protected int Legroom { get; set; }
        protected int ŠirinaSjedišta { get; set; }
        protected int MaxPrtljag { get; set; }

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
