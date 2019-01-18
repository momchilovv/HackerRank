using System;

namespace Day15.LinkedList
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    class Program
    {
        public static Node insert(Node head, int data)
        {
            if (head == null)
            {
                return new Node(data);
            }
            else if (head.next == null)
            {
                head.next = new Node(data);
            }
            else
            {
                insert(head.next, data);
            }
            return head;
        }

        static void display(Node head)
        {
            Node start = head;

            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Node head = null;

            int T = int.Parse(Console.ReadLine());

            while (T --> 0)
            {
                int data = int.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }
}