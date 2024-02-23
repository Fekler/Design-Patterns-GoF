namespace DesignPatternsGoF.Singleton.SingleThread.Model
{
    public class SingletonSingleThread
    {
        private static SingletonSingleThread? _instance;
        private int numberOfInstances = 0;

        private SingletonSingleThread()
        {
            Console.WriteLine("Instanciando dentro do construtor privado");
            numberOfInstances++;
            Console.WriteLine($"Número de Instâncias = {numberOfInstances}");
        }

        public static SingletonSingleThread Instance
        {
            get 
            {
                Console.WriteLine("Criando a primeira instância");
                _instance ??= new();
                return _instance;
            }
        }
    }
}
