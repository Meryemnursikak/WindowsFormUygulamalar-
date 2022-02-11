using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._01._2022_MusteriUygulamasi
{
    public class SanalDatabase
    {
       public static List<Musteri> db = new List<Musteri>();

        //sadece bir defa new list oluştursun diye static olarak yazdık içine.
        static SanalDatabase()
        {
            db = new List<Musteri>();
        }
    }
}
