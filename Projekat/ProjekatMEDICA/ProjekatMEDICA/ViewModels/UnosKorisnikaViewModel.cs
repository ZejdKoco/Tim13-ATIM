using ProjekatMEDICA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

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
            if (kupcii.Count>0) odabraniKupac = kupcii[0];
        }

        public bool mozeSeOdobriti(Object o)
        {
            return true;
        }

        public async void odobrifja(Object o)
        {
            foreach (OnlineKupac k in DefaultPodaci._nepotvrdjeniKupci)
            {
                if (k == odabraniKupac)
                {
                    DefaultPodaci._nepotvrdjeniKupci.Remove(k);
                    break;
                }
            }

            foreach(OnlineKupac k in kupcii)
            {
                if (k==odabraniKupac)
                {
                    kupcii.Remove(k);
                    break;
                }
            }
            DefaultPodaci._kupci.Add(odabraniKupac);


            var dialog = new MessageDialog("Korisnik uspjesno dodan");
            await dialog.ShowAsync();

        }

    }
}
