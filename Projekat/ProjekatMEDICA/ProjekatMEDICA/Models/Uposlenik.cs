using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public class Uposlenik
    {
        public string _ime { get; set; }
        public virtual string uloga { get; set; }
        public virtual string username { get; set; }
        public virtual string password { get; set; }
        public string _prezime { get; set; }
        public int _id { get; set; }
        public DateTime _datumRodjenja { get; set; }
        public DateTime _datumZaposlenja { get; set; }
        public Uposlenik(string ime, string prezime, int id, DateTime dR, DateTime dZ)
        {
            this._ime = ime;
            this._prezime = prezime;
            this._id = id;
            this._datumZaposlenja = dZ;
            this._datumRodjenja = dR;
        }
    }
}
