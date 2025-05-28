namespace Konu04KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("karar yapıları");

            /*Console.WriteLine("bir sayı giriniz");
            var sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0) // eğer sayı 0 dan büyükse
            {
                Console.WriteLine("sayı pozitif");
            }
            else if (sayi < 0) // eğer sayı 0 dan küçükse
            {
                Console.WriteLine("sayı negatif");
            }
            else
            {
                Console.WriteLine("sayı sıfır");
            }

            Console.WriteLine("kullanıcı adını giriniz");
            string kullaniciAdi = Console.ReadLine();

            Console.WriteLine("şifre giriniz");
            string sifre = Console.ReadLine();

            string veritabanındakikullanıcıadi = "admin";
            string veritabanındakisifre = "123456";

            if (kullaniciAdi == veritabanındakikullanıcıadi && sifre == veritabanındakisifre)
            {
                Console.WriteLine("giriş başarılı");            
            }
            else
            {
                Console.WriteLine("kullanıcı adı ve şifre hatalı");
            }

            int saat = DateTime.Now.Hour; // Şu anki saat bilgisini sistemden alı alır

            if (saat < 18) // eğer saat 18 den küçükse
            {
                Console.WriteLine("iyi günler. saat : " + saat);
            }
            
            else
            {
                Console.WriteLine("iyi akşamlar. saat : " + saat);
            }

            Console.WriteLine("ternary operatörü");

            Console.WriteLine((saat < 18) ? "iyigünler. saat :" + saat :" iyi akşamlar. saat : " + saat);
            */

            Console.WriteLine("switch case yapısı ile akış kontrolü");

            int ay = DateTime.Now.Month; // Şu anki ay bilgisini sistemden alır
            Console.WriteLine("bulunduğumuz ay : " + ay);
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış mevsimi");
                    Console.WriteLine();
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar mevsimi");
                    Console.WriteLine();
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz mevsimi");
                    Console.WriteLine();
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("sonbahar mevsimi");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("hata oluştu");
                    break;


            }


        }
    }
}