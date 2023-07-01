//Bir sınıfın, metodun ya da özelliğin, onu kullanan diğer sınıflara karşı olan bağımlılığı en aza indirgenmelidir. 
//Bir alt sınıfta yapılan değişiklikler üst sınıfları etkilememelidir.
//Yüksek seviye sınıflarda bir davranış değiştiğinde, alt seviye davranışların bu değişime uyum sağlaması gerekir.
//Ancak, düşük seviye sınıflarda bir davranış değiştiğinde, üst seviye sınıfların davranışında bir bozulma meydana gelmemelidir.

namespace Dependency_Inversion
{
    public interface IAutomobile
    {
        public void Run();
        public void Stop();
    }

    public class Ferrari : IAutomobile
    {
        public void Run()
        {
            Console.WriteLine("Ferrari çalıştırıldı");
        }

        public void Stop()
        {
            Console.WriteLine("Ferrari durduruldu.");
        }
    }

    public class Mercedes : IAutomobile
    {
        public void Run()
        {
            Console.WriteLine("Mercedes çalıştırıldı");
        }

        public void Stop()
        {
            Console.WriteLine("Mercedes durduruldu.");
        }
    }

    public class AutomobileService
    {
        private readonly IAutomobile automobile;

        public AutomobileService(IAutomobile automobile)
        {
            this.automobile = automobile;
        }

        public void Start()
        {
            automobile.Run();
        }

        public void Stop()
        {
            automobile.Stop();
        }
    }
}
