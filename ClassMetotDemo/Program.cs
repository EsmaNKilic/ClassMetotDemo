using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.Id = "nurikilicc";
            m1.Ad = "Nuri";
            m1.Soyad = "KILIÇ";
            m1.KartNo = 12345678910;

            Musteri m2 = new Musteri();
            m2.Id = "songulkilicc";
            m2.Ad = "Songül";
            m2.Soyad = "KILIÇ";
            m2.KartNo = 12131415161;

            Musteri m3 = new Musteri();
            m3.Id = "esrakilicc";
            m3.Ad = "Esra";
            m3.Soyad = "KILIÇ";
            m3.KartNo = 71819202122;

            Musteri m4 = new Musteri();
            m4.Id = "nuresmakilicc";
            m4.Ad = "Esma Nur";
            m4.Soyad = "KILIÇ";
            m4.KartNo = 23242526272;

            Musteri m5 = new Musteri();
            m5.Id = "ernesthemingway";
            m5.Ad = "Ernest";
            m5.Soyad = "HEMİNGWAY";
            m5.KartNo = 82930313233;


            Console.WriteLine("\n---------------------------------LİSTELENENLER---------------------------------");
            Musteri[] musteriler = new Musteri[] { m1, m2, m3, m4, m5 };

            foreach (var Musteri in musteriler)
            {
                Console.WriteLine(Musteri.KartNo + " " + Musteri.Ad + " " + Musteri.Soyad); 
            } 

                      
            Console.WriteLine("\n\n---------------------------------EKLENENLER---------------------------------");
            MusteriManager musteri = new MusteriManager();
            musteri.Ekle(m1);
            musteri.Ekle(m2);
            musteri.Ekle(m3);
            musteri.Ekle(m4);
            musteri.Ekle(m5);


            Console.WriteLine("\n\n---------------------------------SİLİNENLER---------------------------------");
            musteri.Sil(m5);
        }
    }
}
