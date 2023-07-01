
namespace Dependency_Inversion2
{
    public class Ferrari
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

    public class Mercedes
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
        public void Run()
        {
            var ferrari = new Ferrari();
            ferrari.Run();

            var mercedes = new Mercedes();
            mercedes.Run();
        }

        public void Stop()
        {
            var ferrari = new Ferrari();
            ferrari.Stop();

            var mercedes = new Mercedes();
            mercedes.Stop();
        }
    }
}
