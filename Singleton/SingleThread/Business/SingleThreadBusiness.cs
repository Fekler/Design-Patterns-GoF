using DesignPatternsGoF.Singleton.SingleThread.Model;

namespace DesignPatternsGoF.Singleton.SingleThread.Business
{
    public class SingleThreadBusiness
    {

        public SingleThreadBusiness()
        {
            Console.WriteLine("##### Padrão Singleton #####\n");
            Console.WriteLine("Tentando criar uma instância s1.");

            SingletonSingleThread singleton1 = SingletonSingleThread.Instance;

            Console.WriteLine("Tentando criar uma instância s2.");

            SingletonSingleThread singleton2 = SingletonSingleThread.Instance;

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Existem somente uma instância (s1==s2)");
            }
            else
            {
                Console.WriteLine("Existem instâncias diferentes (s1 e s2)");
            }
            Console.Read();
        }
    }
}
