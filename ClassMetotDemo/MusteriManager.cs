using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "kullanıcı adlı" + " " + musteri.Ad + " " + musteri.Soyad + " " + "eklenmiştir." );
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Listelendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "kullanıcı adlı " + " " + musteri.Ad + " " + musteri.Soyad + " " + "müşteri silinmiştir.");
        }
    }
}
