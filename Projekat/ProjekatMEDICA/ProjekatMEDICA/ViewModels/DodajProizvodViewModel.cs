using ProjekatMEDICA.Helper;
using ProjekatMEDICA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace ProjekatMEDICA.ViewModels
{
    class DodajProizvodViewModel: INotifyPropertyChanged
    {
        Proizvod proizvod;
        string naziv;
        string id;
        string opis;
        string proizvodjac;
        double cijena;
        string komentar;
        int kolicina;
        ICommand dodajBtn;
        ICommand dodajBarCodeBtn;
        private INavigationService navigationService;
        public string Naziv { get => naziv; set => naziv = value; }
        public string Id { get => id; set => id = value; }
        public string Opis { get => opis; set => opis = value; }
        public string Proizvodjac { get => proizvodjac; set => proizvodjac = value; }
        public double Cijena
        {
            get => cijena; set
            {
                cijena = value;
                OnPropertyChanged(cijena.ToString());
            }
        }
        public INavigationService NavigationService { get => navigationService; set => navigationService = value; }
        public string Komentar
        {
            get => komentar;
            set
            {
                komentar = value;
                OnPropertyChanged(komentar);
            }
        }
        public Proizvod Proizvod { get => proizvod; set => proizvod = value; }
        public int Kolicina
        {
            get => kolicina;
            set
            {
                kolicina = value;
                OnPropertyChanged(kolicina.ToString());
            }
        }
        public ICommand DodajBarCodeBtn { get => dodajBarCodeBtn; set => dodajBarCodeBtn = value; }
        public ICommand DodajBtn { get => this.dodajBtn; set => this.dodajBtn = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public DodajProizvodViewModel()
        {
            navigationService = new NavigationService();
            proizvod = new Proizvod();
            dodajBtn = new RelayCommand<object>(dodaj, moze);
        }

        private bool moze(object arg)
        {
           return true;
        }

        private async void dodaj(object obj)
        {
            int indikator = 0;
            if (Naziv == "") indikator = -1;
            if (Opis == "") indikator = -1;
            if (Proizvodjac == "") indikator = -1;
            if (Cijena <= 0) indikator = -1;
            if (Komentar == "") indikator = -1;
            if (Kolicina < 0) indikator = -1;
            if (indikator == -1)
            {
                var dialog1 = new MessageDialog("Neispravni podaci");
                await dialog1.ShowAsync();

            }
            else
            {
                DefaultPodaci._proizvodi.Add(new Proizvod(Naziv, id,Proizvodjac, opis, cijena, kolicina, komentar));
                Naziv = "";
                Opis = "";
                Proizvodjac = "";
                Cijena = 0;
                Kolicina = 0;
                Komentar = "";
                var dialog1 = new MessageDialog("Uspjesno dodan proizvod");
                await dialog1.ShowAsync();
            }
        }
    }
}
