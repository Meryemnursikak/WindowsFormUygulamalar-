using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._01._2022_WindowsFormUygulama
{
    public static class SanalDatabase
    {
        public static List<Urun> urunler = new List<Urun>()
        { new Urun(){ id =1, urunAdi="Bir İdam Mahkumunun Son Günü",stokAdet=20,
            urunKategori="Roman",
            aciklama="Realist",
            Yazar="Victor Hugo",
            urunResim=@"C:\Users\403MERYEM_SABAH\Desktop\Meryem ders notları\r1.png" },

             new Urun(){ id =2, urunAdi="Meryem Nur'un Hayatı",stokAdet=1,
            urunKategori="Çok Satanlardan-Roman-",
            aciklama="Yaşamını sorgulayanlardan..",
            Yazar="Meryem Nur Şikak",
            urunResim=@"C:\Users\403MERYEM_SABAH\Desktop\Meryem ders notları\r1.png" },

            new Urun(){ id =2, urunAdi="Hatçegülün Suçu Ne?",stokAdet=1,
            urunKategori="Yok Satanlardan-Roman-",
            aciklama="Umutsuz Vaka..",
            Yazar="Hatice Deniz",
            urunResim=@"C:\Users\403MERYEM_SABAH\Desktop\Meryem ders notları\r1.png" },

         };

    }
}
