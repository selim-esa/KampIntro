﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi : " + urun.Adi + " " + urun.Aciklama);
        }

        public void Ekle2(string urunAdi , string Aciklama , double fiyat)
        {
            Console.WriteLine("sepete eklendi : ");

        }
    }
}
