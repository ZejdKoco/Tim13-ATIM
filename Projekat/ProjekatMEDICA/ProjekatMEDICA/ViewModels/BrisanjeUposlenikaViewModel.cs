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
    class BrisanjeUposlenikaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Uposlenik odabrani;
        public string imePrezimeID { get; set; }
        public ICommand pretragaBtn { get; set; }
        public ObservableCollection<Uposlenik> uposlenici { get; set; }
        public ICommand obrisiBtn { get; set; }
        private INavigationService NavigationService;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public BrisanjeUposlenikaViewModel()
        {
            NavigationService = new NavigationService();
            obrisiBtn = new RelayCommand<object>(izbrisi);
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
        private async void izbrisi(object obj)
        {
            if (DefaultPodaci._uposlenici.Count() > 0)
            {
                if (odabrani != null)
                {
                    for (int i = 0; i < DefaultPodaci._uposlenici.Count(); i++)
                    {
                        if (DefaultPodaci._uposlenici[i]._ime == odabrani._ime && DefaultPodaci._uposlenici[i]._prezime == odabrani._prezime)
                        {
                            DefaultPodaci._uposlenici.RemoveAt(i);
                            break;
                        }
                    }
                    var dialog1 = new MessageDialog("Uspjesno izbrisan uposlenik");
                    await dialog1.ShowAsync();
                    imePrezimeID = "";
                    uposlenici.Clear();
                    Uposlenici();
                }
            }
        }

    }
}
