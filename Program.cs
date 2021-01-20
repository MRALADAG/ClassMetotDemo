using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "56426412674";
            musteri1.Adi = "Engin";
            musteri1.SoyAdi = "Demiroğ";
            musteri1.Adresi = "Diyarbakır";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "54563698762";
            musteri2.Adi = "Selçuk";
            musteri2.SoyAdi = "Yıldırım";
            musteri2.Adresi = "Bursa";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "48674526398";
            musteri3.Adi = "Necati";
            musteri3.SoyAdi = "Şaşmaz";
            musteri3.Adresi = "Elazığ";

            Musteri musteri4 = new Musteri();
            musteri4.Id = "48658126398";
            musteri4.Adi = "Erdal";
            musteri4.SoyAdi = "Öcal";
            musteri4.Adresi = "Şereflikoçhisar";

            Musteri musteri5 = new Musteri();
            musteri5.Id = "48658125966";
            musteri5.Adi = "Hamdi Can";
            musteri5.SoyAdi = "Koca";
            musteri5.Adresi = "Tarsus";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };
            Console.WriteLine("Müşteri bilgileri");
            Console.WriteLine("---------------------");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri T.C. Kimlik No: {0}", musteri.Id);
                Console.WriteLine("Müşteri Adı: {0}", musteri.Adi);
                Console.WriteLine("Müşteri Soy Adı: {0}", musteri.SoyAdi);
                Console.WriteLine("Müşteri Adresi: {0}", musteri.Adresi);
                Console.WriteLine("************************************");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriAdd(musteri1);
            musteriManager.MusteriAdd(musteri2);
            musteriManager.MusteriAdd(musteri3);
            musteriManager.MusteriAdd(musteri4);
            musteriManager.MusteriAdd(musteri5);

            Console.WriteLine("#########################################################################################");
            musteriManager.MusteriDel(musteri1);
            musteriManager.MusteriDel(musteri2);
            musteriManager.MusteriDel(musteri3);
            musteriManager.MusteriDel(musteri4);
            musteriManager.MusteriDel(musteri5);


        }
    }
}
