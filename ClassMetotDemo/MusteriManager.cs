using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri listeye eklendi.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " , " + musteri.adSoyad + " , " + musteri.yas + " , " + musteri.ikametSehri);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri listeden kaldırıldı.");
        }

    }
}
