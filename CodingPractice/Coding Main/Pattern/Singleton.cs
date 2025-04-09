namespace Coding_Main.Pattern
{
    public class Singleton
    {
        private static Singleton? instance;

        private static readonly object _lock = new();
        public static Singleton Instance { get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        instance = new Singleton();
                    }
                    
                }
                return instance;
            }
        }
        private Singleton()
        {
            
        }

        public void PrintSingleton() => Console.WriteLine("Singleton");
    }
}
