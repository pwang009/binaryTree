using BinaryTree.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTree.UnitTest
{
    [TestClass]
    public class AddNodeTest
    {
        private IBinaryTree<int> _bt;

        //private BinaryTree<int> _bt = new BinaryTree<int>();
        public AddNodeTest(IBinaryTree<int> bt)
        {
            _bt = bt;
        }
        public AddNodeTest()
        {

        }

        [TestMethod]
        public void MinValueTest()
        {
            // Arrange
            //_bt = BinaryTreeSetUp.Creation();
            _bt.Add(80)          //root
                .Add(50)        //Left 80
                .Add(80)        //Ignored
                .Add(30)        //Left 50
                .Add(150)       //Right 80
                .Add(60)        //Right 50
                .Add(70)        //Right 60
                .Add(55)        //Left 60
                .Add(75)        //Right 70 leaf
                .Add(10)        //Left 30
                .Add(100)       //Left 150
                .Add(200)       //Right 150
                ;
            // Act

            // Assert
            Assert.AreEqual(10, _bt.MinValue, 0, "min value is 10");
        }

        //[TestMethod]
        //public void MaxValueTest()
        //{
        //    // Arrange
        //    _bt = BinaryTreeSetUp.Creation(_bt);
        //    // Act

        //    // Assert
        //    Assert.AreEqual(200, _bt.MaxValue, 0, "max value is 200");
        //}

        //[TestMethod]
        //public void IsLeafTest()
        //{
        //    // Arrange
        //    _bt = BinaryTreeSetUp.Creation(_bt);
        //    // Act
        //    var node = _bt.Find(200);
        //    // Assert
        //    Assert.AreEqual(true, node.IsLeaf, "node 200 is leaf");
        //}

        //[TestMethod]
        //public void IsNotLeafTest()
        //{
        //    //Arrange
        //    _bt = BinaryTreeSetUp.Creation(_bt);
        //    //Act
        //    var node = _bt.Find(80);
        //    //Assert
        //    Assert.AreNotEqual(true, node.IsLeaf, "node 80 is not leaf");
        //}

        //[TestMethod]
        //public void ConnectionTest1()
        //{
        //    //Arrange
        //    _bt = BinaryTreeSetUp.Creation(_bt);
        //    //Act
        //    var node = _bt.Find(150);
        //    //Assert
        //    Assert.AreEqual(100, node.Left.Value, 0, "Node 150 left is node 100");
        //    Assert.AreEqual(200, node.Right.Value, 0, "Node 150 right is node 200");
        //}

    }
}
