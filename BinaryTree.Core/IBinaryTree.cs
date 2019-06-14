using System;

namespace BinaryTree.Core
{
    public interface IBinaryTree<T> where T : IComparable
    {
        int Count { get; }
        int Depth { get; }
        T MinValue { get; }
        T MaxValue { get; }

        BinaryTree<T> Add(T value);
        BinaryTree<T> Remove(T value);
        Node<T> Find(T value);
    }
}