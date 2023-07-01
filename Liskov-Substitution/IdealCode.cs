//Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları, türedikleri(üst) sınıfların yerine kullanabilmeliyiz.
//Türeyen sınıf yani alt sınıflar ana(üst) sınıfın tüm özelliklerini ve metotlarını aynı işlevi gösterecek şekilde kullanabilme ve kendine ait yeni özellikler barındırabilmelidir.

namespace Liskov_Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            IFruit fruit = new Orange();
            Console.WriteLine($"Color of Orange: {fruit.GetColor()}"); // orange
            fruit = new Apple();
            Console.WriteLine($"Color of Apple: {fruit.GetColor()}"); // red
        }
    }
    public interface IFruit
    {
        string GetColor();
    }
    public class Apple : IFruit
    {
        public string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }
}
