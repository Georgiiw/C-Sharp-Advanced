using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List <decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string studentName = info[0];
                decimal studentGrade = decimal.Parse(info[1]);
                if (!students.ContainsKey(studentName)) 
                    students.Add(studentName, new List<decimal>());
                              

                    students[studentName].Add(studentGrade);  

            }

            foreach (var name in students)
            {
                Console.Write($"{name.Key} -> ");
                foreach (var grade in name.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {name.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
