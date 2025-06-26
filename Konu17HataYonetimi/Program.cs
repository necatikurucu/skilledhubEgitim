using ClassLibrary1;

namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 17 Hata Yonetimi");
            Console.WriteLine();
            Console.WriteLine("kdv hesaplamak için fiyat giriniz : ");
            var sayi = Console.ReadLine();
            //KdvHesapla(int.Parse(sayi));
            try
            {
                KdvHesapla(int.Parse(sayi)); //kodları çalıştırmayı denme
            }
            catch (Exception hata) //exception a hata isminmi verdik bu bize oluşan hatayı verir
            {
                Console.WriteLine("hata oluştu lütfen sadece rakam giriniz");
                //  throw; // bu yine hata fırlatır
                // oluşan hatayı loglayabiliriz
                Console.WriteLine(hata.Message);
            }
            finally //her durumda çalışır
            {
                Console.WriteLine("try catch blogundan sonra her seferinde calışmasını istedigimiz bir işlem varsa bu blokta çalıstırabiliriz kullanımı zorunlu degildir");
                Console.WriteLine("bir sayı giriniz");
                var sayi2 = Console.ReadLine();
                KdvHesapla(double.Parse(sayi2));
            }
            Console.WriteLine();

            Category category = new Category();
            category.Name = "Elektronik";
            Console.WriteLine(category.Name);

            Console.WriteLine();

            Product product = new Product();
            product.Name = "oyun bilgisayarı";
            Console.WriteLine("ürün adi : ");
            Console.WriteLine(product.Name);

        }
        static void KdvHesapla(double fiyat)
        {
            Console.WriteLine("fiyat : " + fiyat);
            Console.WriteLine("kdv : " + (fiyat * 0.20));
            Console.WriteLine("kdv dahil toplam tutar : " + (fiyat + (fiyat * 0.20)));
        }
    }
}
