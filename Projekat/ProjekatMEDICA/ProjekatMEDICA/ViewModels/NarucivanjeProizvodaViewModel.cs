using ProjekatMEDICA.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjekatMEDICA.ViewModels
{
    class NarucivanjeProizvodaViewModel
    {
        private PrijavaKupcaViewModel prijavaKupcaViewModel;

        public ICommand racun { get; set; }
        public ICommand kupi { get; set; }
        public ICommand trazi { get; set; }
        public string pretraga { get; set; }
        public ObservableCollection<Proizvod> proizvodi { get; set; } //koji ce se dodavati u listView

        public NarucivanjeProizvodaViewModel()
        {
            racun = new RelayCommand<object>(prikaziRacun, jeLiMogucePrikazati);
            trazi = new RelayCommand<object>(prikaziListView, jeLiMoguceLV);
            kupi = new RelayCommand<object>(kupiProizvod, jeLiMoguceKupiti);
        }

        public NarucivanjeProizvodaViewModel(PrijavaKupcaViewModel prijavaKupcaViewModel) //treba kod prijave
        {
            this.prijavaKupcaViewModel = prijavaKupcaViewModel;
        }

        public bool jeLiMogucePrikazati(Object o)
        {
            return true;
        }

        public bool jeLiMoguceLV(Object o)
        {
            return true;
        }

        public bool jeLiMoguceKupiti(Object o)
        {
            return true;
        }

        public void prikaziRacun(Object o)
        {
            //treba se povezati sa trenutnim ulogovanim kupcem i samo kao MessageBox.show prikazati stanje racuna
        }

        public void prikaziListView(Object o)
        {
            //
        }

        public void kupiProizvod(Object o)
        {
            //dodati proizvod na listu kupljenih proizvoda kupca i skinuti s liste dostupnih...
        }
    }
}
