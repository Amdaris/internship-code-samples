namespace Singleton.SingletonImplementations
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;
        private static readonly object padlock = new object();

        private ThreadSafeSingleton()
        {
            System.Console.WriteLine("Constructor called");
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                if(_instance == null)
                {
                    System.Console.WriteLine("Instance called");
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ThreadSafeSingleton();
                        }
                    }
                }
                return _instance;
            }
            private set { }
        }
    }
}
