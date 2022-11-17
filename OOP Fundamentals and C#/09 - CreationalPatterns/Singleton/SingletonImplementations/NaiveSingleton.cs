using System;

namespace Singleton.SingletonImplementations
{
    public class NaiveSingleton
    {
        private static NaiveSingleton _instance;
        private static int _counter;
        private NaiveSingleton()
        {
            _counter++;
            Console.WriteLine($"Constructor called for {_counter} time(s).");
        }
        public static NaiveSingleton Instance
        { 
            get
            {
                Console.WriteLine("Instance called");
                if(_instance == null)
                {
                    _instance = new NaiveSingleton();
                }
                return _instance; 
            }
            private set { } 
        }
    }
}
