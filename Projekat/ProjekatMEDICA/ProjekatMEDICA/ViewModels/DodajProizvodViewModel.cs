using ProjekatMEDICA.Helper;
using ProjekatMEDICA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatMEDICA.ViewModels
{
    class DodajProizvodViewModel: INotifyPropertyChanged
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
        ICommand dodajBtn;
        ICommand dodajSlikuBtn;
        ICommand dodajBarCodeBtn;
        private INavigationService navigationService;
        public string Naziv { get => naziv; set => naziv = value; }
        public string Id { get => id; set => id = value; }
        public string Opis { get => opis; set => opis = value; }
        public string Proizvodjac { get => proizvodjac; set => proizvodjac = value; }
        public byte[] Slika { get => slika; set => slika = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public INavigationService NavigationService { get => navigationService; set => navigationService = value; }
        public string Komentar { get => komentar; set => komentar = value; }
        public Proizvod Proizvod { get => proizvod; set => proizvod = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public ICommand DodajSlikuBtn { get => dodajSlikuBtn; set => dodajSlikuBtn = value; }
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
            dodajBtn = new RelayCommand<object>(dodaj);
        }

        private void dodaj(object obj)
        {
            
        }
    }
}
