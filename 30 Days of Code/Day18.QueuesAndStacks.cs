using System;
using System.Collections.Generic;

namespace Day18.QueuesAndStacks
{
    class Solution
    {
        Stack<char> stack = new Stack<char>();
        Queue<char> queue = new Queue<char>();

        public void pushCharacter(char ch)
        {
            stack.Push(ch);
        }
        public void enqueueCharacter(char ch)
        {
            queue.Enqueue(ch);
        }
        public char popCharacter()
        {
            return stack.Pop();
        }
        public char  dequeueCharacter()
        {
            return queue.Dequeue();
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Solution obj = new Solution();

            foreach (var c in str)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (obj.dequeueCharacter() != obj.popCharacter())
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine($"The word, {str}, is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The word, {str}, is not a palindrome.");
            }
        }
    }
}