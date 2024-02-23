namespace DesignPatternsGoF.Singleton.ThreadSafety.Model
{
    public class SingletonThreadSafety
    {
        private static SingletonThreadSafety? _instance = null;
        private static readonly object lockObject = new();
        private int numberOfInstances = 0;

        private SingletonThreadSafety()
        {
            Console.WriteLine("Instanciando dentro do construtor privado");
            numberOfInstances++;
            Console.WriteLine($"Número de Instâncias = {numberOfInstances}");
        }

        public static SingletonThreadSafety Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockObject)
                    {
                        _instance ??= new();
                    }
                }
                return _instance;
            }
        }
    }
}
