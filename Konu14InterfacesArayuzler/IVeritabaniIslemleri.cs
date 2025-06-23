namespace Konu14InterfacesArayuzler
{
    internal interface IVeritabaniIslemleri
    {
        //bu arayüzü kullanacak clsaslar bu metotları içermek etmek zorundadır
        // CRUD metot imzaları
        void Add(string name); // eklemek için
        void Update(int id);// güncelleme işlemi
        void Delete(int id);// silme işlemi
        void GetAll();// tüm verileri listeleme işlemi
        // interface lerde metotlar açıkca yazılmaz , sadece geridönüş tipi adı ve parametreleri yazılır.

    }
}
