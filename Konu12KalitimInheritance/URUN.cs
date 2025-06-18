namespace Konu12KalitimInheritance
{
    internal class Urun : OrtakOzellikler // Urun sınıfı OrtakOzellikler sınıfından kalıtım alıyor
    {
        public string? TeknikOzellik { get; set; } // ? işareti null değer alabileceğini gösterir bnoş bırakılabilir olmasını sağlar
        public decimal Fiyat { get; set; }
        public int Kdv { get; set; }
        public int Iskonto { get; set; }         
    }
}
