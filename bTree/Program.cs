using BinaryTree.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;

namespace bTree
{
    public delegate void PrintMessage(string value);

    class Program
    {
        private static ServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            //var bt = new BinaryTree<double>();
            RegisterServices();
            var service = _serviceProvider.GetService<IBinaryTree<int>>();
            PerformanceTest(service);
            DisposeServices();
        }

        
        private static void PerformanceTest(IBinaryTree<int> bt)
        {
            #region performance
            Stopwatch watch;
            Random random;
            const int SIZE = 500000;
            //int[] a = new int[SIZE];

            watch = Stopwatch.StartNew();
            random = new Random();
            for (int i = 0; i < SIZE; i++) bt.Add(random.Next(0, SIZE - 1));
            #endregion

            watch.Stop();
            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine($"Max Depth of Tree: {bt.Depth}");
            Console.WriteLine($"Total Number of Node: {bt.Count}");
            Console.WriteLine($"Min Value of Tree: {bt.MinValue}");
            Console.WriteLine($"Min Value of Tree: {bt.MaxValue}");
        }

        private static void DisposeServices()
        {
            if (_serviceProvider != null && _serviceProvider is IDisposable) ((IDisposable)_serviceProvider).Dispose();
        }

        private static void RegisterServices()
        {
            var collection = new ServiceCollection();
            collection.AddScoped<IBinaryTree<int>, BinaryTree<int>>();
            _serviceProvider = collection.BuildServiceProvider();
        }

    }
}
