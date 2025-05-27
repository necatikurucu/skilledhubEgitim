namespace Konu04KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("karar yapıları");

            Console.WriteLine("bir sayı giriniz");
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
        }
    }
}
