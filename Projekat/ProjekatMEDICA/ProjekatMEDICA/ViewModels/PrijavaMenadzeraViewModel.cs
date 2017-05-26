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
    class PrijavaMenadzeraViewModel: INotifyPropertyChanged
    {
        private INavigationService navigationService;
        public string korisnickoIme { get; set; }
        ICommand potvrdiBtn;
        public INavigationService NavigationService { get => navigationService; set => navigationService = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value;  }
        public ICommand PotvrdiBtn { get => potvrdiBtn; set => potvrdiBtn = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public PrijavaMenadzeraViewModel()
        {
            navigationService = new NavigationService();
            potvrdiBtn = new RelayCommand<object>(potvrdi);
        }

        private async void potvrdi(object obj)
        {
            Menadzer m = (Menadzer)DefaultPodaci.nadjiMenadzera(korisnickoIme);
            if (m==null)
            {
                var dialog1 = new MessageDialog("Neispravni podaci!" );
                await dialog1.ShowAsync();
            }
            else navigationService.Navigate(typeof(MenadzerForm));
        }
    }
}
