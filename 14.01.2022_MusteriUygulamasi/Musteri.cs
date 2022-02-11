using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._01._2022_MusteriUygulamasi
{
    public class Musteri
    {
        public int Id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim;
        }
    }
}
