namespace Singleton.SingletonImplementations
{
    //Thread-safe
    //No locks => good performance
    //Complex and non-intuitive
    public class StaticConstructorSingletonNested
    {
        private StaticConstructorSingletonNested()
        {

        }

        private class Nested
        {
            internal static readonly StaticConstructorSingletonNested _instance = new StaticConstructorSingletonNested();
            static Nested()
            {
                System.Console.WriteLine("StaticConstructorSingletonNested initialized..");
            }
        }

        public static StaticConstructorSingletonNested Instance { get { return Nested._instance; } }
    }
}
