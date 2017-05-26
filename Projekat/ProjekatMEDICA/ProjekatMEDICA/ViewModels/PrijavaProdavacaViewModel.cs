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
    public class PrijavaProdavacaViewModel: INotifyPropertyChanged
    {
        public string username { get; set; }
        public string password { get; set; }
        public ICommand prijaviSe { get; set; }
        public INavigationService navigationService { get; set; }

        public PrijavaProdavacaViewModel()
        {
            prijaviSe = new RelayCommand<object>(prijaviProdavaca);
            navigationService = new NavigationService();
        }

        public async void prijaviProdavaca(object parameter)
        {
            Prodavac p = (Prodavac)DefaultPodaci.nadjiProdavaca(username, password);
            if (p == null)
            {
                var dialog1 = new MessageDialog("Neispravni podaci!");
                await dialog1.ShowAsync();
            }
            else navigationService.Navigate(typeof(ProdavanjeProizvoda));
        }
    
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


    }
}
