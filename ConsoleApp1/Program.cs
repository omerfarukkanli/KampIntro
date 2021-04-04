using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ternary Operatörü
            Console.Write("[1-10] arasında sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            string cevap = "";
            cevap += sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
            Console.WriteLine(cevap);

            // Coalescing Kullanımı
            Console.Write("Lütfen yaşınızı giriniz :");
            string yasiniz = Console.ReadLine();
            string sonuc = "";
            //Burada iki operatörü birarada kullanmış olduk 
            //Ternary kullanma amaçımız kullanıcı direkt boş geçerse stringlerde boş değer bir karakter olduğudan
            //Coalescing de bildiğiniz gibi null değer gelirse varsayılan değeri yazdırır.
            sonuc = (yasiniz == "" ? null : yasiniz) ?? "Boş geçildi.";
            Console.WriteLine("Yaşınız :" + sonuc);
        }
    }
}
