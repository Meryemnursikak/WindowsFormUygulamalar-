using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon
{
    public class Siparis
    {
        public Pizza Pizza { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public override string ToString()
        {
            string malzemeler = "";
            foreach (var item in Pizza.Malzemeler)
            {
                malzemeler += item + ",";
            }
            return Pizza.Ebati.Adi + " " + Pizza.Adi + " " + Pizza.Kenartip.Adi+","+malzemeler+","+Pizza.Tutar*Adet;

        }   
    }
}

