using System;

namespace Singleton.SingletonImplementations
{

    public class SingletonUsingLazy
    {
        //accessing this property will initialize the instance
        public static readonly Lazy<SingletonUsingLazy> _instance = new Lazy<SingletonUsingLazy>(() => new SingletonUsingLazy());

        public static SingletonUsingLazy Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private SingletonUsingLazy()
        {

        }
    }
}
