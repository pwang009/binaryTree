using System;

namespace bTree
{
    public delegate void PrintMessage(string value);

    class Program
    {
        static void Main(string[] args)
        {
            var bt = new BinaryTree<int>();
            bt.Add(80)          //root
                .Add(50)        //Left 80
                .Add(80)        //Ignored
                .Add(30)        //Left 50
                .Add(150)       //Right 80
                .Add(60)        //Right 50
                .Add(10)        //Left 30
                .Add(100);      //Left 150
            Console.WriteLine($"Total Number of Node: {bt.Count}");
            Console.WriteLine($"Min Value of Tree: {bt.MinValue}");
            Console.ReadKey();
        }
    }
}
