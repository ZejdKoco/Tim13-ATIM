using ProjekatMEDICA.Helper;
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
        public ICommand izadji { get; set; }
        public ObservableCollection<OnlineKupac> kupcii { get; set; }
        public OnlineKupac odabraniKupac { get; set; }
        INavigationService navigationService;

        public UnosKorisnikaViewModel()
        {
            navigationService = new NavigationService();
            odobri = new RelayCommand<object>(odobrifja, mozeSeOdobriti);
            izadji = new RelayCommand<object>(izadjif);
            kupcii = new ObservableCollection<OnlineKupac>();
            foreach (OnlineKupac k in DefaultPodaci._nepotvrdjeniKupci) kupcii.Add(k);
            if (kupcii.Count>0) odabraniKupac = kupcii[0];
        }

        public void izadjif(object o)
        {
            navigationService.Navigate(typeof(FormOdabirUloge));
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
