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
            //  Ornek4();
            //  Ornek5();
            //  Ornek6();
            //  Ornek7();
            //  Ornek8();
            //  StringBuilderKullanimi();
            ListKullanimi();
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
            // strings.Add(32); // stgring dısında bir veri eklenemez, hata verir
            Console.WriteLine("string collection");
            foreach (var item in strings) // StringCollection içindeki elemanlar ekrana yazdırılır
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek5()
        {
            var dictionary = new StringDictionary();
            dictionary.Add("18", "Yalvaç");
            dictionary.Add("32", "ısparta");
            dictionary.Add("16", "bursa");
            dictionary.Add("45", "muğla");
            dictionary.Add("38", "kayseri");
            Console.WriteLine();
            Console.WriteLine("string dictionary");
            Console.WriteLine("dictionary 18 :" + dictionary["18"]);
            Console.WriteLine();
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("string dictionary keys");
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("string dictionary values");
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek6()
        {
            Stack stack = new(); // stack sınıfı programlamada LIFO (Last In First Out) mantığı ile çalışır son giren ilk çıkar
            // strack.Add(); stack de listeye add metoduyla ekleme yapılmaz.
            stack.Push("Yalvaç");
            stack.Push("ısparta");
            stack.Push("bursa");
            stack.Push("muğla");
            stack.Push("32");
            stack.Push("07");
            Console.WriteLine("stack");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop()); // stackte nesneler üst üste konulmui gibidir en son yazılan en üstte olur 
            }
        }
        static void Ornek7()
        {
            Queue queue = new(); // queue sınıfı programlamada FIFO (First In First Out) mantığı ile çalışır ilk giren ilk çıkar
            queue.Enqueue("gelincik");
            queue.Enqueue("papatya");
            queue.Enqueue("menekşe");
            queue.Enqueue(15);  // obje aldığı için her türlü veriyi kabul eder
            queue.Enqueue("32");
            queue.Enqueue("07");
            Console.WriteLine("queue");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
        static void Ornek8()
        {
            Dictionary<string, string> dictionary = new(); // hangi veri tipinden oluşacağını bizim belirlediğimiz liste sistemi
            dictionary.Add("book", "kitap");
            dictionary.Add("32", "Isparta");
            dictionary.Add("16", "Bursa");
            Console.WriteLine(dictionary["book"]);

            Console.WriteLine();

            Dictionary<int, string> dictionary2 = new();
            dictionary2.Add(18, "Yalvaç");
            dictionary2.Add(32, "Isparta");
            dictionary2.Add(16, "Bursa");

            Console.WriteLine();

            Console.WriteLine("dictionary2 values");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("dictionary2 keys");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine();
            Console.WriteLine("dictionary2 keys values");
            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
        static void StringBuilderKullanimi()
        {
            Console.WriteLine("string builder kullanımı");
            var sb = new StringBuilder();
            sb.Append(1);
            sb.Append(8);

            Console.WriteLine("sb : " + sb.ToString());

            Console.WriteLine();

            StringBuilder sb2 = new();
            sb2.Append("Yalvaç");
            sb2.Append(" Isparta");
            sb2.Append(" Antalya");
            Console.WriteLine("sb2 : " + sb2.ToString());

            Console.WriteLine();

            StringBuilder sb3 = new();
            sb3.Append("Yalvaç");
            sb3.Append(Environment.NewLine);
            sb3.Append(" Isparta");
            sb3.Append(Environment.NewLine);
            sb3.Append(" Antalya");
            Console.WriteLine("sb3 : " + sb3.ToString());

            Console.WriteLine();

            StringBuilder sb4 = new();
            sb4.AppendLine("Yalvaç");
            sb4.AppendLine(" Isparta");
            sb4.AppendLine(" Antalya");
            Console.WriteLine("sb4 : " + sb4.ToString());
        }
        static void ListKullanimi()
        {
            List<string> sehirler = new();
            sehirler.Add("Yalvaç");
            sehirler.Add("Isparta 32");
            sehirler.Add("Antalya");
            sehirler.Add("Ankara");
            Console.WriteLine("Sehirler: ");
            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            List<User> users = new();
            users.Add(new User
            {
                Id = 1,
                Name = "Ahmet",
                Password = "123"

            });
            users.Add(new User
            {
                Id = 2,
                Name = "Mehmet",
                Password = "456"
            });
            Console.WriteLine("kullanıcılar: ");
            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
            }

            List<User> kullanicilar = new()
            {
                new User
                {
                    Id = 3,
                    Name = "Ayşe",
                    Password = "789"
                },
                new User
                {
                    Id = 4,
                    Name = "Fatma",
                    Password = "1011"
                }
            };
            Console.WriteLine();
            Console.WriteLine("kullanıcılar 2: ");
            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine(kullanici.Name);
            }
            var yeniKullanici = new User()
            {
                Id = 5,
                Name = "Ali",
                Password = "1213"
            };
            Console.WriteLine("kullanıcılar listesinde yeni kullanıcı var mı "+kullanicilar.Contains(yeniKullanici));
            kullanicilar.Add(yeniKullanici); // listeye yeni kullanıcı eklenir
            Console.WriteLine("kullanıcılar listesinde yeni kullanıcı var mı " + kullanicilar.Contains(yeniKullanici));

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            Console.WriteLine("listedeki kayıt sayısı : " + kullanicilar.Count);

            Console.WriteLine();
            kullanicilar.Insert(0, yeniKullanici); // insert metodunu kullanarak eklersek listede sırasını kendimiz belirleyebiliriz

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Name);
            }
        }

    }

}
