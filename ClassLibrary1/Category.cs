namespace ClassLibrary1
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; } 
        public List<Product>? Products { get; set; } // Category ile Product arasında 1 e çok ilişki kurduk, yani bir kategori birden fazla ürüne sahip olabilir.
    }
}
