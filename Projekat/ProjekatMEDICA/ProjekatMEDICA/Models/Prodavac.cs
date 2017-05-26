using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public class Prodavac:Uposlenik
    {
        ICollection<Proizvod> prodaniProizvodi;
        
        public Prodavac(string ime, string prezime, int id, string usernme, string pw, DateTime dR, DateTime dZ) :base(ime,prezime,id,dR,dZ)
        {
            uloga = "Prodavac";
            username = usernme;
            password = pw;
        }

        //dodati metode za prodavanje proizvoda objema vrstama kupaca
    }
}
