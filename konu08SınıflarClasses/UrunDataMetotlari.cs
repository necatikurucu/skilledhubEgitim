namespace konu08SınıflarClasses
{
    public class UrunDataMetotlari
    {
        internal void UrunEkle(Urun urun)
        {
                     Console.WriteLine(urun.Adi + " ürün eklendi!");
        }
        internal void UrunGuncelle(Urun urun)
        {
            Console.WriteLine(urun.Adi + " ürün güncellendi!");
        }
        internal void UrunSil(Urun urun)
        {
            Console.WriteLine(urun.Adi + " ürün silindi!");
        }
        internal Urun UrunGetir()
        {
            Urun urun = new Urun()
            {
                    Adi = "Telefon",
                    Durum = true,
                    Fiyati = 999,
            };
            return urun;                      
        }
        internal Urun[] Urunler()
        {
            return new Urun[]
            {
                new Urun
                {
                    Id = 1,
                    Adi = "Telefon",
                    Fiyati = 999,
                    Durum = false,
                    Markasi = "Samsung",
                    UrunAciklamasi = "Samsung Galaxy S21"
                },
                new Urun
                {
                    Id = 2,
                    Adi = "Laptop",
                    Fiyati = 14999,
                    Durum = true,
                    Markasi = "Dell",
                    UrunAciklamasi = "Dell Inspiron 15 3000 Serisi"
                },
                new Urun
                {
                    Id = 3,
                    Adi = "Tablet",
                    Fiyati = 4999,
                    Durum = true,
                    Markasi = "Apple",
                    UrunAciklamasi = "Apple iPad Air"
                }
            };
        }
    }
}
