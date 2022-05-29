namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using(StreamReader reader = new StreamReader(wordsFilePath))
            {
                string[] words = reader.ReadLine().Split(" ");
                Dictionary<string, int> kvp = new Dictionary<string, int>();

                for (int i = 0; i < words.Length; i++)
                {                   
                        kvp.Add(words[i], 0);
                }

                using(StreamReader readerTwo = new StreamReader(textFilePath))
                {
                    
                    string lineToSearch = readerTwo.ReadLine();
                    while (lineToSearch != null)
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            if (lineToSearch.Contains(words[i]))
                            {
                                kvp[words[i]]++;
                            }
                        }
                        lineToSearch = readerTwo.ReadLine();
                    }
                    
                }
                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    var orderd = kvp.OrderByDescending(x => x.Value);
                    foreach (var word in orderd)
                    {
                        Console.WriteLine($"{word.Key} - {word.Value}");
                    }
                }


            }

        }
    }
}
