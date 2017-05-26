using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public class Dostavljac:Uposlenik
    {
        ObservableCollection<Proizvod> aktivneDostave { get; set; }
        ObservableCollection<Proizvod> dostavljeniPorizvodi { get; set; }
        public Dostavljac(string ime, string prezime, int id, string usernme, string pw, DateTime dR, DateTime dZ) : base(ime, prezime, id, dR, dZ)
        {
            uloga = "Dostavljac";
            username = usernme;
            password = pw;
        }

        //napraviti metode koje ce dodavati proizvod u ove dvije kolekcije
    }
}
