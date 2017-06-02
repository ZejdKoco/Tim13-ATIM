using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Windows.UI.Popups;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using ProjekatMEDICA.Helper;
using ProjekatMEDICA.Models;

namespace ProjekatMEDICA.ViewModels
{
    public class RegistracijaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        INavigationService navigationService;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        //u seterima OnPropertyChanged staviti
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string spol { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public ICommand muskoJe { get; set; }
        public ICommand zenskoJe { get; set; }
        public ICommand regBtn { get; set; }
        public ICommand izadji { get; set; }
        public RegistracijaViewModel()
        {
            navigationService = new NavigationService();
            regBtn = new RelayCommand<Object>(registrujSe, mozeLi);
            muskoJe = new RelayCommand<Object>(musko);
            zenskoJe = new RelayCommand<Object>(zensko);
            izadji = new RelayCommand<Object>(izadjif);
        }

        public void izadjif(Object o)
        {
            navigationService.Navigate(typeof(FormOdabirUloge));
        }

        public void musko(Object o)
        {
            spol = "Musko";
        }

        public void zensko(Object o)
        {
            spol = "Zensko";
        }

        public bool mozeLi(Object o)
        {
            return true;
        }
        

        public bool sveUredu()
        {
            if (ime == null) return false;
            if (prezime == null) return false;
            if (username == null) return false;
            if (password == null) return false;

            return true;
        }

        public bool slobodanUsername(string user)
        {
            foreach(OnlineKupac k in DefaultPodaci._kupci)
            {
                if (k.Username == user) return false;
            }

            foreach(OnlineKupac k in DefaultPodaci._nepotvrdjeniKupci)
            {
                if (k.Username == user) return false;
            }

            return true;
        }

        public async void registrujSe(Object o)
        {
            if (!sveUredu())
            {
                var dialog = new MessageDialog("Nisu unesena sva polja.");
                await dialog.ShowAsync();
            }
            else
            {
                if (slobodanUsername(username))
                {
                    OnlineKupac kup = new OnlineKupac(ime, prezime, spol, datumRodjenja, username, password);
                    DefaultPodaci._nepotvrdjeniKupci.Add(kup);

                    int br = DefaultPodaci._nepotvrdjeniKupci.Count;

                    var dialog = new MessageDialog("Uspjesno ste se registrovali. Cekajte potvrdu menadzera.");
                    await dialog.ShowAsync();
                }
                else
                {
                    var dialog = new MessageDialog("Username je vec zauzet");
                    await dialog.ShowAsync();
                }
            }


        }

    }
}
