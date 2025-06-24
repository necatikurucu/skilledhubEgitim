using Konu15AbstractClasses;
using System.Threading.Channels;

namespace Konu15AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 15 Abstract Classes");
            Database database = new Oracle(); //database sınıfından yeni bir oracle nesnesi oluşturuyoruz. databse nesnesi oluşturulmuyor
            database.Add();
            database.Delete();

            Console.WriteLine();

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete();
        }
    }
    abstract class Database
    {
        public void Add()
        {   
            Console.WriteLine("Add metodu çalıştı Ekleme yapıldı");
        }
        public abstract void Delete(); // crud
        public abstract void Update(); // crud
        public abstract void Get(); // crud

    }
}
    class SqlServer : Database
{
    public override void Delete()
    {
        Console.WriteLine("SqlServer'da silme işlemi yapıldı");
    }
    public override void Update()
    {
        Console.WriteLine("SqlServer'da güncelleme işlemi yapıldı");
    }
    public override void Get()
    {
        Console.WriteLine("SqlServer'da veri alındı");
    }
}
class Oracle : Database
{
    public override void Delete()
    {
        Console.WriteLine("oracle'da silme işlemi yapıldı");
    }
    public override void Update()
    {
        Console.WriteLine("oracle'da güncelleme işlemi yapıldı");
    }
    public override void Get()
    {
        Console.WriteLine("oracle'da veri alındı");
    }

}














