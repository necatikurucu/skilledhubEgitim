using Konu08SiniflarClasses;
using System.ComponentModel.DataAnnotations;

namespace konu08SınıflarClasses
{
    internal class Ev // sınıf tanımlama
    {
        internal string sokakAdi;
        internal int kapiNo;
    }
    /*   C# nesne yönelimli bir programlama dili olduğu için her şey sınıflar içinde tanımlanır.
         sınıflara ve sınıf öğelerine erişim kısıtlanabilir veya belirli düzeylerde erişime izin verilebilir.
         Öğelere erişimi kısıtlayan ya da yetki veren anahtar sözcüklere "Erişim Belirteçleri" (acces modifiers) denir.
         *Erişim belirteçleri 4 ana sınıfa ayrılır
         * public    : Erişim kısıtı yoktur, her yerden erişilebilir
         * protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
         * internal  : Etkin projeye ait sınıflardan erişilebilir, onların dışında erişilemez
         * private   : Yalnız bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez
         * Bir öğe yalnızca 1 erişim belirteci alabilir
         * namespace erişim belirteci almaz çünkü o daima public tir
         * Sınıflar public yada internal nitelemesi alabilirler ama protected yada private nitelemesi alamazlar
         * enum erişim belirteci almaz çünkü daima public tir
    */
    public class deneme
    {
        public string Urunadi = "public öğeye herkes erişebilir";
        protected class test // ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir
        {
            public string Urunadi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sınıflar - classes");
            #region Örnek1


            Ev ilkEv = new Ev(); // soyut bir yapı olan ev sınıfından somut bir nesne olan ilkev i oluşturduk
            ilkEv.sokakAdi = "çiçek sk.";
            ilkEv.kapiNo = 10;
            Console.WriteLine("ilkEv sokak adi :" + ilkEv.sokakAdi);
            Console.WriteLine("ilkEv kapi no : " + ilkEv.kapiNo);

            Console.WriteLine();

            Ev yazlikEv = new Ev();
            yazlikEv.sokakAdi = "deniz sk.";
            yazlikEv.kapiNo = 20;
            Console.WriteLine("yazlikEv sokak adi :" + yazlikEv.sokakAdi);
            Console.WriteLine("yazlikEv kapi no : " + yazlikEv.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new()
            {
                sokakAdi = "Pınar sk.", // bu şekilde de tanımlama yapabiliriz ; yerine , kullanmak gerekir
                kapiNo = 34
            };
            Console.WriteLine("koyEvi sokak adi :" + koyEvi.sokakAdi);
            Console.WriteLine("koyEvi kapi no : " + koyEvi.kapiNo);
            #endregion
            Console.WriteLine();
            #region Örnek2

            Kullanici kullanici = new()
            {
                Adi = "Ahmet",
                Soyadi = "Yılmaz",
                Email = "ahmet@yilmaz.com",
                Id = 1,
                KullaniciAdi = "ahmety",
                Sifre = "123456"
            };

            Kullanici necati = new()
            {
                Adi = "necati",
                Soyadi = "kurucu",
                Email = "kn_1907@hotmail.com",
                Id = 32,
                KullaniciAdi = "kn_1907",
                Sifre = "1122335544"
            };

            Console.WriteLine("Kullanıcı bilgileri :");
            Console.WriteLine("Adı : " + kullanici.Adi);
            Console.WriteLine("SoyAdı : " + kullanici.Soyadi);

            Console.WriteLine();

            Console.WriteLine("Adı : " + necati.Adi);
            Console.WriteLine("SoyAdı : " + necati.Soyadi);
            #endregion
            /*
            Console.WriteLine("Kullanıc Adınız :");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz :");
            var sifre = Console.ReadLine();
            if (kullaniciAdi == kullanici.KullaniciAdi && sifre == kullanici.Sifre)
            {
                Console.WriteLine("hoşgeldin : " + kullanici.Adi + " " + kullanici.Soyadi);
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı!");
            }
            */
            Console.WriteLine();

            Araba araba = new()
            {
                Id = 1,
                Marka = "Toyota",
                Model = "Corolla",
                KasaTipi = "Sedan",
                YakitTipi = "Benzin",
                VitesTipi = "Otomatik",
                Renk = "Gümüş"
            };
            Console.WriteLine("Araç Bilgisi");
            Console.WriteLine($" Marka : {araba.Marka} \n Model : {araba.Model} \n Renk : {araba.Renk}");

            Console.WriteLine();

            Araba araba2 = new()
            {
                Id = 2,
                Marka = "Hyundai",
                Model = "Excel",
                KasaTipi = "Sedan",
                YakitTipi = "Benzin + lpg",
                VitesTipi = "Manuel",
                Renk = "Beyaz"
            };
            Console.WriteLine("Araç Bilgisi");
            Console.WriteLine($" Marka : {araba2.Marka} \n Model : {araba2.Model} \n Renk : {araba2.Renk}");

            Console.WriteLine();

            Kategori kategori = new()
            {
                Id = 1,
                KategoriAdi = "Elektronik"
            };
            Kategori kategori2 = new()
            {
                Id = 2,
                KategoriAdi = "Bilgisayar"
            };
            Kategori kategori3 = new()
            {
                Id = 3,
                KategoriAdi = "Telefon"
            };
            Console.WriteLine("Kategori   : " + kategori.KategoriAdi);
            Console.WriteLine("Kategori 2 : " + kategori2.KategoriAdi);
            Console.WriteLine("Kategori 3 : " + kategori3.KategoriAdi);

            Console.WriteLine();

            SiniftaMetotKullanimi metotKullanimi = new();
            var sonuc = metotKullanimi.LoginKontrol("admin", "123456");

            if (sonuc == true)
            {
                Console.WriteLine("Giriş başarılı!");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı!");
            }


            var toplamasonucu = metotKullanimi.ToplamaYap(10, 5);
            Console.WriteLine("toplamasonucu : " + toplamasonucu);

            Console.WriteLine("Statik Degisken : " + SiniftaMetotKullanimi.StatikDegisken);

            Console.WriteLine("Dinamik Degisken : " + metotKullanimi.DinamikDegisken);

            Console.WriteLine();

            Urun urun = new()
            {
                Id = 3,
                Adi = "Laptop",
                Fiyati = 14999,
                Durum = true,
                Markasi = "Dell",
                UrunAciklamasi = "Dell Inspiron 15 3000 Serisi"
            };
            Urun mouse = new()
            {
                Id = 3,
                Adi = "mouse",
                Fiyati = 149,
                Markasi = "A4 tech",
                UrunAciklamasi = "kablolu"
            };
            Console.WriteLine("ürün bilgileri");
            Console.WriteLine($"ürün adı {urun.Adi}");
            Console.WriteLine($"ürün fiyatı {urun.Fiyati}");
            Console.WriteLine($"ürün ürün açıklaması {urun.UrunAciklamasi}");
            Console.WriteLine();
            Console.WriteLine("ürün bilgileri");
            Console.WriteLine($"ürün adı {mouse.Adi}");
            Console.WriteLine($"ürün fiyatı {mouse.Fiyati}");
            Console.WriteLine($"ürün ürün açıklaması {mouse.UrunAciklamasi}");
            Console.WriteLine();

            Console.WriteLine("Urun Data Metotlari");
            UrunDataMetotlari urunDataMetotlari = new();
            urunDataMetotlari.UrunEkle(mouse);
            urunDataMetotlari.UrunGuncelle(mouse);
            urunDataMetotlari.UrunSil(mouse);

            Console.WriteLine();

            Console.WriteLine("\t\türünler");
            Console.WriteLine();
            foreach (var item in urunDataMetotlari.Urunler())
            {
                Console.WriteLine($"\t ürün adı {item.Adi}");
                Console.WriteLine($"\t ürün fiyatı {item.Fiyati}");
                Console.WriteLine($"\t ürün açıklaması {item.UrunAciklamasi}");
                Console.WriteLine($"\t ürün durumu {item.Durum}");
                Console.WriteLine();
            }
            User user = new();
            Console.WriteLine("Email Giriniz:");
            user.Email = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz:");
            user.Password = Console.ReadLine();
            var giris = user.KullaniciGiris(user.Email, user.Password);
            if (giris == true)
            {
                Console.WriteLine("Hoşgeldiniz!");
            }
            else
                Console.WriteLine("Giriş Başarısız!");
        }      
    

        class Kullanici
        {
            internal int Id;
            internal string KullaniciAdi;
            internal string Sifre;
            internal string Email;
            internal string Adi;
            internal string Soyadi;
        }
        class Araba
        {
            internal int Id;
            internal string Marka;
            internal string Model;
            internal string KasaTipi;
            internal string YakitTipi;
            internal string VitesTipi;
            internal string Renk;
        }

    }
}

