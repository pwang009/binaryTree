using BinaryTree.Core;
using System;
using System.Diagnostics;

namespace bTree
{
    public delegate void PrintMessage(string value);

    class Program
    {
        static void Main(string[] args)
        {
            var bt = new BinaryTree<double>();

            #region performance
            Stopwatch watch;
            Random random;
            const int SIZE = 500000;
            //int[] a = new int[SIZE];

            watch = Stopwatch.StartNew();
            random = new Random();
            for (int i = 0; i < SIZE; i++) bt.Add( random.Next(0, SIZE-1) );
            #endregion

            watch.Stop();
            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine($"Max Depth of Tree: {bt.Depth}");
            Console.WriteLine($"Total Number of Node: {bt.Count}");
            Console.WriteLine($"Min Value of Tree: {bt.MinValue}");
            Console.WriteLine($"Min Value of Tree: {bt.MaxValue}");
        }
    }
}
