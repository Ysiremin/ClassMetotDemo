using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Name +" "+ musteri.SecondName + ", kaydınız tamamlanmıştır. Müşteri Id: " + musteri.Id);
        }

        public void Del(Musteri musteri)
        {
            Console.WriteLine(musteri.Name +" "+ musteri.SecondName + "'ye ait müşteri kaydı silinmiştir.");
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Name +" "+ musteri.SecondName + ", kaydınız güncellenmiştir. Müşteri Id: " + musteri.Id);
        }
        public void List()
        {
            Console.WriteLine("Müşteri listesi görüntülendi.");
        }
    }
}
