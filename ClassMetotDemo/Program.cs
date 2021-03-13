using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "01";
            musteri1.Name = "Yasir Emin";
            musteri1.SecondName = "ÇİFTÇİ";
            musteri1.PhoneNumber= "05123456789";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "02";
            musteri2.Name = "Ahmet";
            musteri2.SecondName = "KARA";
            musteri2.PhoneNumber = "05109238192";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "03";
            musteri3.Name = "Ayşe";
            musteri3.SecondName = "YILDIZ";
            musteri3.PhoneNumber = "052492432383";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Update(musteri1);
            musteriManager.Del(musteri3);
            musteriManager.List();

        }
    }
}
