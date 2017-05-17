using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMEDICA.Models
{
    public class LiveKupac:Kupac
    {
        string recept;
        LiveKupac(string recept)
        {
            Recept = recept;
        }
        
        public string Recept { get => recept; set => recept = value; }
    }
}
