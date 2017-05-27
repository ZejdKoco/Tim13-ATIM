using ProjekatMEDICA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatMEDICA.ViewModels
{
    class UnosKorisnikaViewModel
    {
        public ICommand odobri { get; set; }
        public ObservableCollection<Kupac> kupcii { get; set; }
        public Kupac odabraniKupac { get; set; }

        public UnosKorisnikaViewModel()
        {
            odobri = new RelayCommand<object>(odobrifja, mozeSeOdobriti);
            kupcii = new ObservableCollection<Kupac>();
            foreach (OnlineKupac k in DefaultPodaci._nepotvrdjeniKupci) kupcii.Add(k);
            odabraniKupac = kupcii[0];
        }

        public bool mozeSeOdobriti(Object o)
        {
            return true;
        }

        public void odobrifja(Object o)
        {
            // ovdje treba tog korisnika dodat na spisak registrovanih korisnika...
        }

    }
}
