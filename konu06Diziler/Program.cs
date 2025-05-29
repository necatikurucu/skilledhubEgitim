namespace konu06Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("diziler");
            // dizi oluşturma
            int[] sayi;
            int[] ogrenciler = new int[6]; // ogrenciler isminde int veri tipi taşıyan  ve 7 elemandan oluşan bir dizi oluşturduk dizi boyutu artmaz azalmaz
                                           //dizilerde indis denilen bir yapı vardır  ve içine eklenecek elemanlar 0 dan başlar
            ogrenciler[0] = 100;           // diziye veri atama
            ogrenciler[1] = 200;
            ogrenciler[2] = 300;
            ogrenciler[3] = 400;
            ogrenciler[4] = 500;
            ogrenciler[5] = 600;

            Console.WriteLine("seçilen öğrenci no: " + ogrenciler[5]);


        }
    }
}
