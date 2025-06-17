using System.Collections.Specialized;

namespace Konu10StringSinifi
{Konu10StringSinifi
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KOnu 10 String Sınıfı");
            Console.WriteLine();
            string degisken;
            char karakter = 'F'; // char değişkeni tek karakter alır.
            string metinlericin = "metinler için mi kullanıyorduk?";
            Console.WriteLine(metinlericin);
            Console.WriteLine();
            // Ornek1();
            //StringMetotlari();
            SplitMetodu();
        }
        static void Ornek1()
        {
            string birMetin = "ankara başkenttir";
            string birsayi = "12345";
            System.String birTarih = "01.01.2023";
            string kod = "//55456dfgd\n";// buradaki\n kodun yeni satıra geçmesini sağlar. enter görevi görür ve kendinden sonra gelecek metni alt satıra alır.
            Console.WriteLine(birMetin.GetType());
            Console.WriteLine(birsayi.GetType());
            Console.WriteLine(birTarih.GetType());
            Console.WriteLine(kod);

            Console.WriteLine();

            string s = "ferdi tayfur";
            Console.WriteLine("for döngüsü çıktısı");
            for (int i = 0; i < s.Length; i++) // stringin uzunluğunu verir. yani karakter sayısını verir.
            {
                Console.WriteLine("s[" + i + "] = " + s[i]); // stringin karakterlerine erişim sağlar.
            }
            Console.WriteLine("for döngüsü çıktısı");
            foreach (var item in s)
            {
                Console.WriteLine(item);

            }
        }
        static void StringMetotlari()
        {
            string metin = "stringin bir çok metodu vardır.";
            Console.WriteLine("metin in karakter sayısı(metin.Lenght) :" + metin.Length); // metin değişkeninin karakter sayısını verir.
            var klon = metin.Clone(); // metin değişkeninin bir kopyasını oluşturur. klon değişkenine atar.
            Console.WriteLine("metin klonu : " + klon);
            metin = "my nAmE iS aLi";
            Console.WriteLine(metin + " EndsWith i : " + metin.EndsWith("i"));
            Console.WriteLine(metin + " EndsWith r : " + metin.EndsWith("r"));

            Console.WriteLine();

            Console.WriteLine(metin + " StartsWith s : " + metin.StartsWith("s"));
            Console.WriteLine(metin + " StartsWith m : " + metin.StartsWith("m"));
            Console.WriteLine(metin + " StartsWith M : " + metin.StartsWith("M"));

            Console.WriteLine();

            Console.WriteLine(metin + " IndexOf name : " + metin.IndexOf("name"));
            Console.WriteLine(metin + " IndexOf Name : " + metin.IndexOf("Name"));

            Console.WriteLine(metin + " LastIndexOf i : " + metin.LastIndexOf("i"));

            Console.WriteLine();

            Console.WriteLine(metin + " Insert 0 : " + metin.Insert(0, "merhaba : "));// metin değişkeninin başına "merhaba : " ifadesini ekler. metnin değeri değişmez
            Console.WriteLine(metin);

            Console.WriteLine();

            Console.WriteLine(metin + " Substring 2 : " + metin.Substring(2));
            Console.WriteLine(metin + " Substring 2,5 : " + metin.Substring(2, 5));

            Console.WriteLine();

            Console.WriteLine(metin + " ToLower : " + metin.ToLower());
            Console.WriteLine(metin + " ToUpper : " + metin.ToUpper());
            Console.WriteLine(metin + " metin.ToLower().Replace : " + metin.ToLower().Replace(" ", "-"));

            Console.WriteLine();

            Console.WriteLine(metin + " Remove : " + metin.Remove(2));
            Console.WriteLine(metin + " Remove : " + metin.Remove(2, 6));



        }
        static void SplitMetodu()
        {
            string sehirler = "Isparta,Yalvaç,Ankara,Konya,İstanbul,Gazze";
            string[] sehirlerArray = sehirler.Split(','); // virgülle ayırır ve diziye atar.
            Console.WriteLine("4. şehir : " + sehirlerArray[3]);
            foreach (var item in sehirlerArray)
            {
                Console.WriteLine("Şehir : " + item);
            }
            Console.WriteLine();

            Console.WriteLine("tarih parçalama");
            var tarih = DateTime.Now.ToShortDateString(); // kısa tarih formatında alır.
            Console.WriteLine("tarih : "+tarih);
            var tarihparcalari = tarih.Split('.'); // noktaya göre ayırır.
            var gun = tarihparcalari[0]; // gün
            var ay = tarihparcalari[1]; // ay 
            var yil = tarihparcalari[2]; // yıl
            Console.WriteLine(" gun : "+gun + "\n ay : "+ay+"\n yıl : "+yil);

        }
    }
}
