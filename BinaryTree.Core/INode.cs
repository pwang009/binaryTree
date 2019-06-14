using System;

namespace BinaryTree.Core
{
    public interface INode<T> where T : IComparable
    {
        NodeColor Color { get; set; }
        bool IsLeaf { get; }
        Node<T> Parent { get; set; }
        T Value { get; set; }

        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}