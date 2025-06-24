using System.Collections.Specialized;
using System.Collections;
using System.Text;

namespace Konu16CollectionsKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections-Koleksiyonlar");
          //  Ornek1();
          //  Ornek2();
          //  Ornek3();
              Ornek4();
        }
        static void Ornek1()
        {
          ArrayList arrayList = new();
            arrayList.Add(1); // arraylist e add metodu ile veri eklenir
            arrayList.Add(2);
            arrayList.Add(3);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);// listedeki elemanları ekrana yazdırır
            }
            Console.WriteLine();
            Console.WriteLine("arraylist ilk eleman :" + arrayList[0]); // lisetede indeksini verdiğimiz elemana ulasma
        }
        static void Ornek2()
        {
            ArrayList arrayList = new();
            arrayList.Add("istanbul"); // arraylist e add metodu ile veri eklenir
            arrayList.Add("ısparta");
            arrayList.Add("yalvaç");
            arrayList.Add("antalya");
            arrayList.Add("ankara");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);// listedeki elemanları ekrana yazdırır
            }
            Console.WriteLine();
            Console.WriteLine("arraylist ilk eleman :" + arrayList[0]); // lisetede indeksini verdiğimiz elemana ulasma
            Console.WriteLine();
            Console.WriteLine("arraylist de sıralama yapabiliriz");
            arrayList.Sort(); // arraylist deki verileri sıralar
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            arrayList.Reverse(); 
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek3()
        {
            int tamSayi = 32;
            double kesirli = 3.14;
            ArrayList arrayList = new();
            arrayList.Add("ankara");
            arrayList.Add(tamSayi);
            arrayList.Add(kesirli);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item); // arraylist teki elemanları ekrana yazdırır
            }
            Console.WriteLine();
            for (int i = 0; i < arrayList.Count; i++) // arraylist teki elemanları indeks ile ekrana yazdırır
            {
                Console.WriteLine(arrayList[i]);
            }
        }
        static void Ornek4()
        {
            var strings = new StringCollection(); // StringCollection sınıfından bir nesne oluşturulur
            strings.Add("Yalvaç"); 
            strings.Add("ısparta");
            strings.Add("bursa"); 
            strings.Add("muğla");
            Console.WriteLine("string collection");
            foreach (var item in strings) // StringCollection içindeki elemanlar ekrana yazdırılır
            {
                Console.WriteLine(item);
            }
        }
    }
}
