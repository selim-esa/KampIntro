using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursunEgitmeni = "selim esa";
            kurs1.İzlenmeOrani = 45;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.KursunEgitmeni = "muharrem esa";
            kurs2.İzlenmeOrani = 55;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "python";
            kurs3.KursunEgitmeni = "rıza türedi";
            kurs3.İzlenmeOrani = 85;

            //Console.WriteLine(kurs1.KursAdi+ " " + kurs1.KursunEgitmeni+ " " + kurs1.İzlenmeOrani);

            kurs[] kurslar = new kurs[]
            { kurs1, kurs2 , kurs3};
            foreach (var kurs in kurslar)

            {
                Console.WriteLine(kurs.KursAdi + kurs.KursunEgitmeni + kurs.İzlenmeOrani);
            }
        }

    }


    class kurs
    {
        public string KursAdi { get; set; }

        public string KursunEgitmeni { get; set; }

        public int İzlenmeOrani { get; set; }
    }
}
