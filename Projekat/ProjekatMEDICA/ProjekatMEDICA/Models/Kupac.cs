using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public abstract class Kupac
    {
        ObservableCollection<StavkaNarudzbe> kupljeniProizvodi;

        public ObservableCollection<StavkaNarudzbe> KupljeniProizvodi { get => kupljeniProizvodi; set => kupljeniProizvodi = value; }

        public Kupac()
        {
            KupljeniProizvodi = new ObservableCollection<StavkaNarudzbe>();
        }

        
    }
}
