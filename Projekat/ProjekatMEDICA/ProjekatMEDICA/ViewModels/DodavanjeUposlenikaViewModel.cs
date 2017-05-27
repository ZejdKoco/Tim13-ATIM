using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Windows.UI.Popups;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using ProjekatMEDICA.Helper;
using ProjekatMEDICA.Models;

namespace ProjekatMEDICA.ViewModels
{
    class DodavanjeUposlenikaViewModel : INotifyPropertyChanged
    {
        public INavigate unosUposlenika;
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public DateTime datumZaposlenja { get; set; }
        public string maticni { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool prodavacJe { get; set; }
        public bool dostavljacJe { get; set; }
        public ICommand regBtn { get; set; }
        public ICommand backBtn { get; set; }
        public ICommand prodavac { get; set; }
        public ICommand dostavljac { get; set; }
        public Prodavac prodavacClass;
        public Dostavljac dostavljacClass;
        private INavigationService NavigationService;
        public event PropertyChangedEventHandler PropertyChanged;
        public DodavanjeUposlenikaViewModel()
        {
            NavigationService = new NavigationService();
            regBtn = new RelayCommand<object>(potvrdiDodavanje);
            prodavac = new RelayCommand<object>(potvrdiProdavacJe);
            dostavljac = new RelayCommand<object>(potvrdiDostavljacJe);
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void potvrdiProdavacJe(object parametar)
        {
            int id = 1;
            prodavacClass = new Prodavac(ime, prezime, id, username, password, datumRodjenja, datumZaposlenja);

            prodavacJe = true;
        }
        public void potvrdiDostavljacJe(object parametar)
        {
            int id = 1;
            dostavljacClass = new Dostavljac(ime, prezime, id, username, password, datumRodjenja, datumZaposlenja);
            dostavljacJe = true;
        }
        public void pozoviDodavanjeUposlenika()
        {
            unosUposlenika.Navigate(typeof(DodavanjeUposlenika));
        }
        public void potvrdiDodavanje(object parametar)
        {
            /*Spasavanje unesenih postavki u defaultnipodaci._uposlenici*/
            if (prodavacJe) DefaultPodaci._uposlenici.Add(prodavacClass);
            if (dostavljacJe) DefaultPodaci._uposlenici.Add(dostavljacClass);
            //NavigationService.Navigate(typeof(MenadzerForm));
        }

    }
}
