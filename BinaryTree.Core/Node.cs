using System;

namespace BinaryTree.Core
{
    public enum NodeColor { RED, BLACK }
    public enum DirectionFromParent { LEFT, RIGHT }

    public class Node<T> : INode<T> where T : IComparable
    {
        private T _value;
        public Node<T> Left;
        public Node<T> Right;
        public Node<T> Parent { get; set; }
        public T Value { get { return _value; } set { _value = value; } }
        public NodeColor Color { get; set; }
        public bool IsLeaf => (Left == null) && (Right == null);
        public DirectionFromParent NodeDirectionFromParent;

        public Node(T value)
        {
            _value = value;
            Left = Right = Parent = null;
            Color = NodeColor.RED;
        }

        public Node() { }

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

