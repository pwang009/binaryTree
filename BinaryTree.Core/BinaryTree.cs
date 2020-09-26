using System;
using System.Collections.Generic;

namespace BinaryTree.Core
{
    public class BinaryTree<T> : IBinaryTree<T> where T : IComparable
    {
        private Node<T> _root;
        private PrintMessage printMessage = Utilities.ConsolePrint;
        private bool IsEmpty => _root == null;
        private bool IsRoot => _root.Parent == null;

        public T MinValue => minValue(_root).Value;
        public T MaxValue => maxValue(_root).Value;

        public int Count { get; private set; }
        public int Depth => depth(_root);

        public BinaryTree()
        {
            _root = null;
            Count = 0;
        }

        public BinaryTree(T value)
        {
            _root = new Node<T>(value);
            Count++;
        }

        public BinaryTree<T> Add(T value)
        {
            if (IsEmpty)
            {
                var nodeToInsert = new Node<T>(value);
                //tree is empty
                _root = nodeToInsert;
                _root.Parent = null;
                _root.Color = NodeColor.BLACK;
                Count++;
                printMessage($"{nodeToInsert} added as Root");
            }
            else insert(_root, value);
            return this;
        }

        public BinaryTree<T> Remove(T value)
        {
            var nodeToRemove = Find(value);
            if (nodeToRemove != null)
            {
                //case #1: node is leaf
                if (nodeToRemove.IsLeaf)
                {
                    if (nodeToRemove.NodeDirectionFromParent == DirectionFromParent.LEFT)
                    {
                        printMessage($"{nodeToRemove} removed from left of Parent: {nodeToRemove.Parent} ");
                        nodeToRemove.Parent.Left = nodeToRemove.Left;
                    }
                    else
                    {
                        printMessage($"{nodeToRemove} removed from right of Parent: {nodeToRemove.Parent} ");
                        nodeToRemove.Parent.Right = nodeToRemove.Right;
                    }
                }
                //case #2: node has both branches, find min value from right, replace node value with min value and
                //remove min value node
                else if (nodeToRemove.Left != null && nodeToRemove.Right != null)
                {
                    var nodeMinValueRight = minValue(nodeToRemove.Right);
                    nodeToRemove.Value = nodeMinValueRight.Value;
                    printMessage($"{nodeMinValueRight} removed from left of Parent: {nodeMinValueRight.Parent} ");
                    nodeMinValueRight.Parent.Left = null;
                }
                //case #3: node has only one branch, link parent to child 
                else
                {
                    var nodeToLink = nodeToRemove.Left != null ? nodeToRemove.Left : nodeToRemove.Right;
                    if (nodeToRemove.NodeDirectionFromParent == DirectionFromParent.LEFT)
                    {
                        nodeToRemove.Parent.Left = nodeToLink;
                        printMessage($"{nodeToRemove} removed from left of Parent: {nodeToRemove.Parent}");
                    }
                    else
                    {
                        nodeToRemove.Parent.Right = nodeToLink;
                        printMessage($"{nodeToRemove} removed from right of Parent: {nodeToRemove.Parent}");
                    }
                }
            }

            Count--;
            return this;
        }

        public Node<T> Find(T value) => find(_root, new Node<T>(value));

        private Node<T> find(Node<T> node, Node<T> nodeToFind)
        {
            if (node == null) return null;

            //if (node == nodeToFind) return node;
            //else if (node < nodeToFind) return find(node.Right, nodeToFind);
            //else return find(node.Left, nodeToFind);
            if (node < nodeToFind) return find(node.Right, nodeToFind);
            else if (node > nodeToFind) return find(node.Left, nodeToFind);
            else return node;
        }

        private Node<T> minValue(Node<T> node) => node.Left == null ? node : minValue(node.Left);
        private Node<T> maxValue(Node<T> node) => node.Right == null ? node : maxValue(node.Right);

        private Node<T> insert(Node<T> node, T value)
        {

            var nodeToInsert = new Node<T>(value);
            //go to right
            if (nodeToInsert > node)
            {
                if (node.Right == null)
                {
                    nodeToInsert.Parent = node;
                    node.Right = nodeToInsert;
                    nodeToInsert.NodeDirectionFromParent = DirectionFromParent.RIGHT;
                    Count++;
                    printMessage($"{nodeToInsert} added to right of Parent: {node} ");
                }
                else
                    insert(node.Right, value);
            }
            //go to left
            else if (nodeToInsert < node)
            {
                if (node.Left == null)
                {
                    nodeToInsert.Parent = node;
                    node.Left = nodeToInsert;
                    nodeToInsert.NodeDirectionFromParent = DirectionFromParent.LEFT;
                    Count++;
                    printMessage($"{nodeToInsert} added to left of Parent: {node} ");
                }
                else
                    insert(node.Left, value);
            }
            //duplicate value will be ignored.
            else printMessage($"duplicate value {nodeToInsert} ignored");
            return node;
        }

        private int depth(Node<T> node)
        {
            if (node == null) return 0;
            else
            {
                var lDepth = depth(node.Left);
                var rDepth = depth(node.Right);
                return 1 + (lDepth >= rDepth ? lDepth : rDepth);
            }
        }

    }
}

