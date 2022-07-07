using System;
using System.Collections.Generic;
using System.IO;

namespace MergeFiles
{
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
            var reader1 = new StreamReader(firstInputFilePath);
            using (reader1)
            {
                var reader2 = new StreamReader(secondInputFilePath);
                using (reader2)
                {
                    var writer = new StreamWriter(outputFilePath);
                    using (writer)
                    {
                        
                        string line1;
                        string line2;

                        int bestLength = 0;
                        List<string> fileLine1 = new List<string>();
                        List<string> fileLine2 = new List<string>();

                        while ((line1 = reader1.ReadLine()) != null)
                        {
                            fileLine1.Add(line1); 
                        }
                        while ((line2 = reader2.ReadLine()) != null)
                        {
                            fileLine2.Add(line2); 

                        }
                        if (fileLine1.Count > fileLine2.Count)
                        {
                            bestLength = fileLine1.Count; 
                        }
                        else
                        {
                            bestLength = fileLine2.Count; 
                        }
                        for (int i = 0; i <= bestLength; i++)
                        {
                            i = 0;
                            if(fileLine1.Count != 0)
                            {
                                writer.WriteLine(fileLine1[i]);
                                fileLine1.Remove(fileLine1[i]);
                            }
                            if (fileLine2.Count != 0)
                            {
                                writer.WriteLine(fileLine2[i]);
                                fileLine2.Remove(fileLine2[i]); 
                            }
                            bestLength--;
                        }
                        
                    }
                }
            }
        }
    }
}
