using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ProjekatMEDICA.Models
{
    public class Proizvod
    {
        string naziv, id, opis, proizvodjac;
        byte[] slika;
        double cijena;
        //barcode

        Proizvod(string naz, string id, string proizv, string opis, double cijena)
        {
            Naziv = naz;
            Id = id;
            Proizvodjac = proizv;
            Opis = opis;
            Cijena = cijena;
        }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Opis { get => opis; set => opis = value; }
        public string Proizvodjac { get => proizvodjac; set => proizvodjac = value; }
        public string Id { get => id; set => id = value; }
        public byte[] Slika { get => slika; set => slika = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        
    }
}
