using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriAdd(Musteri musteri)
        {
            Console.WriteLine("{0} nolu {1} {2} adlı müşteri sisteme başarıyla eklenmiştir.", musteri.Id, musteri.Adi, musteri.SoyAdi);
        }

        public void MusteriDel(Musteri musteri)
        {
            Console.WriteLine("{0} nolu {1} {2} adlı müşteri hesabı bankamız hesaplarından kaldırılmıştır.", musteri.Id, musteri.Adi, musteri.SoyAdi);
            Console.WriteLine("Sayın {0} {1} Bilgilerinize sunar, iyi günler dileriz.", musteri.Adi, musteri.SoyAdi);
        }
    }
}
