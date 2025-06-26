using System.Xml;

namespace SOLIDPrensipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solid Prensipleri");
            Console.WriteLine("Robert Cecil Martin tarafından öne sürülen geliştirilecek yazılımın esnek, yeniden kullanılabilir, sürdürülebilir ve anlaşılır olmasını hedefleyen, kod tekrarını önleyen prensipler bütünüdür.");

            Console.WriteLine("");

            Console.WriteLine("S - single responsibility(tek sorumluluk prensibi)");
            Console.WriteLine(" \t 1 sınıf veya metodun sadece 1 sorumluluğunun olması gerekir");

            Console.WriteLine("O - open closed principle (açık kapalı prensibi)");
            Console.WriteLine("\t bir sınıf veya metot varolan özelliklerini korumalı değişikliğe izin vermemlidir");

            Console.WriteLine("L - liskov substitution principle (liskov yerine geçme prensibi)");
            Console.WriteLine("\tkodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları türedikleri ust sınıfların yerine kullanabilmeliyiz ");

            Console.WriteLine("I - ınterface segregation");
            Console.WriteLine(" \t sorumlulukların hepsını tek bir arayüze toplamak yerine özelleştirilmiş 1 den fazla arayüz kullanmalıyız");

            Console.WriteLine("D - dependency ınversion");
            Console.WriteLine( "\t sınıflar arası bağımlılıklar olabildigince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bvağımlı olmamalıdır");



        }
    }
}
