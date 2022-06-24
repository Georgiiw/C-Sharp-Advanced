using System;
using System.Collections.Generic;

namespace Food_Finder
{
    class Program
    {
        static void Main()
        {
            Stack<char> consonants = new Stack<char>();
            Queue<char> vowels = new Queue<char>();
            char[] vowelsLetters = Console.ReadLine().Replace(" ", "").ToCharArray();
            char[] consonantsLetters = Console.ReadLine().Replace(" ", "").ToCharArray();
            foreach (var ch in vowelsLetters)
            {
                vowels.Enqueue(ch);
            }
            foreach (var ch in consonantsLetters)
            {
                consonants.Push(ch);
            }
            string pear = "pear";
            string flour = "flour";
            string pork = "pork";
            string olive = "olive";

            int pearLength = 4;
            int flourLength = 5;
            int porkLength = 4;
            int oliveLength = 5;
            HashSet<char> cahrs = new HashSet<char>();
            
            int vowelsReps = vowels.Count;
            while (consonants.Count > 0)
            {
                char currConsonant = consonants.Pop();
                char currVowel = vowels.Dequeue();
                if (vowelsReps > 0)
                {
                    if (pear.Contains(currVowel) && pearLength > 0)
                    {
                        pear = pear.Replace(currVowel.ToString(), "");
                        pearLength--;

                    }
                    if (flour.Contains(currVowel) && flourLength > 0)
                    {
                        flour = flour.Replace(currVowel.ToString(), "");
                        flourLength--;
                    }
                    if (pork.Contains(currVowel) && porkLength > 0)
                    {
                        pork = pork.Replace(currVowel.ToString(), "");
                        porkLength--;
                    }
                    if (olive.Contains(currVowel) && oliveLength > 0)
                    {
                        olive = olive.Replace(currVowel.ToString(), "");
                        oliveLength--;
                    }
                    vowelsReps--;
                }


                if (pear.Contains(currConsonant) && pearLength > 0)
                {
                    pear = pear.Replace(currConsonant.ToString(), "");
                    pearLength--;
                }
                if (flour.Contains(currConsonant) && flourLength > 0)
                {
                    flour = flour.Replace(currConsonant.ToString(), "");
                    flourLength--;
                }
                if (pork.Contains(currConsonant) && porkLength > 0)
                {
                    pork = pork.Replace(currConsonant.ToString(), "");
                    porkLength--;
                }
                if (olive.Contains(currConsonant) && oliveLength > 0)
                {
                    olive = olive.Replace(currConsonant.ToString(), "");
                    oliveLength--;
                }
                vowels.Enqueue(currVowel);
            }

            List<string> wordsFound = new List<string>();
            if (pearLength == 0)
            {
                wordsFound.Add("pear");
            }
            if (flourLength == 0)
            {
                wordsFound.Add("flour");
            }
            if (porkLength == 0)
            {
                wordsFound.Add("pork");
            }
            if (oliveLength == 0)
            {
                wordsFound.Add("olive");
            }
            Console.WriteLine($"Words found: {wordsFound.Count}");
            foreach (var word in wordsFound)
            {
                Console.WriteLine(word);
            }
        }

      
    }
}
