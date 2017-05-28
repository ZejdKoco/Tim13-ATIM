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
    class NarucivanjeProizvodaViewModel
    {
        OnlineKupac kupac;
        INavigationService navigationService;
        public ICommand kupi { get; set; }
        public string imePrezime { get; set; }
        public ICommand odjava { get; set; }
        public ICommand dostavaDa { get; set; }
        public ICommand dostavaNe { get; set; }
        public bool dostava { get; set; }
        public string pretraga { get; set; }
        public ObservableCollection<Proizvod> proizvodii { get; set; } //koji ce se dodavati u listView
        public Proizvod odabrani;
        public NarucivanjeProizvodaViewModel()
        {
            navigationService = new NavigationService();
            odjava = new RelayCommand<object>(odjaviSe);
            kupi = new RelayCommand<object>(kupiProizvod, jeLiMoguceKupiti);
            proizvodii = new ObservableCollection<Proizvod>();
            foreach (Proizvod p in DefaultPodaci._proizvodi) proizvodii.Add(p);
            dostavaDa = new RelayCommand<Object>(dostavaFda);
            dostavaNe = new RelayCommand<Object>(dostavaFne);
            odabrani = proizvodii[0];
        }

        public void dostavaFda(Object o)
        {
            dostava = true;
        }

        public void dostavaFne(Object o)
        {
            dostava = false;
        }

        public NarucivanjeProizvodaViewModel(PrijavaKupcaViewModel prijavaKupcaViewModel) //treba kod prijave
        {
            kupac = (OnlineKupac)prijavaKupcaViewModel.Kupac;
            navigationService = new NavigationService();
            odjava = new RelayCommand<object>(odjaviSe);
            kupi = new RelayCommand<object>(kupiProizvod, jeLiMoguceKupiti);
            proizvodii = new ObservableCollection<Proizvod>();
            foreach (Proizvod p in DefaultPodaci._proizvodi) proizvodii.Add(p);
            odabrani = proizvodii[0];
            imePrezime = kupac.Ime + " " + kupac.Prezime;

            dostavaDa = new RelayCommand<Object>(dostavaFda);
            dostavaNe = new RelayCommand<Object>(dostavaFne);
        }

        public void odjaviSe(Object o)
        {
            navigationService.Navigate(typeof(FormOdabirUloge));
        }

  

        public bool jeLiMoguceKupiti(Object o)
        {
            return true;
        }

        

        public async void kupiProizvod(Object o)
        {
            if (odabrani == null)
            {
                var dialog1 = new MessageDialog("Niste odabrali proizvod");
                await dialog1.ShowAsync();
            }
            else
            {
                DefaultPodaci._proizvodi.Remove(odabrani);
                ObservableCollection<Proizvod> pro = new ObservableCollection<Proizvod>();
                pro.Add(odabrani);
                kupac.KupljeniProizvodi.Add(new StavkaNarudzbe(DateTime.Now, pro , odabrani.Cijena));
                proizvodii.Remove(odabrani);
                if (!dostava)
                {
                    var dialog1 = new MessageDialog("Uspjesno ste kupili proizvod.");
                    await dialog1.ShowAsync();
                }
                else
                {
                    DefaultPodaci._proizvodiZaDostaviti.Add(odabrani);
                    var dialog1 = new MessageDialog("Proizvod ce biti dostavljen na vasu adresu.");
                    await dialog1.ShowAsync();
                }
            }
        }
    }
}
