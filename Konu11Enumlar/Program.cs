namespace Konu11Enumlar
{
    internal class Program
    {
        //Enum(Numaratör) lar nesneleri numaralandırmak için kullanılır
        /*
        * Enum tipler üzerindeki kısıtlar
        * 1-Enum blokunda metot tanımlanamaz
        * 2-Arayüz(Interface) kullanamazlar
        * 3-enum blokunda property kullanılmaz
        */
        enum Aylar : byte //byte koleksiyonundaki veri tipinin byte olacağını belirtir
        {
            Ocak,Şubat,Mart,Nisan,Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
        }
        enum SiparisDurumu
        {
            Hazırlanıyor,Hazırlandı,KargoBekliyor,Kargolandı
        }
        enum Meyveler : int //int koleksiyonundaki veri tipinin int olacağını belirtir
        {
            Elma = 3, Armut = 7, Çilek = 5
        } 
        

        static void Main(string[] args)
        {
            Console.WriteLine("konu 11 Enumlar");

            Console.WriteLine();

            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;
            Console.WriteLine($"{Meyveler.Armut}={a},{Meyveler.Elma}={b},{Meyveler.Çilek}={c}");
            Ornek1(SiparisDurum: 3);
        }
        static void Ornek1(int SiparisDurum)
        {
            if (SiparisDurum == (int)SiparisDurumu.Hazırlanıyor)
                Console.WriteLine("siparişiniz hazırlanıyor");
            if (SiparisDurum == (int)SiparisDurumu.Hazırlandı)
                Console.WriteLine("siparişiniz hazırlandı");
            if (SiparisDurum == (int)SiparisDurumu.KargoBekliyor)
                Console.WriteLine("siparişiniz kargo bekliyor");
            if (SiparisDurum == (int)SiparisDurumu.Kargolandı)
                Console.WriteLine("siparişiniz kargolandı");
           
        }
    }
}
