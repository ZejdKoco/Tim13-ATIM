using ProjekatMEDICA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        public ProdavanjeProizvodaViewModel()
        {
            prodaj = new RelayCommand<object>(prodajf, mozeLiProdati);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void prodajf(Object o)
        {
            
        }

        

        public bool mozeLiProdati(Object o)
        {
            if (kolicina == "1" || kolicina == "2" || kolicina == "3" || kolicina == "4" || kolicina == "5") return true; //nema bas smisla kupiti vise od pet istih proizvoda
            else return false; // u slucaju da je bilo sta pogresno uneseno
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
