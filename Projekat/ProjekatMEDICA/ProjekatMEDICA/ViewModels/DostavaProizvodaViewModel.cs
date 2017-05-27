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
    class DostavaProizvodaViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<StavkaNarudzbe> stavkeNarudzbi { get; set; } //bind
        public ICommand logoutBtn { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private INavigationService NavigationService;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
