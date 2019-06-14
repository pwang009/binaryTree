using BinaryTree.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTree.UnitTest
{
    [TestClass]
    public class RemoveNodeTest
    {
        private BinaryTree<int> bt = new BinaryTree<int>();

        [TestMethod]
        public void RemoveLeafTest()
        {
            // Arrange
            bt = BinaryTreeSetUp.Creation(bt);

            // Act
            bt = bt.Remove(75);
            var node = bt.Find(70);

            // Assert
            Assert.AreEqual(true, node.Right == null, "node 70 right is removed, therefore null");
        }

        [TestMethod]
        public void RemoveNodeHasChildrenTest()
        {
            // Arrange
            bt = BinaryTreeSetUp.Creation(bt);

            // Act
            bt = bt.Remove(50);
            var node = bt.Find(80);

            // Assert
            Assert.AreEqual(55, node.Left.Value, 0, "root 80 left is 55, since 50 is removed");
        }

        [TestMethod]
        public void RemoveNodeHasOneChildTest()
        {
            // Arrange
            bt = BinaryTreeSetUp.Creation(bt);

            // Act
            bt = bt.Remove(70);
            var node = bt.Find(60);

            // Assert
            Assert.AreEqual(75, node.Right.Value, 0, "Node 60 right is 75, since 70 is removed");
        }
    }
}
