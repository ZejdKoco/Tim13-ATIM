using ProjekatMEDICA.Helper;
using ProjekatMEDICA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatMEDICA.ViewModels
{
    class PrijavaDostavljacaViewModel : INotifyPropertyChanged
    {
        public string username { get; set; }
        public string password { get; set; }
        public ICommand prijavaBtn { get; set; }
        public INavigationService navigationService { get; set; }
        public Dostavljac dostavljac { get; set; }
        public PrijavaDostavljacaViewModel()
        {
            prijavaBtn = new RelayCommand<object>(prijavaDostavljaca);
            navigationService = new NavigationService();
        }
        public void prijavaDostavljaca(object parameter)
        {
            else navigationService.Navigate(typeof(DostavaProizvoda), new DostavaProizvodaViewModel(this));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
