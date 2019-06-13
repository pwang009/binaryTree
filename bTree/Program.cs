using System;

namespace bTree
{
    public delegate void PrintMessage(string value);

    class Program
    {
        static void Main(string[] args)
        {
            var bt = new BinaryTree<int>();
            //remove leaf only
            //bt.Add(80)          //root
            //    .Add(50)        //Left 80
            //    .Add(80)        //Ignored
            //    .Add(30)        //Left 50
            //    .Add(150)       //Right 80
            //    .Add(60)        //Right 50
            //    .Add(10)        //Left 30
            //    .Add(100)     //Left 150
            //    .Remove(10)
            //    .Remove(30)
            //    .Add(25)
            //    ;

            //remove node when having 2 branches and not leaf
            //bt.Add(20)
            //    .Add(50)
            //    .Add(60)
            //    .Add(30)
            //    .Add(70)
            //    .Add(40)
            //    .Add(55)
            //    .Remove(50);

            //remove 
            bt.Add(20)
                .Add(30)
                .Add(10)
                .Add(29)
                .Add(27)
                .Remove(30)
                ;
            Console.WriteLine($"Total Number of Node: {bt.Count}");
            Console.WriteLine($"Min Value of Tree: {bt.MinValue}");
            //Console.ReadKey();
        }
    }
}
