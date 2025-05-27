using System.Runtime.CompilerServices;

namespace Konu03Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 03 Operatörler");
            Console.WriteLine("1-Aritmetik Operratörler");
            int sayi1 = 3;
            int sayi2 = 4;
            int sayi3 = 5;
            Console.WriteLine();
            Console.WriteLine($"Sayılar sayi1 : {sayi1} sayi2: {sayi2} sayi3: {sayi3}"); // string tırnağının önüne $ işateri koyarak string interpolasyonu yapıyoruz

            Console.WriteLine("1234" + sayi3); // string ile int arasında + işlemi yapıldığında int stringe dönüştürülür ve string olarak birleştirilir

            Console.WriteLine();
            Console.WriteLine("hesaplama işlemleri:");
            Console.WriteLine("sayi1 + sayi2 :" + (sayi1 + sayi2));
            Console.WriteLine("sayi1 - sayi2 :" + (sayi1 - sayi2));
            Console.WriteLine("sayi1 * sayi2 :" + (sayi1 * sayi2));
            Console.WriteLine("sayi1 / sayi2 :" + (sayi1 / sayi2));
            Console.WriteLine("sayi1 % sayi2 :" + (sayi1 % sayi2));

            Console.WriteLine();

            Console.WriteLine("artırım ve azaltım operatörleri");
            sayi2++; // bir değişkendeki değeri 1 artırmak için
            Console.WriteLine("sayi2:"+ sayi2);
            sayi2--; // bir değişkendeki değeri 1 azaltmak için
            Console.WriteLine("sayi2:"+ sayi2);

            Console.WriteLine("atama operatörleri");
            Console.WriteLine($"Sayılar sayi1 : {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
            Console.WriteLine("sayi1 += sayi2 :" + (sayi1 += sayi2));
            Console.WriteLine("sayi1 -= sayi2 :" + (sayi1 -= sayi2));
            Console.WriteLine("sayi1 *= sayi2 :" + (sayi1 *= sayi2));
            Console.WriteLine("sayi1 /= sayi2 :" + (sayi1 /= sayi2));
            Console.WriteLine("sayi1 %= sayi2 :" + (sayi1 %= sayi2));

            Console.WriteLine();

            Console.WriteLine("ilişkisel operatörler"); // birden fazla değeri karşılaştırıp aralarındaki durumu öğrenmek için kullanırız

            Console.WriteLine($"Sayılar sayi1 : {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
            Console.WriteLine("sayı 1 sayı 2 ye eşit mi ?" + (sayi1==sayi2));
            Console.WriteLine("sayı 1 sayı 2 ye eşit değil mi  ?" + (sayi1 != sayi2));
            Console.WriteLine("sayı 1 sayı 2 den büyük mü ?" + (sayi1 > sayi2));
            Console.WriteLine("sayı 1 sayı 2 den küçük mü ?" + (sayi1 < sayi2));
            Console.WriteLine("sayı 1 sayı 2 den büyük veya eşit mi ?" + (sayi1 >= sayi2));
            Console.WriteLine("sayı 1 sayı 2 den küçük veya eşit mi ?" + (sayi1 <= sayi2));
            Console.WriteLine();

            Console.WriteLine("ternary operatörü"); // eğer karşılaştırma için 2 değer kullanacaksak karşılaştırmanın kısa yolu olarak kullanırız
            Console.WriteLine("ternary : " + ((sayi1==sayi2) ? $"sayı 1({sayi1}) sayı 2({sayi2}) ye eşit" : $"sayı 1({sayi1}) sayı 2({sayi2}) ye eşit değil"));

            Console.WriteLine();
            Console.WriteLine("mantıksal operatörler");
            Console.WriteLine("and & operatörü");

            Console.WriteLine($"Sayılar sayi1 : {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
            Console.WriteLine("sayı 1 sayı 2 ye eşit mi ?" + (sayi1 == sayi2));
            Console.WriteLine("sayı 1 sayı 2 den büyük mü ?" + (sayi1 > sayi2));
            sayi1 = 4; // sayi1 değerini 4 yapalım ki sonuç true olsun
            Console.WriteLine("sayı 1 sayı 2 ye eşitmi? ve sayı bir sayı 2 den küçükmü" +((sayi1==sayi2) && (sayi1<sayi2))); // iki değerinde true sonuç vermesi lazım 1 tanesi false olması durumunda  sonuç false olur

            Console.WriteLine();
            Console.WriteLine("veya || operatörü");
            Console.WriteLine("sayı 1 sayı 2 ye eşitmi? veya sayı bir sayı 2 den küçükmü" + ((sayi1 == sayi2) || (sayi1 < sayi2))); 


        }
    }
}
