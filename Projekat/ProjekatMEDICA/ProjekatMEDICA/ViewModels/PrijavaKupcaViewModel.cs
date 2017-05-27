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
    class PrijavaKupcaViewModel : INotifyPropertyChanged
    {
        OnlineKupac kupac;
        private INavigationService navigationService;
        string sifra;
        string korisnickoIme;
        ICommand potvrdiBtn;
        public INavigationService NavigationService { get => navigationService; set => navigationService = value; }
        public OnlineKupac Kupac { get => kupac; set => kupac = value; }
        public string Sifra { get => sifra; set => sifra = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public ICommand PotvrdiBtn { get => potvrdiBtn; set => potvrdiBtn = value; }
        public ICommand registrujSe { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public PrijavaKupcaViewModel()
        {
            navigationService = new NavigationService();
            kupac = new OnlineKupac();
            potvrdiBtn = new RelayCommand<object>(potvrdi);
            registrujSe = new RelayCommand<object>(registr, mozeLi);
        }

        private void potvrdi(object obj)
        {
            navigationService.Navigate(typeof(NarucivanjeProizvoda));
        }

        public bool mozeLi(object o)
        {
            return true;
        }

        public void registr(object o)
        {
            navigationService.Navigate(typeof(RegistracijaOnlineKupca));
        }
    }
}
