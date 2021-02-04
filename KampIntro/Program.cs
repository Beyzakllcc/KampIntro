using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güveliği
            //Do not repeat yourself!!!!
            //Değer tutucu, alias 
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugün = 7.45;
            if (dolarDun > dolarBugün)
                Console.WriteLine("Azalış Butonu");
            else if (dolarDun < dolarBugün)
                Console.WriteLine("Artış Butonu");
            else
                Console.WriteLine("Değişmedi Butonu");
            if (sistemeGirişYapmismi == true)
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            else
                Console.WriteLine("Giriş Yap Butonu");
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
