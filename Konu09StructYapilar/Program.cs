using System.Collections.Specialized;

namespace Konu09StructYapilar
{
    public struct Yapi
    {
        //public string Ad = "ali";// struct kullanımda classdan farklı olarak ögelere başlangıç değeri atanmaz

        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("Yapı içindeki metot çalıştı");
        }
    }
    internal class Program
    {
        struct Kimlik
        {
            // kimlik struct ın değişkenleri
            public string ad;
            public string soyad;
            public int yas;
            public string dogumyeri;
            public struct Adres
            {
                public int Id { get; set; }
                public int KapiNo { get; set; }
                public string Sehir { get; set; }
                public string Ilce { get; set; }
                public string AcikAdres { get; set; }
            }
            internal string Birlestir(string ad, string soyad)
            {
                return ad + " " + soyad.ToUpper();
            }
            public void ToplamiYaz(int sayi1, int sayi2)
            {
                Console.WriteLine("sayı 1 ve satı 2 nin toplamı");
                Console.WriteLine(sayi1 + sayi2);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Struct Yapılar");

            Console.WriteLine();

            Yapi ilkyapi = new Yapi();
            ilkyapi.metin = "yapı metni";
            ilkyapi.sayi = 10;
            ilkyapi.Metot(); // yapının metodu çağrıldı
            Console.WriteLine();
            Console.WriteLine(ilkyapi.metin);

            //struıct ile yapı oluşturma
            Kimlik kimlik = new Kimlik();
            kimlik.ad = "ahmet";
            kimlik.soyad = "karaca";
            kimlik.dogumyeri = "İstanbul";
            kimlik.yas = 30;

            Console.WriteLine();

            // struct ile kurulan yapıyı kullanma
            Console.WriteLine("kimlik bilgileri ;");
            Console.WriteLine("ad : {0}, soyad : {1}", kimlik.ad, kimlik.soyad);
            Console.WriteLine("doğum yeri : " + kimlik.dogumyeri);
            Console.WriteLine("yaşı :" + kimlik.yas);

            Console.WriteLine();

            Console.WriteLine(kimlik.Birlestir("ali ihsan", "aras"));
            kimlik.ToplamiYaz(10, 20);

            Kimlik.Adres adres = new Kimlik.Adres();
            adres.AcikAdres = "Çiçek sokak";
            adres.Ilce = "Kadıköy";
            adres.Sehir = "İstanbul";

            Console.WriteLine();
            Console.WriteLine("kullanıcı adres bilgileri");

            Console.WriteLine(adres.AcikAdres);
            Console.WriteLine(adres.Ilce);
            Console.WriteLine(adres.Sehir);

        }
    }
}