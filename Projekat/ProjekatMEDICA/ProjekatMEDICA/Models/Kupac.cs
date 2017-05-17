using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public abstract class Kupac
    {
        ICollection<StavkaNarudzbe> kupljeniProizvodi;

        public ICollection<StavkaNarudzbe> KupljeniProizvodi { get => kupljeniProizvodi; set => kupljeniProizvodi = value; }
    }
}
