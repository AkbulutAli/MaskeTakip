using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            //Vatandas vatandas1 = new Vatandas();

     

            Selamver("engin");
            Selamver("ahmet");
            Selamver("ayşe");
            Selamver();

            int sonuc = Topla(6,58);

            //Diziler / Arrays

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Ali";
            ogrenciler[1] = "ibrahim";
            ogrenciler[2] = "Cagri";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler1 = sehirler2;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Ali Sefa";
            person1.LastName = "AKBULUT";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Engin";

            foreach (var sehir in sehirler1)
            {
                Console.Write(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir"};
            yeniSehirler1.Add("Adana");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void Selamver(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5 , int sayi2 =10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: "+ sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;// db den gelir
            int sayi = 100;
            bool girişYapmisMi = false;

            string ad = "Ali Sefa";
            string soyad = "AKBULUT";
            int dogumYili = 1999;
            long tcNo = 1234567890;


            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }

    //pascal casing
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set;}
        public long TcNo { get; set; }
    }
}