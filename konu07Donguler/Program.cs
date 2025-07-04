﻿namespace konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DÖNGÜLER");

            Console.WriteLine("1-For dömgüsü");
            for (int i = 0; i < 5; i++) //i değişkeni oluşturur 0 olarak atar ve i değeri 5 den küçük olana kadar i değerini i++ ile 1 artırır
            {
                Console.WriteLine("i değişkeninin değeri {0}", i);
            }

            Console.WriteLine();

            Console.WriteLine("2-While döngüsü");

            int j = 3; // değişken dışarda tanıomlanıyor
            while (j < 8) //j değişkeni 0 olarak atar ve j değeri 5 den küçük olana kadar döngü devam eder
            {
                Console.WriteLine("while sayı {0}  değeri ", j);
                
                j++; //j değerini 1 artırır
            }

            Console.WriteLine();

            Console.WriteLine("3-Do While döngüsü");

            int toplam = 7;
            do
            {
                Console.WriteLine("toplamın değeri : "+toplam);
                toplam++; //toplam değişkenini 1 artırır

            }
            while (toplam<12);

            Console.WriteLine();

            string[] kategoriler = { "bilgisayar", "elektronik", "cep telefonu"};

            Console.WriteLine("4-Foreach döngüsü");
            Console.WriteLine("kategoriler");
            foreach (var kategori in kategoriler) // kategori dizin (ögesi) kategoriler dizisindeki her bir elemana karşılık geliyor            {
            {
                Console.WriteLine(kategori);   
            }

            Console.WriteLine();

            // iç içe döngü kullanımı

            string[] urunler = { "ürün 1", "ürün 2", "ürün 3" };
            foreach (var kategori in kategoriler)
            {
                Console.WriteLine(kategori);
                foreach (var urun in urunler) // her kategori için ürünler dizisindeki her bir elemana karşılık geliyor
                {
                    Console.WriteLine(urun);
                }
            }
                Console.WriteLine();

                Console.WriteLine("iç içe for döngüsü");
                for (int i = 0; i < 5; i++) // i değişkeni 0 olarak atar ve i değeri 5 den küçük olana kadar döngü devam eder
                {
                    Console.WriteLine($"i değişkeninin değeri {i}");

                    for (int k = 0; k < 3; k++) // k değişkeni 0 olarak atar ve j değeri 3 den küçük olana kadar döngü devam eder
                    {
                        Console.WriteLine($"\t k değişkeninin değeri {k}");
                    }
                }
            
        }
    }
}
