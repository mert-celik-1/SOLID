using Single_Responsibility;


//Single responsibility prensibi sınıflarımızın iyi tanımlanmış tek bir sorumluluğu olması gerektiğini anlatmaktadır.
//Bir sınıf (nesne) yalnızca bir amaç uğruna değiştirilebilir, o amaçta o sınıfa yüklenen sorumluluktur, yani bir sınıfın yapması gereken yalnızca bir işi olması gerekir.
//Eğer geliştirdiğiniz sınıf ya da fonksiyon birden fazla amaca hizmet ediyorsa, bu kurala aykırı bir geliştirme sürecinde olduğunuz anlamına geliyor.
//Bunu farkettiğinizde amaçlara uygun olarak parçalamanız gerekmektedir.



class Database
{
    public void Connect()
    {
        //...
        Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");
    }
    public void Disconnect()
    {
        //...
        Console.WriteLine("Veritabanı bağlantısı kesilmiştir.");
    }
    public string State { get; set; }
}

class PersonService
{
    public List<Person> GetPersons()
    {
        return new() {
            new(){ Name = "test", Surname = "test" },
        };
    }
}