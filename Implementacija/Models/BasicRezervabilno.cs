using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public abstract class BasicRezervabilno : IRezervabilno
    {
        #region Atributi
        
        [Key]
        [Required]
        protected String Ime { get; set; }

        [Required]
        protected DateTime[] VremenskiOkvir { get; set; }
        protected String Poruka { get; set; }

        // kako sliku pohraniti u C# ??

        protected DateTime TrajeDo { get; set; }
        protected double Cijena { get; set; }
        protected double Ocjena { get; set; }
        protected List<String> Utisci { get; set; }
        protected List<String> DodatnePogodnosti { get; set; }
        protected bool Aktivno { get; set; }

        #endregion

        #region Metode

        virtual public Double UkupnaCijena()
        {
            return Cijena;
        }
        virtual public Double UkupnaCijenaSPopustom(int p)
        {
            double faktor = (double) p / 100;
            return Cijena * (1 - faktor);
        }
        virtual public void setCijenaSPopustom(int p)
        {
            double faktor = (double) p / 100;
            Cijena = Cijena * (1 - faktor);
        }
        virtual public bool isZadnjiDan()
        {
            if (TrajeDo.Subtract(DateTime.Now).TotalDays < 1) return true;
            return false;
        }

        public bool isAktivno()
        {
            return Aktivno;
        }

        public DateTime getDoKadTraje()
        {
            return TrajeDo;
        }

        public abstract void Dodaj(IRezervabilno dio);
        public abstract void Obrisi(IRezervabilno dio);

        #endregion
    }
}
