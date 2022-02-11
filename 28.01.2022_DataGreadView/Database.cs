using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._01._2022_DataGreadView
{
    public class Database
    {
        public List<Musteri> musterilistesi = new List<Musteri>();
        public List<Musteri> musterilistele()
        {
            for (int i = 1; i < 101; i++)
            {
                Musteri m = new Musteri();
                m.id = i;
                m.isim= FakeData.NameData.GetFirstName();
                m.soyisim= FakeData.NameData.GetSurname();
                m.tamAdi = FakeData.NameData.GetFullName();
                m.il = FakeData.PlaceData.GetState();
                m.ilce = FakeData.PlaceData.GetCity();
                m.email = FakeData.NetworkData.GetEmail();
                m.telno = FakeData.PhoneNumberData.GetPhoneNumber();
                m.adres = FakeData.PlaceData.GetAddress();

                //müşteriyi müşteri listesine attık.
                musterilistesi.Add(m);
            }
            return musterilistesi;
        }
    }
}
