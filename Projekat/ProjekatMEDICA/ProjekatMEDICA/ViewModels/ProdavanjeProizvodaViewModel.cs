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
            double cijena = odabraniProizvod.Cijena * Convert.ToInt16(kolicina);
            String s = cijena.ToString("00.00");
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

        

        public async void prodajf(Object o)
        {
            if (kolicina=="1" || kolicina == "2" || kolicina == "3" || kolicina == "4" || kolicina == "5" )
            {
                if (!karticaIma)
                {
                    prodavac.dodajProdaniProizvod(new Proizvod(odabraniProizvod));
                    var dialog1 = new MessageDialog("Uspjesno ste prodali proizvod: " + odabraniProizvod.Naziv);
                    await dialog1.ShowAsync();
                }
                else
                {
                    string[] razdvoji = null;
                    if (kupac != null || kupac.Length!=0 ) razdvoji=kupac.Split(' ');
                    if (razdvoji.Length < 2 || razdvoji==null)
                    {
                        var dialog1 = new MessageDialog("Unesite puno ime i prezime kupca");
                        await dialog1.ShowAsync();
                    }
                    else
                    {
                        string ime = razdvoji[0];
                        string prezime = razdvoji[1];
                        OnlineKupac kup = null;
                        foreach (OnlineKupac k in DefaultPodaci._kupci)
                        {
                            if (k.Ime == ime && k.Prezime == prezime)
                            {
                                kup = k;
                            }

                        }
                        if (kup != null)
                        {
                            prodavac.dodajProdaniProizvod(new Proizvod(odabraniProizvod));
                            ObservableCollection<Proizvod> proizvodi = new ObservableCollection<Proizvod>();
                            int kol = Convert.ToInt32(kolicina);
                            for (int i = 0; i < kol; i++) proizvodi.Add(odabraniProizvod);
                            kup.KupljeniProizvodi.Add(new StavkaNarudzbe(DateTime.Now, proizvodi, 2.4));
                            var dialog1 = new MessageDialog("Uspjesna prodaja kupcu " + kup.Ime + " " + kup.Prezime);
                            await dialog1.ShowAsync();
                        }
                        else
                        {
                            var dialog1 = new MessageDialog("Nije pronadjen kupac sa datim imenom i prezimenom.");
                            await dialog1.ShowAsync();
                        }
                    }

                }
            }
            else
            {
                var dialog1 = new MessageDialog("Dozvoljeni broj proizvoda za kupiti je: 1,2,3,4,5.");
                await dialog1.ShowAsync();
            }
            
            /*
            var dialog1 = new MessageDialog(odabraniProizvod.Naziv);
            await dialog1.ShowAsync();*/
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
