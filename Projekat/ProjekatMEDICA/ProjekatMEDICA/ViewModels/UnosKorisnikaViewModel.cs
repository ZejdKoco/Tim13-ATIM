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
        ObservableCollection<Kupac> zahtjeviKupaca { get; set; }
        ICommand odobri;

        public UnosKorisnikaViewModel()
        {
            odobri = new RelayCommand<object>(odobrifja, mozeSeOdobriti);

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
