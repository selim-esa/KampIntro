using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int sayi1 = 31;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar azaldı");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Dolar arttı");
            }

            else
            {
                Console.WriteLine("dolar sabit kaldı");
            }

            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Ayarlar butonu");
            }

            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi + sayi1);
        }
    }
}
