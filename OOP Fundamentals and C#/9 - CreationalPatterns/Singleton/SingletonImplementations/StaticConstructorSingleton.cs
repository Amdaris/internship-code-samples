namespace Singleton.SingletonImplementations
{
    public class StaticConstructorSingleton
    {
        private static readonly StaticConstructorSingleton _instance = new StaticConstructorSingleton();
        public static string CONST = "CONST_STRING";
        static StaticConstructorSingleton()
        {
            System.Console.WriteLine("Constructor called");
        }

        public static StaticConstructorSingleton Instance { get { System.Console.WriteLine("Instance called"); return _instance; } }
    }
}
