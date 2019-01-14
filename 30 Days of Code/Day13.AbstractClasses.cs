using System;
//NOTE: Copy and paste only the internal class MyBook.
namespace Day13.AbstractClasses
{
    abstract class Book
    {
        protected string title;
        protected string author;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
        public abstract void display();
    }
    
    internal class MyBook : Book
    {
        private int price;

        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public override void display()
        {
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"Author: {this.author}");
            Console.WriteLine($"Price: {this.price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string author = Console.ReadLine();
            int price = int.Parse(Console.ReadLine());
            
            Book newNovel = new MyBook(title, author, price);
            newNovel.display();
        }
    }
}