using ProjekatMEDICA.Helper;
using ProjekatMEDICA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatMEDICA.ViewModels
{
    class OdabirUlogeViewModel
    {
        public ICommand loginKupac { get; set; }
        public ICommand loginProdavac { get; set; }
        public ICommand loginMenadzer { get; set; }
        public ICommand loginDostavljac { get; set; }
        public INavigationService NavigationService { get; set; }
        public OdabirUlogeViewModel()
        {
            NavigationService = new NavigationService();
            loginKupac = new RelayCommand<object>(loginKupacF, mozeLogKupac);
            loginProdavac = new RelayCommand<object>(loginProdavacF, mozeLogProdavac);
            loginMenadzer = new RelayCommand<object>(loginMenadzerF, mozeLogMenadzer);
            loginDostavljac = new RelayCommand<object>(loginDostavljacF, mozeLogDostavljac);
        }
        public bool mozeLogKupac(Object parameter)
        {
            return true;
        }
        public bool mozeLogProdavac(Object parameter)
        {
            return true;
        }
        public bool mozeLogMenadzer(Object parameter)
        {
            return true;
        }
        public bool mozeLogDostavljac(Object parameter)
        {
            return true;
        }
        public void loginKupacF(Object parameter)
        {
            NavigationService.Navigate(typeof(PrijavaKupca));
        }
        public void loginProdavacF(Object parameter)
        {
            NavigationService.Navigate(typeof(PrijavaProdavac)); //dodatno pitati za prijavu prodavaca
        }
        public void loginMenadzerF(Object parameter)
        {
            NavigationService.Navigate(typeof(PrijavaMenadzera));
        }
        public void loginDostavljacF(Object parameter)
        {
            NavigationService.Navigate(typeof(PrijavaDostavljaca)); //dodatno pitati za prijavu dostavljaca
        }
    }
    
}
