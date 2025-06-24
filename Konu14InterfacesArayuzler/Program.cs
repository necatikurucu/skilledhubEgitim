namespace Konu14InterfacesArayuzler
{
    public interface OrnekArayuz // class yerine interface kullanıyoruz
    {
        public int Id { get; set; }
    }
    interface IDemo
    {
        void Goster();
    }
    interface icerebilecekleri : IDemo
    {
        public int sayi1 { get; set; }
        int sayi { get; set; }
        static int sayi2 { get; set; }
        void Topla();
        int ToplamaYap();
    }
    class ArayuzKullanımı : icerebilecekleri
    {
        public int sayi1 { get; set; }
        public int sayi { get; set; }

        public void Goster()
        {
            Console.WriteLine(sayi1);
        }

        public void Topla()
        {
            Console.WriteLine();
        }

        public int ToplamaYap()
        {
            return 18;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu14:Interfaces-Arayuzler");
            ArayuzKullanımı arayuzKullanımı = new();
            arayuzKullanımı.sayi1 = 18;
            arayuzKullanımı.Goster();

            Urun urun = new Urun();
            Console.WriteLine("ürün adı giriniz");
            var urunAdi = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(urunAdi)) // boşluk kontrolü yapıyoruz
            {
                urun.Name = urunAdi;
                urun.Add(urun.Name);
            }
            else
            {
                Console.WriteLine("Ürün adı boş bırakılamaz.");

                Console.WriteLine();

                Console.WriteLine("kategori adı  giriniz");
                Kategori kategori = new Kategori();
                KategoriDBIslemleri kategoriDBIslemleri = new();
                var kategoriAdi = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(kategoriAdi)) // boşluk kontrolü yapıyoruz
                {
                    kategori.Name = kategoriAdi;
                    kategoriDBIslemleri.Add(kategoriAdi);

                }
                else
                {
                    Console.WriteLine("Kategori adı boş bırakılamaz.");
                }
            }
        }
    }
}
