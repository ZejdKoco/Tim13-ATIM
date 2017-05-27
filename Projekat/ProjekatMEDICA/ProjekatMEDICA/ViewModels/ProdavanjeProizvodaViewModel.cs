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
using Windows.UI.Popups;

namespace ProjekatMEDICA.ViewModels 
{
    class ProdavanjeProizvodaViewModel : INotifyPropertyChanged
    {
        public Proizvod proizvod { get; set; }
        public string kolicina { get; set; }
        public bool kartica { get; set; }
        public string zaPlatiti { get; set; }
        public string kupac { get; set; }
        public ICommand prodaj { get; set; }
        public ICommand prodaniProizvodi { get; set; }
        public Prodavac prodavac { get; set; }
        public Prodavac prodavacIzPocetne { get; set; }
        public INavigationService navigationService { get; set; }
        public string imePrezime { get; set; }
        public ICommand odjava { get; set; }
        public ObservableCollection<Proizvod> proizvodii { get; set; }
        public Proizvod odabraniProizvod { get; set; }
        public ProdavanjeProizvoda prodavanjeView;
        public ICommand imaKarticu { get; set; }
        public ICommand nemaKarticu { get; set; }
        public ICommand buttonZaPlatiti { get; set; }
        public bool karticaIma { get; set; }

        public ProdavanjeProizvodaViewModel(PrijavaProdavacaViewModel p)
        {
            prodavac = p.prodavac;
            prodavacIzPocetne = p.prodavac;
            navigationService = new NavigationService();
            prodaj = new RelayCommand<object>(prodajf, mozeLiProdati);
            prodaniProizvodi = new RelayCommand<object>(listaProdanih, mozeLiOtvoriti);
            imePrezime = prodavac._ime + " " + prodavac._prezime;
            odjava = new RelayCommand<object>(odjaviSe, mozeLiOtvoriti);
            proizvodii = new ObservableCollection<Proizvod>();
            imaKarticu = new RelayCommand<Object>(imaKar, mozeLiOtvoriti);
            nemaKarticu = new RelayCommand<Object>(nemaKar, mozeLiOtvoriti);
            buttonZaPlatiti = new RelayCommand<Object>(zaPlatitiF, mozeLiOtvoriti);
            proizv();
        }

        public async void zaPlatitiF(Object o)
        {
            String s = odabraniProizvod.Cijena.ToString("00.00");
            var dialog1 = new MessageDialog(s);
            await dialog1.ShowAsync();
        }

        public void imaKar(Object o)
        {
            karticaIma = true;
        }
        
        public void nemaKar(object o)
        {
            karticaIma = false;
        }
        

        public void proizv()
        {
            prodavac = prodavacIzPocetne;
            proizvodii = new ObservableCollection<Proizvod>();
            foreach (Proizvod p in DefaultPodaci._proizvodi) proizvodii.Add(p); 
            odabraniProizvod = proizvodii[0];
        }

        public ProdavanjeProizvodaViewModel()
        {
            
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private bool validirajKolicinuProizvoda()
        {
            if (kolicina == "1" || kolicina == "2" || kolicina == "3" || kolicina == "4" || kolicina == "5") return true; //nema bas smisla kupiti vise od pet istih proizvoda
            else return false; // u slucaju da je bilo sta pogresno uneseno
        }

        public async void prodajf(Object o)
        {
            
            var dialog1 = new MessageDialog(odabraniProizvod.Naziv);
            await dialog1.ShowAsync();
        }

        public async void listaProdanih(Object o)
        {
            prodavac.dodajProdaniProizvod(DefaultPodaci._proizvodi[0]); //probno
            prodavac.dodajProdaniProizvod(DefaultPodaci._proizvodi[0]); //probno
            String s = "";
            foreach(Proizvod p in prodavac.dajProdaneProizvode())
            {
                s = s + p.Naziv + "\n";
            }
            var dialog1 = new MessageDialog(s);
            await dialog1.ShowAsync();
        }

        public void odjaviSe(Object o)
        {
            navigationService.Navigate(typeof(FormOdabirUloge));
        }
        

        public bool mozeLiProdati(Object o)
        {
            /*if (kolicina == "1" || kolicina == "2" || kolicina == "3" || kolicina == "4" || kolicina == "5") return true; //nema bas smisla kupiti vise od pet istih proizvoda
            else return false; // u slucaju da je bilo sta pogresno uneseno*/
            return true;
        }

        public bool mozeLiOtvoriti(Object o)
        {
            return true;
        }

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
