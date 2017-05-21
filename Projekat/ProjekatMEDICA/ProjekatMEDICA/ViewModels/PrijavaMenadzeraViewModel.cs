using ProjekatMEDICA.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatMEDICA.ViewModels
{
    class PrijavaMenadzeraViewModel: INotifyPropertyChanged
    {
        private INavigationService navigationService;
        string korisnickoIme;
        ICommand potvrdiBtn;
        public INavigationService NavigationService { get => navigationService; set => navigationService = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public ICommand PotvrdiBtn { get => potvrdiBtn; set => potvrdiBtn = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public PrijavaMenadzeraViewModel()
        {
            navigationService = new NavigationService();
            potvrdiBtn = new RelayCommand<object>(potvrdi);
        }

        private void potvrdi(object obj)
        {
            navigationService.Navigate(typeof(MenadzerForm));
        }
    }
}
