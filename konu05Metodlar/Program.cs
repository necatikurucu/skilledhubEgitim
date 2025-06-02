namespace konu05Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("metodlar");
            Console.WriteLine();
            Console.Beep();
            

            Toplamayap(); // Metod çağrısı olmadan ekrana yazdırmaz
            Toplamayap(50, 8);
            Console.WriteLine("geriye değer döndüren metot :");
            int sonuc = Toplamayap(10, 20, 30 ); // metot çağrısı ile geriye değer döndürülür.
            Console.WriteLine("sonuç:" + sonuc);
            /*
            Console.WriteLine("lütfen mail adresini giriniz");
            var email =Console.ReadLine();
            if(mailgonder(email)== false)
            {
                Console.WriteLine("mail adresi boş geçilemez");
            }
            else
                Console.WriteLine("mail kabul edildi");
            */
            // KdvHesapla();

            MatematikselMetotlar();
        }
        static void Toplamayap()
        {
            Console.WriteLine(10 + 8);
        }
        static void Toplamayap(int sayi1, int sayi2)

        {
            // void olan metodlar geriye değer döndürmeyen metodlardır.
            // aynı isimde metotlar farklı parametrelerle kullanulırsa buna overloading - aşırı yükleme denir.
            // metot kullanımında kullanılan parametreler (sayi1 i sayi2) metodun kullanıldığı yerde metoda gönderilmek zorundadır , aksi halde program hata deni.
            Console.WriteLine("sonuç:" + (sayi1 + sayi2));

        }
        static int Toplamayap(int sayi1, int sayi2, int sayi3)
        {
            //geriye değer döndüren metodlarda metot isminin önüne metodun geriye döndüreceği veri türü yazılır.
            // metodun aldığı parametre ile geri dönüş veri türü farklı olabilir.aynı olmak zorunda değildir.
            // yani bir metot paramere olarak int alırken geriye string bool vb veri türü döndürebilir.

            return sayi1 + sayi2 + sayi3; // int olan metodlar geriye değer döndürür. return ile değer döndürülür
        }

        static bool mailgonder(string mailAdresi)
        {
            if (!string.IsNullOrWhiteSpace(mailAdresi)) ; //Eğer mail adresi değişkenine bir değer girilmişse yani mail adresi boş değilse
            {
                return true; // geriye true değer döndür
            }
            else 
                return false; // mail adresi değişkeni boşsa false döndür
        }
        static void KdvHesapla()
        {
            double fiyat, kdv, toplam;
            Console.WriteLine("ürün fiyatını giriniz");
            fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("kdv miktarını giriniz");
            var kdvmiktari = Convert.ToDouble(Console.ReadLine());
            kdv = fiyat * kdvmiktari / 100;
            toplam = kdv + fiyat;
            Console.WriteLine("ürün kdv tutarı :" + kdv +"TL");
            Console.WriteLine("kdv dahil fiyatı : " + toplam + "TL");
        }
        static void MatematikselMetotlar()
        {
            //belirli matematiksel işlemleri yapan bazı metotlar
            int max = Math.Max(10, 34); // x ve y sayılarının en büyüğünü tutar
            int min = Math.Min(8, 45); // x ve y sayılarının en küçüğünü tutar.

            double c = Math.Ceiling(12.67); // x sayısından büyük en küçük tam sayıyı tutar yukarı yuvarlama
            double d = Math.Floor(11.87); // x sayısından küçük en büyük tam sayıyı tutar aşağı yuvarlama
            Console.WriteLine("max : " + max + " min : " + min + " ceiling : " + c + " floor : " + d);

        }
    }
}

