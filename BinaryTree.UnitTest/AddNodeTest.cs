using BinaryTree.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTree.UnitTest
{
    [TestClass]
    public class AddNodeTest
    {

        private BinaryTree<int> bt = new BinaryTree<int>();

        [TestMethod]
        public void MinValueTest()
        {
            // Arrange
            bt = BinaryTreeSetUp.Creation(bt);
            // Act

            // Assert
            Assert.AreEqual(10, bt.MinValue, 0, "min value is 10");
        }

        [TestMethod]
        public void MaxValueTest()
        {
            // Arrange
            bt = BinaryTreeSetUp.Creation(bt);
            // Act

            // Assert
            Assert.AreEqual(200, bt.MaxValue, 0, "max value is 200");
        }

        [TestMethod]
        public void IsLeafTest()
        {
            // Arrange
            bt = BinaryTreeSetUp.Creation(bt);
            // Act
            var node = bt.Find(200);
            // Assert
            Assert.AreEqual(true, node.IsLeaf, "node 200 is leaf");
        }

        [TestMethod]
        public void IsNotLeafTest()
        {
            //Arrange
            bt = BinaryTreeSetUp.Creation(bt);
            //Act
            var node = bt.Find(80);
            //Assert
            Assert.AreNotEqual(true, node.IsLeaf, "node 80 is not leaf");
        }

        [TestMethod]
        public void ConnectionTest1()
        {
            //Arrange
            bt = BinaryTreeSetUp.Creation(bt);
            //Act
            var node = bt.Find(150);
            //Assert
            Assert.AreEqual(100, node.Left.Value, 0, "Node 150 left is node 100");
            Assert.AreEqual(200, node.Right.Value, 0, "Node 150 right is node 200");
        }

    }
}
