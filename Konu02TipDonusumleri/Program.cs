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

            Console.WriteLine("diğer tür dönüştürme yöntemleri");

            int tamSayi2 = 10;
            double kesirliSayi3 = 5.25;
            bool islemSonuc = true;

            Console.WriteLine("Lütfen bir sayı giriniz:");
            var girilenDeger = Console.ReadLine();
            Console.WriteLine("girilen değerin veri tipi :" + girilenDeger.GetType());

            var parsayi = int.Parse(girilenDeger);// int.Parse metodu kendisine verilen string değerin tırnaklarını kaldırarak in tipine çeviri

            Console.WriteLine("int.Parse : " + (int.Parse(girilenDeger) + tamSayi2));
            Console.WriteLine("double.Parse : " + (double.Parse(girilenDeger) + tamSayi2));
            Console.WriteLine("decimal.Parse : " + (decimal.Parse(girilenDeger) + tamSayi2));

            Console.WriteLine();

            Console.WriteLine("convert sınıfı metodlarıyla tip dönüştürme");
            Console.WriteLine(Convert.ToString(tamSayi2).GetType());
            Console.WriteLine(Convert.ToDouble(tamSayi2).GetType());
            Console.WriteLine(Convert.ToInt32(kesirliSayi2).GetType());
            Console.WriteLine(Convert.ToString(islemSonuc).GetType());

            object nesne = "123456";
            Console.WriteLine("nesnenin veri tipi : " + nesne.GetType());
            nesne = Convert.ToDecimal( nesne ); // nesne atrık decima türünde
            Console.WriteLine("nesnenin veri tipi :" + nesne.GetType());
            Console.WriteLine("nesnenin değeri : " + nesne);



        }
    }
}
