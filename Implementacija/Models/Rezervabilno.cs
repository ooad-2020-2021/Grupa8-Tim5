using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TuristickiMarketplace.Models
{
    public abstract class Rezervabilno
    {
        [DataType(DataType.Text)]
        protected String Ime { get; set; }

        [DataType(DataType.MultilineText)]
        protected String Poruka { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        [DisplayName("Početak putovanja")]
        protected DateTime Pocetak { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        [DisplayName("Kraj putovanja")]
        protected DateTime Kraj { get; set; }

        [DataType(DataType.ImageUrl)]
        protected String[] Slike { get; set; }

        [DataType(DataType.Currency)]
        protected double Cijena { get; set; }

        protected bool Aktivna { get; set; }

        public virtual double UkupnaCijenaSPopustom(int p)
        {
            return (1 - p / 100.0) * Cijena;
        }

        public bool IsAktivna()
        {
            return Aktivna;
        }

        public virtual double UkupnaCijena()
        {
            return Cijena;
        }

        public virtual void SetCijenaSPopustom(int p)
        {
            Cijena = UkupnaCijenaSPopustom(p);
        }

        public virtual bool IsZadnjiDan()
        {
            if (Kraj.Subtract(DateTime.Now).TotalDays < 1)
                return true;
            else return false;
        }
    }
}
