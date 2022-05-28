using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guestList = new HashSet<string>();
            while (true)
            {
                string guest = Console.ReadLine();
                if (guest == "PARTY")              
                    break;               

                guestList.Add(guest);
            }

            while (true)
            {
                string member = Console.ReadLine();
                if (member == "END")            
                    break;
                if (guestList.Contains(member))
                    guestList.Remove(member);
               
            }
            Console.WriteLine(guestList.Count);
            
            foreach (var guest in guestList)
            {
                if (char.IsDigit(guest[0]))               
                    Console.WriteLine(guest);               
            }
            foreach (var guest in guestList)
            {
                if (char.IsLetter(guest[0]))               
                    Console.WriteLine(guest);               
            }
        }
    }
}
