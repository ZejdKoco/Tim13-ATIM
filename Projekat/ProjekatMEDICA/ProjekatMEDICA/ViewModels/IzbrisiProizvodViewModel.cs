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
    class IzbrisiProizvodViewModel: INotifyPropertyChanged
    {
        private Proizvod odabrani;
        private string naziv;
        public ICommand pretragaBtn { get; set; }
        public ObservableCollection<Proizvod> proizvodi { get; set; }
        
        public ICommand potvrdiBtn { get; set; }
        public string Naziv
        {
            get => naziv;
            set
            {
                naziv = value;
                if (naziv == "")
                {
                    proizvodi.Clear();
                    Proizvodi();
                }
            }
        }

        public Proizvod Odabrani { get => odabrani; set => odabrani = value; }
        public event PropertyChangedEventHandler PropertyChanged;
        private INavigationService NavigationService;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        public IzbrisiProizvodViewModel()
        {
            NavigationService = new NavigationService();
            potvrdiBtn = new RelayCommand<object>(izbrisi, mozeLiSeIzbrisati);
            pretragaBtn = new RelayCommand<object>(pretraga, mozeLiSeIzbrisati);
            proizvodi = new ObservableCollection<Proizvod>();
            Proizvodi();
        }

        private void pretraga(object obj)
        {
            Proizvod p = (Proizvod)DefaultPodaci.nadjiProizvod(Naziv);
            if (p != null)
            {
                proizvodi.Clear();
                proizvodi.Add(p);
            }
        }

        private async void izbrisi(object obj)
        {
            if (DefaultPodaci._proizvodi.Count() > 0)
            {
                if (Odabrani != null)
                {
                    for (int i = 0; i < DefaultPodaci._proizvodi.Count(); i++)
                    {
                        if (DefaultPodaci._proizvodi[i].Id == Odabrani.Id)
                        {
                            DefaultPodaci._proizvodi.RemoveAt(i);
                            break;
                        }
                    }
                    var dialog1 = new MessageDialog("Uspjesno izbrisan proizvod");
                    await dialog1.ShowAsync();
                    Naziv = "";
                    proizvodi.Clear();
                    Proizvodi();
                }
            }
        }

        public bool mozeLiSeIzbrisati(object parametar)
        {
            return true;
        }
        public void Proizvodi()
        {
            foreach (Proizvod p in DefaultPodaci._proizvodi)
            {
                proizvodi.Add(new Proizvod(p.Naziv, p.Id, p.Proizvodjac, p.Opis, p.Cijena, p.Kolicina, p.Komentar));
            }
        }
    }
}
