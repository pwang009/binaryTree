using System;
using System.Collections.Generic;

namespace bTree
{
    public class BinaryTree<T> where T : IComparable
    {

        private Node<T> root { get; set; }
        private PrintMessage printMessage = Utilities.ConsolePrint;

        public Node<T> MinValue => minValue(root);
        public int Count { get; private set; }

        public BinaryTree()
        {
            root = null;
            Count = 0;
        }

        private bool IsEmpty => root == null;

        public BinaryTree<T> Add(T value)
        {
            if (IsEmpty)
            {
                var nodeToInsert = new Node<T>(value);
                //tree is empty
                root = nodeToInsert;
                root.Color = NodeColor.BLACK;
                Count++;
                printMessage($"{nodeToInsert} added as Root");
            }
            else insert(root, value);
            return this;
        }


        private Node<T> minValue(Node<T> node) => node.Left == null ? node : minValue(node.Left);

        private Node<T> insert(Node<T> node, T value)
        {

            var nodeToInsert = new Node<T>(value);
            if (nodeToInsert > node)
            {
                if (node.Right == null)
                {
                    node.Right = nodeToInsert;
                    Count++;
                    printMessage($"{nodeToInsert} added to right of Parent: {node} ");
                }
                else
                {
                    insert(node.Right, value);
                }
            }
            else if (nodeToInsert < node)
            {
                if (node.Left == null)
                {
                    node.Left = nodeToInsert;
                    Count++;
                    printMessage($"{nodeToInsert} added to left of Parent: {node} ");
                }
                else
                    insert(node.Left, value);
            }
            else printMessage($"duplicate value {nodeToInsert} ignored");
            return node;
        }

    }
}

