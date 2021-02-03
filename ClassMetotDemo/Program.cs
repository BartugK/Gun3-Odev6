using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriIsmi = "Mehmet Korkmaz";
            musteri1.MusteriYasi = 33;
            musteri1.MusteriId = 123456789;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriIsmi = "Ali Büyük";
            musteri2.MusteriYasi = 68;
            musteri2.MusteriId = 987654321;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriIsmi = "Yasemin Kartemiz";
            musteri3.MusteriYasi = 21;
            musteri3.MusteriId = 123789456;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            CustomerManager customerManager = new CustomerManager();


            customerManager.MusteriEkleme(musteri1);
            Console.WriteLine("------------------");
            customerManager.MusteriSilme(musteri2);
            Console.WriteLine("------------------");

            foreach (Musteri musteri in musteriler)
            {
                customerManager.MusteriListeleme(musteri);
            }






        }
    }
}
