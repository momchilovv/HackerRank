using System;
using System.Linq;
/*
 * NOTE: In order to try this solution you need to delete printPerson Method and
 * Person class, because they already exist in the site editor and can't be deleted.
 * If you want to test it locally, it will work without any changes.
 */
namespace Day12.Inheritance
{
    class Student : Person
    {
        public int[] testScores;

        public Student(string firstName, string lastName, int id, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.testScores = scores;
        }

        public string Calculate()
        {
            
            double average = testScores.Average();
            if (average >= 90 && average <= 100)
            {
                return "O";
            }
            else if (average >= 80 && average < 90)
            {
                return "E";
            }
            else if (average >= 70 && average < 80)
            {
                return "A";
            }
            else if (average >= 55 && average < 70)
            {
                return "P";
            }
            else if (average >= 40 && average < 55)
            {
                return "D";
            }
            else
            {
                return "T";
            }
        }

        public void printPerson()
        {
            Console.WriteLine($"Name: {lastName}, {firstName}");
            Console.WriteLine($"ID: {id}");
        }
    }

    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; set; }
        public int[] Scores { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = int.Parse(inputs[2]);
            int numScores = int.Parse(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];

            for (int i = 0; i < numScores; i++)
            {
                scores[i] = int.Parse(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}