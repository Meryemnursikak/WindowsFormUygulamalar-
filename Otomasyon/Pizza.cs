using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon
{
    public class Pizza
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Tutar 
        {
            get 
            {
                decimal tutar = 0;
                tutar = ((decimal)Ebati.Carpan * Fiyat) + Kenartip.EkFiyat;
                return tutar; 
            }
        }
        public Ebat Ebati { get; set; }
        public KenarTipi Kenartip { get; set; }
        public List<string> Malzemeler { get; set; }

        public override string ToString()
        {
            return Adi;
        }

    }
}
