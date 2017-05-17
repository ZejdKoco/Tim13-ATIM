using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public class StavkaNarudzbe
    {
        DateTime datum;
        ICollection<Proizvod> proizvodi;
        double ukupnaCijena;

        public DateTime Datum { get => datum; set => datum = value; }
        public ICollection<Proizvod> Proizvodi { get => proizvodi; set => proizvodi = value; }
        public double UkupnaCijena { get => ukupnaCijena; set => ukupnaCijena = value; }
    }
}
