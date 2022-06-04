using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person info = new Person(name, age);
            string person = $"Name: {info.Name}, Age: {info.Age}";
            Console.WriteLine(person);
        }
    }
}
