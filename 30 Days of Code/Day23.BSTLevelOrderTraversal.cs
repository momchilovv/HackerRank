using System;
using System.Collections;
using System.Collections.Generic;

namespace Day23.BSTLevelOrderTraversal
{
    class Node
    {
        public Node left, right;
        public int data;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    class Program
    {
        static void levelOrder(Node root)
        {
            Queue<Node> nodeQueue = new Queue<Node>();

            nodeQueue.Enqueue(root);
            while (nodeQueue.Count > 0)
            {
                Node node = nodeQueue.Dequeue();
                Console.Write(node.data + " ");

                if (node.left != null)
                {
                    nodeQueue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    nodeQueue.Enqueue(node.right);
                }
            }
            Console.WriteLine();
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node current;
                if (data <= root.data)
                {
                    current = insert(root.left, data);
                    root.left = current;
                }
                else
                {
                    current = insert(root.right, data);
                    root.right = current;
                }
                return root;
            }
        }
        static void Main(string[] args)
        {
            Node root = null;

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int data = int.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }
    }
}