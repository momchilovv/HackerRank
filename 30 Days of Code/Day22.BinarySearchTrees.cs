using System;

namespace Day22.BinarySearchTrees
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
        static int getHeight(Node root)
        {
            if (root == null)
            {
                return -1;
            }
            else
            {
                int leftDepth = getHeight(root.left);
                int rightDepth = getHeight(root.right);

                if (leftDepth > rightDepth)
                {
                    return 1 + leftDepth;
                }
                else
                {
                    return 1 + rightDepth;
                }
            }
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

            while (t --> 0)
            {
                int data = int.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
        }
    }
}