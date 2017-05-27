using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public class StavkaNarudzbe
    {
        DateTime datum;
        ObservableCollection<Proizvod> proizvodi;
        double ukupnaCijena;

        public DateTime Datum { get => datum; set => datum = value; }
        public ObservableCollection<Proizvod> Proizvodi { get => proizvodi; set => proizvodi = value; }
        public double UkupnaCijena { get => ukupnaCijena; set => ukupnaCijena = value; }

        public StavkaNarudzbe(DateTime dat, ObservableCollection<Proizvod> proizv, double cijena)
        {
            datum = dat;
            proizvodi = proizv;
            ukupnaCijena = cijena;
        }
    }
}
