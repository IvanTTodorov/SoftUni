using System;
using System.IO;
namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
                var reader = new StreamReader(inputFilePath);
                using (reader)
                {
                StreamWriter writer = new StreamWriter(outputFilePath);
                    using (writer)
                    {
                        int lineNum = 0;
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            writer.WriteLine(lineNum + " " + line);
                            lineNum++;
                        }

                    }
                }
        }
    }
}
