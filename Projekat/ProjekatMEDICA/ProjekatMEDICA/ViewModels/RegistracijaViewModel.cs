using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Windows.UI.Popups;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ProjekatMEDICA.ViewModels
{
    public class RegistracijaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public INavigate registr;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        //u seterima OnPropertyChanged staviti
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string spol { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public ICommand muskoJe { get; set; }
        public ICommand zenskoJe { get; set; }
        public ICommand regBtn { get; set; }

        public void pozoviRegistracija()
        {
            registr.Navigate(typeof(RegistracijaOnlineKupca));
        }

    }
}
