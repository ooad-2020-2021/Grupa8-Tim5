using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public interface IRezervabilno
    {
        abstract double UkupnaCijena();
        abstract double UkupnaCijenaSPopustom(int p);
        abstract void setCijenaSPopustom(int p);
        abstract bool isZadnjiDan();
        abstract bool isAktivno();
        abstract DateTime getDoKadTraje();

        abstract void Dodaj(IRezervabilno dio);
        abstract void Obrisi(IRezervabilno dio);
    }
}
