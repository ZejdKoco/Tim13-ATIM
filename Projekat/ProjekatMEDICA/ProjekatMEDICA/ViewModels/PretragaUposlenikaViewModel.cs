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

namespace ProjekatMEDICA.ViewModels
{
    class PretragaUposlenikaViewModel : INotifyPropertyChanged
    {
        public string imePrezimeID { get; set; }
        public ICommand pretragaBtn { get; set; }
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
            pretragaBtn = new RelayCommand<object>(pretragaF, mozePretraga);
            potvrdiBtn = new RelayCommand<object>(potvrdiF, mozePotvrda);
        }
        public bool mozePretraga(Object parameter)
        {
            return true;
        }
        public bool mozePotvrda(Object parameter)
        {
            return true;
        }
        public void pretragaF(Object parameter)
        {
            //dodavanje u listu
        }
        public void potvrdiF(Object parameter)
        {
            NavigationService.Navigate(typeof(AzuriranjeUposlenika));
        }
    }
}
