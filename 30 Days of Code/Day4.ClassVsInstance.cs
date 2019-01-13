using System;

class Person
{
    public int age;
    public Person(int initialAge)
    {
        age = initialAge;
    }
    public void amIOld()
    {
        // Do some computations in here and print out the correct statement to the console
        if (age < 0)
        {
            Console.WriteLine("Age is not valid, setting age to 0.");
            Console.WriteLine("You are young.");
            age = 0;
        }
        else if (age > 0 && age < 13)
        {
            Console.WriteLine("You are young.");
        }
        else if (age >= 13 && age < 18)
        {
            Console.WriteLine("You are a teenager.");
        }
        else if (age >= 18)
        {
            Console.WriteLine("You are old.");
        }
    }

    public void yearPasses()
    {
        age++;
    }
}