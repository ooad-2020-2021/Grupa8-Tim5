using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public class Ponuda : Rezervabilno
    {
        private List<Rezervabilno> Content { get; set; }

        public override double UkupnaCijena()
        {
            double sum = 0;
            Content.ForEach(r => sum += r.UkupnaCijena());
            return sum;
        }

        public override double UkupnaCijenaSPopustom(int p)
        {
            double sum = 0;
            Content.ForEach(r => sum += r.UkupnaCijenaSPopustom(p));
            return sum;
        }

        public override void SetCijenaSPopustom(int p)
        {
            Content.ForEach(r => r.SetCijenaSPopustom(p));
        }
    }
}
