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
    class BrisanjeKupcaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public OnlineKupac odabrani;
        public string imePrezimeID { get; set; }
        public ICommand pretragaBtn { get; set; }
        public ObservableCollection<OnlineKupac> kupci { get; set; }
        public ICommand obrisiBtn { get; set; }
        private INavigationService NavigationService;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public BrisanjeKupcaViewModel()
        {
            NavigationService = new NavigationService();
            obrisiBtn = new RelayCommand<object>(izbrisi);
            pretragaBtn = new RelayCommand<object>(pretraga);
            kupci = new ObservableCollection<OnlineKupac>();
            Kupci();
        }
        public void Kupci()
        {
            foreach (OnlineKupac p in DefaultPodaci._kupci)
            {
                kupci.Add(new OnlineKupac(p.Ime, p.Prezime, p.Spol, p.DatumRodjenja, p.Username, p.Password));
            }
        }
        private async void izbrisi(object obj)
        {
            if (DefaultPodaci._kupci.Count() > 0)
            {
                if (odabrani != null)
                {
                    for (int i = 0; i < DefaultPodaci._kupci.Count(); i++)
                    {
                        if (DefaultPodaci._kupci[i].Ime== odabrani.Ime && DefaultPodaci._kupci[i].Prezime == odabrani.Prezime)
                        {
                            DefaultPodaci._kupci.RemoveAt(i);
                            break;
                        }
                    }
                    var dialog1 = new MessageDialog("Uspjesno izbrisan kupac");
                    await dialog1.ShowAsync();
                    imePrezimeID = "";
                    kupci.Clear();
                    Kupci();
                }
            }
        }
        private void pretraga(object obj)
        {
            OnlineKupac p = DefaultPodaci.nadjiKupca(imePrezimeID);
            if (p != null)
            {
                kupci.Clear();
                kupci.Add(p);
            }
        }

    }
}
