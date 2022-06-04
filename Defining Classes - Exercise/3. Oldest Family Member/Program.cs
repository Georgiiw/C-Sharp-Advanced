using System;

namespace DefiningClasses
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                string name = info[0];
                int age = int.Parse(info[1]);

                Person member = new Person(name, age);

                family.AddMember(member);
            }
            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
