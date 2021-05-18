using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public class Pretraga
    {
        #region Ctori
        public Pretraga() { }
        #endregion

        #region Atributi
        private string Query { get; set; }
        private List<IRezervabilno> Rezultati { get; set; }
        #endregion

        #region Metode
        public List<IRezervabilno> Filtriraj(Func<IRezervabilno, Boolean> f)
        {
            return Rezultati.Where(x => f.Invoke(x)).ToList();
        }

        public List<IRezervabilno> Sortiraj(Sort p)
        {
            switch(p)
            {
                case Sort.CIJENA_ASC:
                    Rezultati.Sort((x1, x2) => x1.UkupnaCijena().CompareTo(x2.UkupnaCijena()));
                    return Rezultati;
                case Sort.CIJENA_DESC:
                    Rezultati.Sort((x1, x2) => x2.UkupnaCijena().CompareTo(x1.UkupnaCijena()));
                    return Rezultati;
                case Sort.ISTEK_ASC:
                    Rezultati.Sort((x1, x2) => x1.getDoKadTraje().CompareTo(x2.getDoKadTraje()));
                    return Rezultati;
                case Sort.ISTEK_DESC:
                    Rezultati.Sort((x1, x2) => x2.getDoKadTraje().CompareTo(x1.getDoKadTraje()));
                    return Rezultati;
                default:
                    return Rezultati;
            }
        }
        #endregion
    }
}
