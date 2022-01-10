using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {
                "yazılım geliştirici kursu " , "pyhton kursu" , "java kursu" ,"c# kursu"

            };
            foreach (var kurs1 in kurslar)
            {
                Console.WriteLine(kurs1); 
            }

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]) ;
            }

           
        }
    }
}
