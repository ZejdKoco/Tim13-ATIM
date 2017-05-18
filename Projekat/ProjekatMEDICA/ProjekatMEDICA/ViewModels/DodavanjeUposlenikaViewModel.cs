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
    class DodavanjeUposlenikaViewModel : INotifyPropertyChanged
    {
        public INavigate unosUposlnika;
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string maticni { get; set; }
        public string strucnSprema { get; set; }
        public string komentar { get; set; }
        public ICommand regBtn { get; set; }
        public ICommand backBtn { get; set; }
        public ICommand muskoJe { get; set; }
        public ICommand zenskoJe { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void pozoviRegistracija()
        {
           unosUposlnika.Navigate(typeof(DodavanjeUposlenika));
        }
    }
}
