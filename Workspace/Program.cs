using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workspace
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            SelamVer(isim:"Ayşe");

            int sonuc = Topla(3, 5);
            Person person1 = new Person();
            person1.FirstName ="AYŞE";
            person1.LastName = "LEVENT";
            person1.NationalIdentitiy = 123;
            person1.DateOfBirthYear = 1999;

            PTTManager pttManager = new PTTManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();

        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc.ToString()) ;
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "selam";
            double tutar = 10000.2; //dbden gelir
            int sayi = 100;
            bool girisYapmisMi = false;


            Console.WriteLine(mesaj);
            Console.WriteLine(tutar);
            Console.WriteLine(sayi);
            Console.WriteLine(girisYapmisMi);
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




