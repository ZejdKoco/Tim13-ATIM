using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public class DefaultPodaci
    {
        public static List<OnlineKupac> _kupci = new List<OnlineKupac>()
        {
            new OnlineKupac() //string ime,string prez, string spol, DateTime datRodj, string usern, string pw
            {
                Ime = "Amila",
                Prezime = "Karsic",
                Spol = "zensko",
                DatumRodjenja = DateTime.Now,
                Username = "amila1",
                Password = "amila1"
            },
            new OnlineKupac()
            {
                Ime = "Amila",
                Prezime = "Japalak",
                Spol = "zensko",
                DatumRodjenja = DateTime.Now,
                Username = "amila2",
                Password = "amila2"
            },
            new OnlineKupac()
            {
                Ime = "Zejd",
                Prezime = "Koco",
                Spol = "musko",
                DatumRodjenja = DateTime.Now,
                Username = "zejd",
                Password = "zejd"
            }
        };

        public static List<Proizvod> _proizvodiZaDostaviti = new List<Proizvod>()
        {
            new Proizvod("Dostaviti", "4", "Proizvodjac", "Opis", 2.5, 3, "kOMENTAR")
        };

        public static List<Kupac> _nepotvrdjeniKupci = new List<Kupac>()
        {
            new OnlineKupac()
            {
                Ime = "Nepotvrdjeni",
                Prezime = "Nepotvrdjeni",
                Spol = "zensko",
                DatumRodjenja = DateTime.Now,
                Username = "amila2",
                Password = "amila2"
            }
        };
        

        public static IList<OnlineKupac> dajSveKupce()
        {
            return _kupci;
        }

        public static List<Uposlenik> _uposlenici = new List<Uposlenik>()
        {
            new Menadzer("Menadzer", "Menadzer",1, "men", DateTime.Now, DateTime.Now),
            new Prodavac("Prodavac", "Prodavac", 2, "prod", "prod", DateTime.Now, DateTime.Now),
            new Dostavljac("Dostavljac" , "Dostavljac", 3, "dost", "dost", DateTime.Now, DateTime.Now)
        };

        public DefaultPodaci()
        {
        }



        public static IList<Uposlenik> dajSveUposlenike()
        {
            return _uposlenici;
        }
        
        public static Uposlenik nadjiMenadzera(string id)
        {
            return _uposlenici.Where(u => u.username.Equals(id) && u.uloga.Equals("Menadzer")).FirstOrDefault();
            
        }



        public static ObservableCollection<Proizvod> _proizvodi = new ObservableCollection<Proizvod>()
        {
            //string naz, string id, string proizv, string opis, double cijena, string komentar
            new Proizvod("Aspirin", "1", "Proizvodjac", "Opis", 2.5,1, "Komentar"),
            new Proizvod("Kafetin", "2", "Proizvodjac", "Opis", 12,3, "Komentar")
        };

        public static ObservableCollection<Proizvod> dajSveProizvode()
        {
            return _proizvodi;
        }

        public static Uposlenik nadjiProdavaca(string username, string password)
        {
            return _uposlenici.Where(u => u.username.Equals(username) && u.password.Equals(password) && u.uloga.Equals("Prodavac")).FirstOrDefault();
        }
        public static Proizvod nadjiProizvod(string id)
        {
            return _proizvodi.Where(i => i.Naziv.Equals(id) || i.Id.Equals(id)).FirstOrDefault();
        }

        public static Kupac nadjiKupca(string username, string password)
        {
            return _kupci.Where(u => u.Username.Equals(username) && u.Password.Equals(password)).FirstOrDefault();
        }
        public static OnlineKupac nadjiKupca(string username)
        {
            return _kupci.Where(u => u.Username.Equals(username)).FirstOrDefault();
        }
        public static Uposlenik nadjiUposlenika(string username)
        {
            return _uposlenici.Where(u => u._prezime.Equals(username)).FirstOrDefault();
        }
    }

}

