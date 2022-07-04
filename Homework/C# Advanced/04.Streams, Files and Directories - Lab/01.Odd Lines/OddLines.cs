
using System;
using System.IO; 

namespace OddLines
{
    using System;
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\input.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            using (reader)
            {
                var writer = new StreamWriter(outputFilePath);
                using (writer)
                {
                    int line = 0;
                    string lineString;
                    while((lineString = reader.ReadLine()) != null)
                    {
                        if (line % 2 == 1)
                        {
                            writer.WriteLine(lineString);
                            
                        }
                        line++;
                    }
                    
                }
            }
        }
    }
}
