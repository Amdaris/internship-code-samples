using Singleton.SingletonImplementations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TestUniqueInstanceNaiveSingleton();
            //TestMultipleThreadsNaiveApproach();
            //TestMultipleThreadsThreadSaveSingleton();
            //TestMultipleThreadsStaticConstructorSingleton();

            var instance = StaticConstructorSingletonNested.Instance;


            Console.ReadLine();
        }

        public static void TestUniqueInstanceNaiveSingleton()
        {
            var instance1 = NaiveSingleton.Instance;
            var instance2 = NaiveSingleton.Instance;

            Console.WriteLine(instance1 == instance2);
        }

        public static void TestMultipleThreadsNaiveApproach()
        {
            var strings = new List<string>() { "one", "two", "three", "four", "five" };
            var instances = new List<NaiveSingleton>();
            var options = new ParallelOptions { MaxDegreeOfParallelism = 5 };
            Parallel.ForEach(strings, options, instance =>
            {
                instances.Add(NaiveSingleton.Instance);
            });
        }

        public static void TestMultipleThreadsThreadSaveSingleton()
        {
            var strings = new List<string>() { "one", "two", "three", "four", "five" };
            var instances = new List<ThreadSafeSingleton>();
            var options = new ParallelOptions { MaxDegreeOfParallelism = 5 };
            Parallel.ForEach(strings, options, instance =>
            {
                instances.Add(ThreadSafeSingleton.Instance);
            });
        }

        public static void TestMultipleThreadsStaticConstructorSingleton()
        {
            var strings = new List<string>() { "one", "two", "three", "four", "five" };
            var instances = new List<StaticConstructorSingleton>();
            var options = new ParallelOptions { MaxDegreeOfParallelism = 5 };
            Parallel.ForEach(strings, options, instance =>
            {
                instances.Add(StaticConstructorSingleton.Instance);
            });
        }
    }
}
