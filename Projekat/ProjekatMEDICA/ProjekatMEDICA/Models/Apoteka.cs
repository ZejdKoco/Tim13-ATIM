using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public class Apoteka
    {
        public string _naziv { get; set; }
        public ObservableCollection<Proizvod> Proizvodi { get => proizvodi; set => proizvodi = value; }
        public ObservableCollection<Uposlenik> Uposlenici { get => uposlenici; set => uposlenici = value; }
        public ObservableCollection<Kupac> Kupci { get => kupci; set => kupci = value; }

        private ObservableCollection<Proizvod> proizvodi;
        private ObservableCollection<Uposlenik> uposlenici;
        private ObservableCollection<Kupac> kupci;
        Apoteka(string naziv)
        {
            this._naziv = naziv;
            this.proizvodi = new ObservableCollection<Proizvod>();
            this.kupci = new ObservableCollection<Kupac>();
            this.uposlenici = new ObservableCollection<Uposlenik>();
        }
    }
}
