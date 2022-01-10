using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "kokulu karpuz";

            Urun[] urunler = new Urun[]
            {
                urun1 , urun2
            };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi + urun.Fiyati + urun.Aciklama);
                Console.WriteLine("--------------");
            }


            Console.WriteLine("-----------metodlar----------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
         
           
        }
    }
}
