using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
           
            int age = int.Parse(Console.ReadLine());

            Person person = new Person(age);
            
            string info = $"Name: {person.Name}, Age: {person.Age}";
            
            Console.WriteLine(info);
           
        }
    }
}
