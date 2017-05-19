using ProjekatMEDICA.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatMEDICA.ViewModels
{
    public class MenadzerFormViewModel
    {
        public ICommand dodajProizvod { get; set; }
        public ICommand dodajUposlenika { get; set; }
        public ICommand dodajKupca { get; set; }
        public ICommand brisiProizvod { get; set; }
        public ICommand brisiUposlenika { get; set; }
        public ICommand brisiKupca { get; set; }
        public ICommand azurirajProizvod { get; set; }
        public ICommand azurirajUposlenika { get; set; }
        public INavigationService NavigationService { get; set; }

        public MenadzerFormViewModel()
        {
            NavigationService = new NavigationService();
            dodajProizvod = new RelayCommand<object>(dodProizvod, mozeLiDodavanjeProizvoda);
            dodajUposlenika = new RelayCommand<object>(dodUposlenika, mozeLiDodavanjeUposlenika);
            dodajKupca = new RelayCommand<object>(dodKupca, mozeLiDodavanjeKupca);
            brisiProizvod = new RelayCommand<object>(briProizvod, mozeLiBrisanjeProizvoda);
            brisiUposlenika = new RelayCommand<object>(briUposlenika, mozeLiBrisanjeUposlenika);
            brisiKupca = new RelayCommand<object>(briKupca, mozeLiBrisanjeKupca);
            azurirajProizvod = new RelayCommand<object>(azuProizvoda, mozeLiAzuriranjeProizvoda);
            azurirajUposlenika = new RelayCommand<object>(azuUposlenika, mozeLiAzuriranjeUposlenika);
        }

        public bool mozeLiDodavanjeProizvoda(Object parameter)
        {
            return true;
        }

        public bool mozeLiDodavanjeUposlenika(Object parameter)
        {
            return true;
        }

        public bool mozeLiDodavanjeKupca(Object parameter)
        {
            return true;
        }

        public bool mozeLiBrisanjeProizvoda(Object parameter)
        {
            return true;
        }

        public bool mozeLiBrisanjeUposlenika(Object parameter)
        {
            return true;
        }

        public bool mozeLiBrisanjeKupca(Object parameter)
        {
            return true;
        }

        public bool mozeLiAzuriranjeProizvoda(Object parameter)
        {
            return true;
        }
        public bool mozeLiAzuriranjeUposlenika(Object parameter)
        {
            return true;
        }


        public void dodProizvod(Object parameter)
        {
            NavigationService.Navigate(typeof(DodavanjeProizvoda));
        }

        public void dodUposlenika(Object parameter)
        {
            NavigationService.Navigate(typeof(DodavanjeUposlenika));
        }

        public void dodKupca(Object parameter)
        {
            NavigationService.Navigate(typeof(UnosKorisnika));
        }

        public void briProizvod(Object parameter)
        {
            NavigationService.Navigate(typeof(IzbrisiProizvod));
        }

        public void briUposlenika(Object parameter)
        {
            NavigationService.Navigate(typeof(BrisanjeUposlenika));
        }

        public void briKupca(Object parameter)
        {
            NavigationService.Navigate(typeof(BrisanjeKupca));
        }

        public void azuProizvoda(Object parameter)
        {
            NavigationService.Navigate(typeof(AzurirajProizvodParent));
        }

        public void azuUposlenika(Object parameter)
        {
            NavigationService.Navigate(typeof(PretragaUposlenika));
        }
    }
}
