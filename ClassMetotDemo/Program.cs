using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri mus1 = new Musteri();
            mus1.Id = 101;
            mus1.adSoyad = "AliKoklu";
            mus1.yas = 22;
            mus1.ikametSehri = "Ankara";

            Musteri mus2 = new Musteri();
            mus2.Id = 102;
            mus2.adSoyad = "MahmutUnlu";
            mus2.yas = 45;
            mus2.ikametSehri = "Yozgat";

            Musteri mus3 = new Musteri();
            mus3.Id = 103;
            mus3.adSoyad = "DerinAslan";
            mus3.yas = 38;
            mus3.ikametSehri = "Kırıkkale";

            Musteri[] musteriler = new Musteri[] { mus1, mus2, mus3 };

            MusteriManager musteriManager = new MusteriManager();



            Console.WriteLine("Banka personel otomasyonuna hoşgeldiniz. Yapmak istediğiniz işlemi seçiniz :");

         

            string[] islemler = new string[] { "Müşteri listesini görüntülemek için G'ye basınız", "Müşteri eklemek için A'ya basınız", "Kayıtlı bir müşteriyi silmek için D'ye basınız" };
            foreach (var item in islemler)
            {
                Console.WriteLine(item);
            }

            string secim = Console.ReadLine();

            Console.WriteLine(secim);

            Musteri yeniMusteri = new Musteri();




            if (secim == "g")
            {
                foreach (var mus in musteriler)
                {
                    musteriManager.Listele(mus);
                }
            }

            else if (secim == "a")
            {
                musteriManager.Ekle(yeniMusteri);
            }

            else if (secim == "d")
            {
                musteriManager.Sil(yeniMusteri);
            }





        }
    }
}
