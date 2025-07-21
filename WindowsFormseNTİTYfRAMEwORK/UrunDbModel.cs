using System.Data.Entity;   // entitiy framework kütüphanesini ekle
using WindowsFormsAppAdoNet; 


namespace WindowsFormseNTİTYfRAMEwORK
{
    public class UrunDbModel : DbContext // entity framework DbContext sınıfından miras alıyoruz

    {
        public UrunDbModel() : base("name=UrunDbModel") // entitiy framework ün DbContext sınıfındaki base e connection string ismini gönderiyoruz
        {
        }
        public virtual DbSet <Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }




    }
}
