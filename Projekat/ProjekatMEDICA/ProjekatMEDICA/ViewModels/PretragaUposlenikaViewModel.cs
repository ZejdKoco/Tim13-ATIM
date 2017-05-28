using ProjekatMEDICA.Helper;
using ProjekatMEDICA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace ProjekatMEDICA.ViewModels
{
    class PretragaUposlenikaViewModel : INotifyPropertyChanged
    {
        public string imePrezimeID { get; set; }
        public ICommand pretragaBtn { get; set; }
        public Uposlenik odabrani;
        public ObservableCollection<Uposlenik> uposlenici { get; set; }
        public ICommand potvrdiBtn { get; set; }
        public INavigationService NavigationService { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public PretragaUposlenikaViewModel()
        {
            NavigationService = new NavigationService();
            potvrdiBtn = new RelayCommand<object>(azurirajAsync);
            pretragaBtn = new RelayCommand<object>(pretraga);
            uposlenici = new ObservableCollection<Uposlenik>();
            Uposlenici();
        }
        private void pretraga(object obj)
        {
            Uposlenik p = DefaultPodaci.nadjiUposlenika(imePrezimeID);
            if (p != null)
            {
                uposlenici.Clear();
                uposlenici.Add(p);
            }
        }
        public void Uposlenici()
        {
            foreach (Uposlenik p in DefaultPodaci._uposlenici)
            {
                uposlenici.Add(new Uposlenik(p._ime, p._prezime, p._id, p._datumRodjenja, p._datumZaposlenja));
            }
        }
        public async void azurirajAsync(object o)
        {
            if (odabrani == null)
            {
                var dialog1 = new MessageDialog("Niste odabrali proizvod");
                await dialog1.ShowAsync();
            }
            else
            {

                NavigationService.Navigate(typeof(AzuriranjeUposlenika), new AzuriranjeUposlenikaViewModel(this));
            }
        }

    }
}
