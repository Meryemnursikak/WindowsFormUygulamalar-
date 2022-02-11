using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._01._2022_WindowsFormUygulama
{
    public class Urun
    {
        public int id { get; set; }
        public string urunAdi { get; set; }
        public string urunResim { get; set; }
        public string Yazar { get; set; }
        public int stokAdet { get; set; }
        public string urunKategori { get; set; }
        public string aciklama { get; set; }

        public override string ToString()
        {
            return urunAdi;
        }
    }
}
