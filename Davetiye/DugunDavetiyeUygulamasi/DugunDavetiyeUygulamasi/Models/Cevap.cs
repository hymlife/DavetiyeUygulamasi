using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DugunDavetiyeUygulamasi.Models
{
    public class Cevap
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public bool  DuguneGelicekmi { get; set; }

    }
}
