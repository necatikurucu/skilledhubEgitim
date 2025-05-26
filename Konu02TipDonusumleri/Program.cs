namespace Konu02TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Dönüşümleri");
            // Implicit Casting - otomatik dönüşüm
            // char -> int -> long -> float -> double
            // Explicit Casting - manuel
            // double -> float -> long -> int -> char

            //Implicit Casting daha küçük boyutlu bir türü daha büyük boyut türüne geçirirken otomatik olarak yapılır
            Console.WriteLine("Implicit Casting");
            int sayi = 9;
            double kesirliSayi = sayi; // int den double otomatik dönüşüm

            Console.WriteLine(sayi);   // çıktı 9
            Console.WriteLine(kesirliSayi);  // çıktı 9

            //Explicit Castin türü değerin önüne parantez içine alarak manuel yapılmalıdır
            Console.WriteLine("Explicit Casting");
            double kesirliSayi2 = 9.78;
            int tamSayi = (int)kesirliSayi2; // manuel dönüştürme  : double dan in e
            Console.WriteLine("kesirliSayi2:" + kesirliSayi2);
            Console.WriteLine("tamSayi:" + tamSayi);
            Console.WriteLine();

        }
    }
}
