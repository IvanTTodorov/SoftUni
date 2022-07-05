using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExtractBytes
{
    class ExtractSpecialBytes
    {
        static void Main(string[] args)
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);

        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            StreamReader streamReader = new StreamReader(bytesFilePath);
            using (streamReader)
            {
                StreamReader streamReader1 = new StreamReader(binaryFilePath);
                using (streamReader1)
                {
                    StreamWriter file = new StreamWriter(outputPath);
                    using (file)
                    {
                        byte[] fileBytes = File.ReadAllBytes(binaryFilePath);
                        var bytesList = new List<String>();
                        var sb = new StringBuilder();

                        while (!streamReader.EndOfStream)
                        {
                            bytesList.Add(streamReader.ReadLine());
                        }
                        foreach (var item in fileBytes)
                        {
                            if (bytesList.Contains(item.ToString()))
                            {
                                sb.AppendLine(item.ToString());
                            }
                        }
                        file.WriteLine(sb.ToString().Trim());
                    }
                }
            }
        }
    }
}