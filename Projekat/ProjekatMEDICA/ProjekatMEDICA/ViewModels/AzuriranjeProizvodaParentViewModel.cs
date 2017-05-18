using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Windows.UI.Popups;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using ProjekatMEDICA.Models;
using System.Collections.ObjectModel;

namespace ProjekatMEDICA.ViewModels
{
    class AzuriranjeProizvodaParentViewModel : INotifyPropertyChanged
    {
        public string naziv { get; set; }
        public ICommand pretragaBtn { get; set; }
        public ObservableCollection<Proizvod> proizvodi { get; set; }
        public ICommand potvrdiBtn { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigate azuriranjeProizvodaParent;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void pozivAzuriranjeProizvodaParent()
        {
            azuriranjeProizvodaParent.Navigate(typeof(AzurirajProizvodParent));
        }
    }
}
