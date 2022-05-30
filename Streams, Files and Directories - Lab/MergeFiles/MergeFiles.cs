namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using(StreamReader reader = new StreamReader(firstInputFilePath))
            {
                string lineOne = reader.ReadLine();

                using (StreamReader readerTwo = new StreamReader(secondInputFilePath))
                {
                    string lineTwo = readerTwo.ReadLine();
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        while (lineOne != null & lineTwo != null )
                        {
                            writer.WriteLine(lineOne);
                            writer.WriteLine(lineTwo);

                            lineOne = reader.ReadLine();
                            lineTwo = readerTwo.ReadLine();
                        }

                    }
                }
            }
        }
    }
}
