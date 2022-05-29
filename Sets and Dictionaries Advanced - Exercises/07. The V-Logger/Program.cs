using System;
using System.Collections.Generic;
using System.Linq;
namespace _7._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var dic = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            

            while (true)
            {
                string sentence = Console.ReadLine();
                if (sentence == "Statistics")               
                    break;
                
                string[] vlogger = sentence.Split(" ");
                string vloggerName = vlogger[0];
                string action = vlogger[1];
                if (action == "joined")
                {

                    if (!dic.ContainsKey(vloggerName))
                    {
                        dic.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                        dic[vloggerName].Add("followers", new HashSet<string>());
                        dic[vloggerName].Add("followed", new HashSet<string>());
                        
                    }
                }
                else if (action == "followed")
                {
                    string vloggerNameTwo = vlogger[2];
                    if (dic.ContainsKey(vloggerName) && dic.ContainsKey(vloggerNameTwo) && vloggerName !=  vloggerNameTwo)
                    {
                        dic[vloggerNameTwo]["followers"].Add(vloggerName);
                        dic[vloggerName]["followed"].Add(vloggerNameTwo);
                        
                    }
                }
            }
            
            Console.WriteLine($"The V-Logger has a total of {dic.Count()} vloggers in its logs.");
            
                int count = 1;
            foreach (var item in dic.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["followed"].Count))
            {
                
                Console.WriteLine($"{count}. {item.Key} : {dic[item.Key]["followers"].Count()} followers" +
                    $", {dic[item.Key]["followed"].Count()} following");

                if (count == 1)             
                    foreach (var follower in item.Value["followers"].OrderBy(f => f))                   
                        Console.WriteLine($"*  {follower}");
                    
                
                count++;

            }
        }
    }
}
