using System;

namespace konu06Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("diziler");   // dizi oluşturma
            int[] sayi;
            int[] ogrenciler = new int[6]; // ogrenciler isminde int veri tipi taşıyan  ve 7 elemandan oluşan bir dizi oluşturduk dizi boyutu artmaz azalmaz
                                           //dizilerde indis denilen bir yapı vardır  ve içine eklenecek elemanlar 0 dan başlar
            ogrenciler[0] = 100;           // diziye veri atama
            ogrenciler[1] = 200;
            ogrenciler[2] = 300;
            ogrenciler[3] = 400;
            ogrenciler[4] = 500;
            ogrenciler[5] = 600;

            Console.WriteLine("seçilen öğrenci no: " + ogrenciler[5]);
            ogrenciler[5] = 550; // dizinin 5. indisindeki veriyi 550 olarak güncelledik
            Console.WriteLine("seçilenm öğrenci no :" + ogrenciler[5]);
            //ogrenciler[6] = 666; // dizilere başlangıçta kaç elemandan oluşacağını tanımladıysak o sayının dışına çıktıgımızda hata alırız.

            Console.WriteLine();
            
            string[] isimler = new string[5];
            isimler[0] = "Ali";
            isimler[1] = "Ayşe";
            isimler[2] = "Mehmet";
            isimler[3] = "Fatma";
            isimler[4] = "Zeynep";
            
            Console.WriteLine("isimler[4]:"+ isimler[4]);
            int[] ogrenciler2 = { 100, 200, 300, 400, 500 };
            Console.WriteLine("seçilen öğrenci no: " + ogrenciler2[3]);
            ogrenciler2[3] = 550;
            Console.WriteLine("seçilen öğrenci no: " + ogrenciler2[3]);

            Console.WriteLine();

            string[] kategoriler = { "bilgisayar", "elektronik", "cep telefonu", "beyazeşya", "kitap" }; // diziye eklenecek kayıt sayısı belirsiz ise bu şekilde dizi tanımlayabiliriz.
            Console.WriteLine("kategoriler 1 :" + kategoriler[1]);
            kategoriler[1] = "aksesuar";
            Console.WriteLine("kategoriler 1 :" + kategoriler[1]);

            Console.WriteLine();

            string[] urunler = {"ürün 1", "ürün 2", "ürün 3"};
            Console.WriteLine(urunler[1]);
        }
    }
}
