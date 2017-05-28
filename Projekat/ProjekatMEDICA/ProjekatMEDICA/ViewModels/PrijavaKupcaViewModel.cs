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
using Windows.UI.Xaml.Controls;

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
        public PasswordBox pass { get; set; }

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

        

        private async void potvrdi(object obj)
        {
           // var UnosPassBox = obj as PasswordBox;
            //sifra = pass.Password;
            kupac = (OnlineKupac)DefaultPodaci.nadjiKupca(sifra, korisnickoIme);
            if (kupac == null)
            {
                var dialog1 = new MessageDialog("Neispravni podaci!");
                await dialog1.ShowAsync();
            }
            else
            {
                navigationService.Navigate(typeof(NarucivanjeProizvoda), new NarucivanjeProizvodaViewModel(this));
            }

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
