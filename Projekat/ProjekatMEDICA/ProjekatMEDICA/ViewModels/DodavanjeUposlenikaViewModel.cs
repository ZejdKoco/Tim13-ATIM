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
<<<<<<< HEAD
        public string username { get; set; }
        public string password { get; set; }
        public bool prodavacJe { get; set; }
        public bool dostavljacJe { get; set; }
=======
        public string strucnSprema { get; set; }
        public string komentar { get; set; }
>>>>>>> c748e942de5631c319dec2f739a560f4b90c57b9
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
        public void pozoviDodavanjeUposlenika()
        {
<<<<<<< HEAD
           unosUposlenika.Navigate(typeof(DodavanjeUposlenika));
        }
        public void potvrdiDodavanje(object parametar)
        {
            /*Spasavanje unesenih postavki u defaultnipodaci._uposlenici*/
            if (prodavacJe) DefaultPodaci._uposlenici.Add(prodavacClass);
            if (dostavljacJe) DefaultPodaci._uposlenici.Add(dostavljacClass);
            //NavigationService.Navigate(typeof(MenadzerForm));
<<<<<<< HEAD
=======
=======
           unosUposlnika.Navigate(typeof(DodavanjeUposlenika));
>>>>>>> c748e942de5631c319dec2f739a560f4b90c57b9
>>>>>>> 6f61c2f5c801e51039b1dfcf5ab15d81bd6a7cdc
        }
    }
}
