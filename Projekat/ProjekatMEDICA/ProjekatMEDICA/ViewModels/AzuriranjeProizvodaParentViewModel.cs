using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Windows.UI.Popups;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using ProjekatMEDICA.Models;
using System.Collections.ObjectModel;
using ProjekatMEDICA.Helper;

namespace ProjekatMEDICA.ViewModels
{
    class AzuriranjeProizvodaParentViewModel : INotifyPropertyChanged
    {
        private string naziv;
        public ICommand pretragaBtn { get; set; }
        public ObservableCollection<Proizvod> proizvodi { get; set; }
        public ICommand potvrdiBtn { get; set; }
        public Proizvod odabrani { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public INavigationService NavigationService { get; set; }
        public string Naziv
        {
            get => naziv;
            set
            {
                naziv = value;
                if(naziv == "")
                {
                    proizvodi.Clear();
                    Proizvodi();
                }
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void pozivAzuriranjeProizvodaParent()
        {
            NavigationService.Navigate(typeof(AzurirajProizvodParent));
        }
        public AzuriranjeProizvodaParentViewModel()
        {
            NavigationService = new NavigationService();
            potvrdiBtn = new RelayCommand<object>(potvrdiZapocniAzuriranje, mozeLiSeAzurirati);
            pretragaBtn = new RelayCommand<object>(pretragaProizvoda, moze);
            proizvodi = new ObservableCollection<Proizvod>();
            Proizvodi();
        }

        private bool moze(object arg)
        {
            return true;
        }

        private void pretragaProizvoda(object obj)
        {
            Proizvod p = (Proizvod)DefaultPodaci.nadjiProizvod(Naziv);
            if (p != null)
            {
                proizvodi.Clear();
                proizvodi.Add(p);
            }  

            // NavigationService.Navigate(typeof(AzuriranjeProizvodaChild), new AzuriranjeProizvodaChildViewModel(this));
        }

        public bool mozeLiSeAzurirati(object parametar)
        {
            return true;
        }
        public async void potvrdiZapocniAzuriranje(object parametar)
        {
            if (odabrani == null)
            {
                var dialog1 = new MessageDialog("Niste odabrali proizvod");
                await dialog1.ShowAsync();
            }
            else
            {

                NavigationService.Navigate(typeof(AzuriranjeProizvodaChild), new AzuriranjeProizvodaChildViewModel(this));
            }
        }
        public void Proizvodi()
        {
            foreach (Proizvod p in DefaultPodaci._proizvodi)
            {
                proizvodi.Add(new Proizvod(p.Naziv, p.Id, p.Proizvodjac, p.Opis, p.Cijena, p.Kolicina, p.Komentar));
            }
        }
    }
}
