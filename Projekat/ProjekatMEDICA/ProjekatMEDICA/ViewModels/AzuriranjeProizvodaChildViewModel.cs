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
    class AzuriranjeProizvodaChildViewModel : INotifyPropertyChanged
    {
        Proizvod proizvod;
        string naziv;
        string id;
        string opis;
        string proizvodjac;
        byte[] slika;
        double cijena;
        string komentar;
        int kolicina;
        ICommand spremiBtn;
        AzuriranjeProizvodaParentViewModel parent;
        private INavigationService navigationService;
        public string Naziv { get => naziv; set => naziv = value; }
        public string Id { get => id; set => id = value; }
        public string Opis { get => opis; set => opis = value; }
        public string Proizvodjac { get => proizvodjac; set => proizvodjac = value; }
        public byte[] Slika { get => slika; set => slika = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public INavigationService NavigationService { get => navigationService; set => navigationService = value; }
        public string Komentar { get => komentar; set => komentar = value; }
        public ICommand SpremiBtn { get => spremiBtn; set => spremiBtn = value; }
        public Proizvod Proizvod { get => proizvod; set => proizvod = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        internal AzuriranjeProizvodaParentViewModel Parent { get => parent; set => parent = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public AzuriranjeProizvodaChildViewModel()
        {
            navigationService = new NavigationService();
            SpremiBtn = new RelayCommand<object>(spremiIzmjene, moze);
        }

        private bool moze(object arg)
        {
            return true;
        }

        public AzuriranjeProizvodaChildViewModel(AzuriranjeProizvodaParentViewModel parent)
        {
            this.Parent = parent;
            navigationService = new NavigationService();
            proizvod = parent.odabrani;
            SpremiBtn = new RelayCommand<object>(spremiIzmjene, moze);
            naziv = proizvod.Naziv;
            id = proizvod.Id;
            opis = proizvod.Opis;
            proizvodjac = proizvod.Proizvodjac;
            komentar = proizvod.Komentar;
            slika = proizvod.Slika;
            cijena = proizvod.Cijena;
            kolicina = proizvod.Kolicina;
        }
        public async void spremiIzmjene(object parametar)
        {
            var dialog1 = new MessageDialog("Jos nista");
            await dialog1.ShowAsync();
        }
    }
}
