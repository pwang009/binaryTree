using BinaryTree.Core;

namespace BinaryTree.UnitTest
{
    public class BinaryTreeSetUp 
    {
        private readonly IBinaryTree<int> _bt;

        public BinaryTreeSetUp(IBinaryTree<int> bt)
        {
            _bt = bt;
        }

        //public IBinaryTree<int> Creation()
        //{
        //    _bt.Add(80)          //root
        //        .Add(50)        //Left 80
        //        .Add(80)        //Ignored
        //        .Add(30)        //Left 50
        //        .Add(150)       //Right 80
        //        .Add(60)        //Right 50
        //        .Add(70)        //Right 60
        //        .Add(55)        //Left 60
        //        .Add(75)        //Right 70 leaf
        //        .Add(10)        //Left 30
        //        .Add(100)       //Left 150
        //        .Add(200)       //Right 150
        //        ;
        //    return bt;
        //}
    }
}
