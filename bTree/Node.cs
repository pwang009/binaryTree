using System;

namespace bTree
{
    public enum NodeColor { RED, BLACK }

    public class Node<T> where T : IComparable
    {
        private T _value;
        public Node<T> Left;
        public Node<T> Right;
        public NodeColor Color { get; set; }
        public bool IsLeaf => (Left == null) && (Right == null);

        public Node(T value)
        {
            _value = value;
            Left = null;
            Right = null;
            Color = NodeColor.RED;
        }

        public Node() { }
        public bool Search(Node<T> node, T obj)
        {
            if (node == null) { return false; }
            if (node._value.CompareTo(obj) == 0) { return true; }
            return node._value.CompareTo(obj) == 1 ? Search(Left, obj) : Search(Right, obj);
        }

        public override bool Equals(object obj)
        {
            if (obj is Node<T> other)
            {
                return ReferenceEquals(_value, other._value) || _value.Equals(other._value);
            }
            return false;
        }

        public override int GetHashCode() => _value == null ? 0 : _value.GetHashCode();

        public static bool operator ==(Node<T> left, Node<T> right) => ReferenceEquals(left, right) || (left?.Equals(right) ?? false);
        public static bool operator !=(Node<T> left, Node<T> right) => !(left == right);
        public static bool operator <(Node<T> left, Node<T> right) => left._value.CompareTo(right._value) < 0;
        public static bool operator >(Node<T> left, Node<T> right) => left._value.CompareTo(right._value) > 0;

        public override string ToString() => _value.ToString();
    }
}

