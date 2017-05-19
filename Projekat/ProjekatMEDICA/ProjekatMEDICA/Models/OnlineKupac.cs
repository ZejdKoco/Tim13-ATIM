using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public class OnlineKupac : Kupac
    {
        string ime, prezime, id, spol, username, password;
        DateTime datumRodjenja;
        byte[] slika;
        double stanjeRacuna;

        public OnlineKupac()
        {
        }

        OnlineKupac(string ime,string prez, string spol, DateTime datRodj, string usern, string pw)
        {
            Ime = ime;
            Prezime = prez;
            Spol = spol;
            DatumRodjenja = datRodj;
            Username = usern;
            Password = pw;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Id { get => id; set => id = value; }
        public string Spol { get => spol; set => spol = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public byte[] Slika { get => slika; set => slika = value; }
        public double StanjeRacuna { get => stanjeRacuna; set => stanjeRacuna = value; }
    }

    
}
