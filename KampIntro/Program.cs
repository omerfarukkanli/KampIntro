using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Sisteme Gİriş Yapıldı");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);
            Console.WriteLine(sistemeGirisYapmisMi);
        }
    }
}
