using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
     public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                string name = info[0];
                int age = int.Parse(info[1]);
                Person person = new Person(name, age);

                dict.Add(person.Name, person.Age);


            }
            foreach (var person in dict.OrderBy(x => x.Key))
            {
                if (person.Value >= 30)               
                    Console.WriteLine($"{person.Key} - {person.Value}");
                
            }
            
           

            
        }
    }
}
