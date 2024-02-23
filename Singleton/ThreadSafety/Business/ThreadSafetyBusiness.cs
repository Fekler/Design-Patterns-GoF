using DesignPatternsGoF.Singleton.ThreadSafety.Model;

namespace DesignPatternsGoF.Singleton.ThreadSafety.Business
{
    public class ThreadSafetyBusiness
    {
        public ThreadSafetyBusiness()
        {
            Parallel.Invoke(
                () => AcessThread1(),
                () => AcessThread2()
           );
            Console.ReadLine();
        }

        private static void AcessThread1()
        {
            SingletonThreadSafety s1 = SingletonThreadSafety.Instance;
            Console.WriteLine("Thread 1 ");
        }
        private static void AcessThread2()
        {
            SingletonThreadSafety s2 = SingletonThreadSafety.Instance;
            Console.WriteLine("Thread 2 ");
        }
    }
}

