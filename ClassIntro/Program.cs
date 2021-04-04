using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Ömer Faruk Kanlı";
            kurs1.İzlenmeOrani = 13;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Sali Kanlı";
            kurs2.İzlenmeOrani = 40;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "ptyhon";
            kurs3.Egitmen = "Mehmet Kanlı";
            kurs3.İzlenmeOrani = 65;

            //Console.WriteLine(kurs1.KursAdi + " :" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}
