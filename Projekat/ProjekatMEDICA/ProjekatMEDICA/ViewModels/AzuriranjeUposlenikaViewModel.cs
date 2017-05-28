using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using ProjekatMEDICA.Models;
using ProjekatMEDICA.Helper;
using Windows.UI.Popups;

namespace ProjekatMEDICA.ViewModels
{
    class AzuriranjeUposlenikaViewModel : INotifyPropertyChanged
    {
        public INavigate azuriranjeUposlnika;
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public DateTime datumZaposlenja { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public ICommand azurirajBtn { get; set; }
        Uposlenik original;
        public event PropertyChangedEventHandler PropertyChanged;
        private INavigationService navigationService;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void pozoviDodavanjeUposlenika()
        {
            azuriranjeUposlnika.Navigate(typeof(AzuriranjeUposlenika));
        }
        public AzuriranjeUposlenikaViewModel(PretragaUposlenikaViewModel v)
        {
            navigationService = new NavigationService();
            azurirajBtn = new RelayCommand<object>(AzurirajAsync);
            ime = v.odabrani._ime;
            prezime = v.odabrani._prezime;
            datumRodjenja = v.odabrani._datumRodjenja;
            datumZaposlenja = v.odabrani._datumZaposlenja;
            username = v.odabrani.username;
            password = v.odabrani.password;
            original = DefaultPodaci.nadjiUposlenika(ime, prezime, datumRodjenja, datumZaposlenja); //dodati ID
        }
        public AzuriranjeUposlenikaViewModel()
        {
            navigationService = new NavigationService();
            azurirajBtn = new RelayCommand<object>(AzurirajAsync);
        }
        public async void AzurirajAsync(object o)
        {
            Uposlenik novi = new Uposlenik(ime, prezime, 1, datumRodjenja, datumZaposlenja);
            DefaultPodaci.AzurirajUposlenika(original, novi);
            var dialog1 = new MessageDialog("Azuriranje uspjesno!");
            await dialog1.ShowAsync();
        }

    }
}
