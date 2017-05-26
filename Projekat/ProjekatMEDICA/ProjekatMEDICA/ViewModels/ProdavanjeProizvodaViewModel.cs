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
    class ProdavanjeProizvodaViewModel: INotifyPropertyChanged
    {
        public Proizvod proizvod { get; set; }
        public string kolicina { get; set; }
        public bool kartica { get; set; }
        public float zaPlatiti { get; set; }
        public string kupac { get; set; }
        public ICommand prodaj { get; set; }
        public ICommand prodaniProizvodi { get; set; }
        public Prodavac prodavac { get; set; }
        public INavigationService navigationService { get; set; }
        public string imePrezime { get; set; }
        public ICommand odjava { get; set; }
        public ObservableCollection<Proizvod> proizvodii;
        public Proizvod odabraniProizvod;

        public ProdavanjeProizvodaViewModel(PrijavaProdavacaViewModel p)
        {
            prodavac = p.prodavac;
            navigationService = new NavigationService();
            prodaj = new RelayCommand<object>(prodajf, mozeLiProdati);
            prodaniProizvodi = new RelayCommand<object>(listaProdanih, mozeLiOtvoriti);
            imePrezime = prodavac._ime + " " + prodavac._prezime;
            odjava = new RelayCommand<object>(odjaviSe, mozeLiOtvoriti);
            proizvodii = new ObservableCollection<Proizvod>();
            proizv();
        }

        public void proizv()
        {
            foreach (Proizvod p in DefaultPodaci._proizvodi) proizvodii.Add(p); // ne radiiiiiii
            proizvodii.Add(new Proizvod("neki", "2", "p", "p", 2.3, "p"));
            odabraniProizvod = proizvodii[0];
        }

        public ProdavanjeProizvodaViewModel() { }


        public event PropertyChangedEventHandler PropertyChanged;

        public void prodajf(Object o)
        {
            
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
            if (kolicina == "1" || kolicina == "2" || kolicina == "3" || kolicina == "4" || kolicina == "5") return true; //nema bas smisla kupiti vise od pet istih proizvoda
            else return false; // u slucaju da je bilo sta pogresno uneseno
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
