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
    class DostavaProizvodaViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<Proizvod> zaDostaviti { get; set; } //bind
        public ICommand logoutBtn { get; set; }
        public ICommand dostavljeno { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private INavigationService navigationService;
        public Proizvod odabrani { get; set; }
        public Dostavljac dostavljac { get; set; }
        public string imePrezime { get; set; }
        public string brDostava { get; set; }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public DostavaProizvodaViewModel(PrijavaDostavljacaViewModel p)
        {
            navigationService = new NavigationService();
            dostavljac = p.dostavljac;
            imePrezime = p.dostavljac._ime + " " + p.dostavljac._prezime;
            brDostava = Convert.ToString(DefaultPodaci._proizvodiZaDostaviti.Count);
            logoutBtn = new RelayCommand<Object>(odjaviSe);
            dostavljeno = new RelayCommand<Object>(dostF);
            zaDostaviti = new ObservableCollection<Proizvod>();
            foreach (Proizvod pp in DefaultPodaci._proizvodiZaDostaviti) zaDostaviti.Add(pp);
            odabrani = zaDostaviti[0];
        }

        public void odjaviSe(Object o)
        {
            navigationService.Navigate(typeof(FormOdabirUloge));
        }

        public async void dostF(Object o)
        {
            if (odabrani==null)
            {
                var dialog1 = new MessageDialog("Niste odabrali proizvod.");
                await dialog1.ShowAsync();
            }
            else
            {
                DefaultPodaci._proizvodiZaDostaviti.Remove(odabrani);
                zaDostaviti.Remove(odabrani);
                brDostava = Convert.ToString(DefaultPodaci._proizvodiZaDostaviti.Count);
                var dialog1 = new MessageDialog("Proizvod je dostavljen.");
                await dialog1.ShowAsync();
            }
        }

        

        public DostavaProizvodaViewModel()
        {

        }
    }
}
