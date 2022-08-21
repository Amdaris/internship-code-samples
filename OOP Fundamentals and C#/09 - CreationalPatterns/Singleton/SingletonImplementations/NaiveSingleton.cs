using System;

namespace Singleton.SingletonImplementations
{
    public class NaiveSingleton
    {
        private static NaiveSingleton _instance;
        private NaiveSingleton()
        {
            Console.WriteLine("Constructor called");
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
