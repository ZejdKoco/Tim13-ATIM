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
    class BrisanjeKupcaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string imePrezimeID { get; set; }
        public ICommand pretragaBtn { get; set; }
        public ObservableCollection<Kupac> uposlenici { get; set; } //bind
        public ICommand obrisiBtn { get; set; }
        public ICommand nazadBtn { get; set; }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
    }
}
