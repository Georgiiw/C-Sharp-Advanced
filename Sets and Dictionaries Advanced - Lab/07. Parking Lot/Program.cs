using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();
            while (true)
            {
                string[] info = Console.ReadLine().Split(", ");
                string inOrOut = info[0];
                if (inOrOut == "END")
                {
                    break;
                }
                string carNumber = info[1];
                if (inOrOut == "IN")
                {
                    parking.Add(carNumber);
                }
                else if (inOrOut == "OUT")
                {
                    parking.Remove(carNumber);
                }
            }
            if (parking.Count > 0)           
                Console.WriteLine(string.Join("\r\n", parking));
            
            else           
                Console.WriteLine("Parking Lot is Empty");           
        }
    }
}
