using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public class Menadzer : Uposlenik
    {
        public Menadzer(string ime, string prezime, int id, string usernme,DateTime dR, DateTime dZ) : base(ime, prezime, id, dR, dZ)
        {
            uloga = "Menadzer";
            username = usernme;
            password = "ne treba";
        }

        public void dodajKupca(Kupac k)
        {
           // DefaultPodaci.
        }
    }
}
