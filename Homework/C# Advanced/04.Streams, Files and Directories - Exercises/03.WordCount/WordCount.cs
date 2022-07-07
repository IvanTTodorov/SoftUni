using System;
using System.IO;
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
            var reader1 = new StreamReader(wordsFilePath);
            using (reader1)
            {
                var reader2 = new StreamReader(textFilePath);
                using (reader2)
                {
                    var writer = new StreamWriter(outputFilePath);
                    
                        using (writer)
                    {
                        Dictionary<string, int> wordsDict = new Dictionary<string, int>();
                        List <string> line = new List<string>(); 

                        string currentline;
                        while ((currentline= reader1.ReadLine()) != null) 
                        {
                            string[] arr = currentline.Split();
                            for (int i = 0; i < arr.Length; i++)
                            {
                                line.Add(arr[i]);
                            }
                        }

                        string currentLine2 = string.Empty;
                        while ((currentLine2 = reader2.ReadLine()) != null)
                        {
                            
                            string[] arr = currentLine2.Split();
                           
                            for (int i = 0; i < arr.Length; i++)
                            {
                                string word = arr[i];
                                
                                for (int j = 0; j < word.Length; j++)
                                {
                                    if(!char.IsLetter(word[j]))
                                    {
                                        word = word.Remove(j, 1);  
                                    }
                                    word = word.ToLower(); 
                                }
                                if (line.Contains(word))
                                {
                                    if(!wordsDict.ContainsKey(word))
                                    {
                                        wordsDict.Add(word, 1); 
                                    }
                                    else
                                    {
                                        wordsDict[word]++; 
                                    }
                                } 
                            }


                        }
                        
                        foreach(var item in wordsDict.OrderByDescending(x=>x.Value))
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }

                        
                    }
                }
            }
            

            
        }
    }
}
