using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Windows.UI.Popups;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using ProjekatMEDICA.Models;
using System.Collections.ObjectModel;
using ProjekatMEDICA.Helper;

namespace ProjekatMEDICA.ViewModels
{
    class AzuriranjeProizvodaChildViewModel : INotifyPropertyChanged
    {
        Proizvod proizvod;
        string naziv;
        string id;
        string opis;
        string proizvodjac;
        double cijena;
        string komentar;
        int kolicina;
        ICommand spremiBtn;
        AzuriranjeProizvodaParentViewModel parent;
        private INavigationService navigationService;
        public string Naziv { get => naziv; set => naziv = value; }
        public string Id { get => id; set => id = value; }
        public string Opis { get => opis; set => opis = value; }
        public string Proizvodjac { get => proizvodjac; set => proizvodjac = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public INavigationService NavigationService { get => navigationService; set => navigationService = value; }
        public string Komentar { get => komentar; set => komentar = value; }
        public ICommand SpremiBtn { get => spremiBtn; set => spremiBtn = value; }
        public Proizvod Proizvod { get => proizvod; set => proizvod = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        internal AzuriranjeProizvodaParentViewModel Parent { get => parent; set => parent = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public AzuriranjeProizvodaChildViewModel()
        {
            navigationService = new NavigationService();
            SpremiBtn = new RelayCommand<object>(spremiIzmjene, moze);
        }

        private bool moze(object arg)
        {
            return true;
        }

        public AzuriranjeProizvodaChildViewModel(AzuriranjeProizvodaParentViewModel parent)
        {
            this.Parent = parent;
            navigationService = new NavigationService();
            proizvod = parent.odabrani;
            SpremiBtn = new RelayCommand<object>(spremiIzmjene, moze);
            naziv = proizvod.Naziv;
            id = proizvod.Id;
            opis = proizvod.Opis;
            proizvodjac = proizvod.Proizvodjac;
            komentar = proizvod.Komentar;
            cijena = proizvod.Cijena;
            kolicina = proizvod.Kolicina;
        }
        public async void spremiIzmjene(object parametar)
        {
            int indikator = 0;
            if (Naziv != Proizvod.Naziv && Naziv != "")
            {
                for (int i = 0; i < (DefaultPodaci.dajSveProizvode()).Count; i++)
                {
                    if ((DefaultPodaci.dajSveProizvode())[i].Id == Id)
                    {
                        (DefaultPodaci.dajSveProizvode())[i].Naziv = Naziv;
                        break;
                    }
                }
            }
            else if(Naziv == "") indikator = -1;
            if (Opis != Proizvod.Opis && Opis != "")
            {
                for (int i = 0; i < (DefaultPodaci.dajSveProizvode()).Count; i++)
                {
                    if ((DefaultPodaci.dajSveProizvode())[i].Id == Id)
                    {
                        (DefaultPodaci.dajSveProizvode())[i].Opis = Opis;
                        break;
                    }
                }
            }
            else if (Opis == "") indikator = -1;
            if (Proizvodjac != Proizvod.Proizvodjac && Proizvodjac != "")
            {
                for (int i = 0; i < (DefaultPodaci.dajSveProizvode()).Count; i++)
                {
                    if ((DefaultPodaci.dajSveProizvode())[i].Id == Id)
                    {
                        (DefaultPodaci.dajSveProizvode())[i].Proizvodjac = Proizvodjac;
                        break;
                    }
                }
            }
            else if (Proizvodjac == "") indikator = -1;
            if (Cijena != Proizvod.Cijena && Cijena > 0)
            {
                for (int i = 0; i < (DefaultPodaci.dajSveProizvode()).Count; i++)
                {
                    if ((DefaultPodaci.dajSveProizvode())[i].Id == Id)
                    {
                        (DefaultPodaci.dajSveProizvode())[i].Cijena = Cijena;
                        break;
                    }
                }
            }
            else if (Cijena <= 0) indikator = -1;
            if (Komentar != Proizvod.Komentar && Komentar != "")
            {
                for (int i = 0; i < (DefaultPodaci.dajSveProizvode()).Count; i++)
                {
                    if ((DefaultPodaci.dajSveProizvode())[i].Id == Id)
                    {
                        (DefaultPodaci.dajSveProizvode())[i].Komentar = Komentar;
                        break;
                    }
                }
            }
            else if (Komentar == "") indikator = -1;
            if (Kolicina != Proizvod.Kolicina && Kolicina >= 0)
            {
                for (int i = 0; i < (DefaultPodaci.dajSveProizvode()).Count; i++)
                {
                    if ((DefaultPodaci.dajSveProizvode())[i].Id == Id)
                    {
                        (DefaultPodaci.dajSveProizvode())[i].Kolicina = Kolicina;
                        break;
                    }
                }
            }
            else if (Kolicina < 0) indikator = -1;
            if (indikator == -1)
            {
                var dialog1 = new MessageDialog("Neispravni podaci");
                await dialog1.ShowAsync();

            }
            else
            {
                var dialog1 = new MessageDialog("Izmjene su sacuvane!");
                await dialog1.ShowAsync();
            }
        }
    }
}
