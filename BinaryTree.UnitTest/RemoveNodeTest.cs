using BinaryTree.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTree.UnitTest
{
    [TestClass]
    public class RemoveNodeTest
    {
        private IBinaryTree<int> _bt;

        //private BinaryTree<int> _bt = new BinaryTree<int>();
        public RemoveNodeTest(IBinaryTree<int> bt)
        {
            _bt = bt;
        }

        //[TestMethod]
        //public void RemoveLeafTest()
        //{
        //    // Arrange
        //    _bt = BinaryTreeSetUp.Creation(_bt);

        //    // Act
        //    _bt = _bt.Remove(75);
        //    var node = _bt.Find(70);

        //    // Assert
        //    Assert.AreEqual(true, node.Right == null, "node 70 right is removed, therefore null");
        //}

        //[TestMethod]
        //public void RemoveNodeHasChildrenTest()
        //{
        //    // Arrange
        //    _bt = BinaryTreeSetUp.Creation(_bt);

        //    // Act
        //    _bt = _bt.Remove(50);
        //    var node = _bt.Find(80);

        //    // Assert
        //    Assert.AreEqual(55, node.Left.Value, 0, "root 80 left is 55, since 50 is removed");
        //}

        //[TestMethod]
        //public void RemoveNodeHasOneChildTest()
        //{
        //    // Arrange
        //    _bt = BinaryTreeSetUp.Creation(_bt);

        //    // Act
        //    _bt = _bt.Remove(70);
        //    var node = _bt.Find(60);

        //    // Assert
        //    Assert.AreEqual(75, node.Right.Value, 0, "Node 60 right is 75, since 70 is removed");
        //}
    }
}
