using Business.Concrete;
using Emtities.Concrete;

namespace MaskeTakip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //degiskenler();
            SelamVer("Engin");
            SelamVer("Ahmet");
            SelamVer();
            Console.WriteLine("Sonuç: "+Topla());
            Console.WriteLine("---------------");
            //Diziler - Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Murat";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            Console.WriteLine("---------------");

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Murat";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            Console.WriteLine("---------------");

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Çankırı", "Yozgat", "Bursa" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Console.WriteLine("---------------");

            Person person1 = new Person();
            person1.FirstName = "Engin";

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine("---------------");

            List<string> yenisehirler1 = new List<string> { "Gazze", "El-Halil", "Şifa" };
            yenisehirler1.Add("Batı Şeria");
            foreach (string sehir in yenisehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttMenager pttMenager = new PttMenager(new ForeignerMenager());
            pttMenager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba "+isim);
        }

        static int Topla(int sayi1=5,int sayi2=8)
        {
            int sonuc=sayi1 + sayi2;
            return sonuc;
        }
        private static void degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 10000;
            int sayi = 100;
            bool girisYapmısMi = false;

            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
