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
    class IzbrisiProizvodViewModel: INotifyPropertyChanged
    {
        public string naziv { get; set; }
        public ICommand pretragaBtn { get; set; }
        public ObservableCollection<Proizvod> proizvodi { get; set; }
        public ICommand potvrdiBtn { get; set; }
        public INavigationService AzuriranjeProizvodaParent { get => NavigationService; set => NavigationService = value; }
        public event PropertyChangedEventHandler PropertyChanged;
        private INavigationService NavigationService;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void pozivAzuriranjeProizvodaParent()
        {
            AzuriranjeProizvodaParent.Navigate(typeof(AzurirajProizvodParent));
        }
        public IzbrisiProizvodViewModel()
        {
            NavigationService = new NavigationService();
            potvrdiBtn = new RelayCommand<object>(izbrisi, mozeLiSeIzbrisati);
        }

        private void izbrisi(object obj)
        {
        }

        public bool mozeLiSeIzbrisati(object parametar)
        {
            return true;
        }
    }
}
