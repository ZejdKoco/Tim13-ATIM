using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public class Prodavac:Uposlenik
    {
         ObservableCollection<Proizvod> prodaniProizvodi { get; set; }
        
        public Prodavac(string ime, string prezime, int id, string usernme, string pw, DateTime dR, DateTime dZ) :base(ime,prezime,id,dR,dZ)
        {
            uloga = "Prodavac";
            username = usernme;
            password = pw;
            prodaniProizvodi = new ObservableCollection<Proizvod>();
        }

        public ObservableCollection<Proizvod> dajProdaneProizvode()
        {
            return prodaniProizvodi;
        }

        public void dodajProdaniProizvod(Proizvod p)
        {
            prodaniProizvodi.Add(p);
        }

        //dodati metode za prodavanje proizvoda objema vrstama kupaca
    }
}
