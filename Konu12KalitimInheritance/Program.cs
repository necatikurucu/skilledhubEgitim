using static Konu12KalitimInheritance.Program.Cizici;

namespace Konu12KalitimInheritance
{

    class Arac
    {
        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine("Kornaya Basıldı!");
        }
    }
    class Otomobil : Arac //iki nokta üstüste araç dediğimizde araç sınıfındaki içerikler otomobil sınıfında kullanılabilir.
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }
    class Yat : Arac
    {
        public int Uzunluk { get; set; }
        public int Kamara { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu12 Kalitim Inheritance!");

            Arac arac = new();
            arac.AracTuru = "Araba";
            Console.WriteLine("arac.AracTuru =" + arac.AracTuru);

            Otomobil otomobil = new();
            otomobil.AracTuru = "Otomobil"; //Normalde otomobil clasında AracTuru yok
            otomobil.Marka = "BMW";
            otomobil.Model = "X5";
            Console.WriteLine("otomobil.AracTuru : " + otomobil.AracTuru);
            Console.WriteLine("otomobil.Marka : " + otomobil.Marka);

            otomobil.KornaCal(); // kornaCal metodu bir üst sınıf olan araç sınıfından geliyor

            Console.WriteLine();

            Kategori kategori = new()
            {
                Name = "Elektronik",
                UstMenudeGoster = true,
                CreateDate = DateTime.Now
            };
            if (kategori.UstMenudeGoster == true)
            {
                Console.WriteLine($"Kategori bilgileri :\n adı : {kategori.Name} - Eklenme tarihi {kategori.CreateDate}");
            }
            Console.WriteLine();

            Urun urun = new()
            {
                Name = "klavye",
                Fiyat = 1500,
                Kdv = 18,
                CreateDate = DateTime.Now
            };
            Console.WriteLine("Ürün bilgileri");
            Console.WriteLine($"Adı : {urun.Name}");
            Console.WriteLine($"Fiyat : {urun.Fiyat}");
            Console.WriteLine($"Kdv : {urun.Kdv}");
            Console.WriteLine($"Ekleme tarihi : {urun.CreateDate}");

            Console.WriteLine();

            Cizici[] birCizici = new Cizici[4]; // Cizici sınıfından bir dizi oluşturduk. 4 elemanlı.
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

            foreach (var item in birCizici)
            {
                item.Ciz(); // Ciz metodu Cizici sınıfında virtual olarak tanımlandığı için her bir sınıf için farklı çıktılar alırız.
            }

        }
        //polimorfizm - çok biçimlilik
        public class Cizici
        {
            public virtual void Ciz() // virtual keywordu ile bu metodu override edilebilir ezilebilir hale getiriyoruz.
            {
                Console.WriteLine("Cizildi");
            }
            public class DogruCiz : Cizici
            {
                public override void Ciz() // override keywordu ile bu metodu ezmiş oluyoruz.
                {
                    Console.WriteLine("Düz çizgi");
                }
            }
            public class DaireCiz : Cizici
            {
                public override void Ciz() // override keywordu ile bu metodu ezmiş oluyoruz.
                {
                    Console.WriteLine("Daire çizgi");
                }

            }
            public class KareCiz : Cizici
            {
                public override void Ciz() // override keywordu ile bu metodu ezmiş oluyoruz.
                {
                    Console.WriteLine("Kare çizgi");
                }
            }
        }
    }
}

