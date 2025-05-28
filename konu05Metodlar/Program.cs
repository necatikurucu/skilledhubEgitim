namespace konu05Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("metodlar");
            Toplamayap(); // Metod çağrısı olmadan ekrana yazdırmaz
            Toplamayap(50, 8);
            Console.WriteLine("geriye değer döndüren metot :");
            int sonuc = Toplamayap(10, 20, 30 ); // metot çağrısı ile geriye değer döndürülür.
            Console.WriteLine("sonuç:" + sonuc);
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
    }
}

