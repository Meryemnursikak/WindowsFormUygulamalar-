using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciEkrani_13._01._2022
{
    public class SanalDatabase
    {
       public static  List<Kullanici> Kullanicilar = new List<Kullanici>();

        static SanalDatabase()
        {
            Kullanicilar.Add(new Kullanici() { id = 1, kullaniciAdi = "admin", sifre = "admin",isim="Meryem Nur",soyisim="Şikak",aciklama="xxx" });
        }
    }
}
