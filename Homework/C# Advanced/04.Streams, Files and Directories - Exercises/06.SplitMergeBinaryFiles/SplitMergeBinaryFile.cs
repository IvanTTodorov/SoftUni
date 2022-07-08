using System;
using System.IO;
namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            StreamReader streamReader = new StreamReader(sourceFilePath);
            using (streamReader)
            {
                List<byte> fileBytes = File.ReadAllBytes(sourceFilePath).ToList();



                StreamWriter streamWriter1 = new StreamWriter(partOneFilePath);
                using (streamWriter1)
                {
                    StreamWriter streamWriter2 = new StreamWriter(partTwoFilePath);
                    using (streamWriter2)
                    {
                        List<int> fileListFirst = new List<int>();
                        List<int> fileListSecond = new List<int>();
                        if (fileBytes.Count % 2 == 1)
                        {
                            fileListFirst = fileListFirst.GetRange(0, fileBytes.Count / 2 + 1);
                            fileListSecond = fileListSecond.GetRange(fileBytes.Count / 2 + 1, fileBytes.Count);
                        }
                        else
                        {
                            fileListFirst = fileListFirst.GetRange(0, fileBytes.Count / 2);


                            fileListSecond = fileListSecond.GetRange(fileBytes.Count / 2, fileBytes.Count);
                        }
                    

                    for (int i = 0; i < fileListFirst.Count; i++)
                    {

                        streamWriter1.WriteLine(fileListFirst[i]);
                    }
                    for (int i = 0; i < fileListSecond.Count; i++)
                    {
                        streamWriter2.WriteLine(fileListSecond[i]);
                    }
                }

            }
        }
    }


    public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
    {
        StreamReader streamReader1 = new StreamReader(partOneFilePath);
        using (streamReader1)
        {
            StreamReader streamReader2 = new StreamReader(partTwoFilePath);
            using (streamReader2)
            {
                StreamWriter writer = new StreamWriter(joinedFilePath);
                using (writer)
                {
                    string line1;
                    string line2;

                    while ((line1 = streamReader1.ReadLine()) != null)
                    {
                        writer.WriteLine(line1);
                    }
                    while ((line2 = streamReader2.ReadLine()) != null)
                    {
                        writer.WriteLine(line2);
                    }
                }
            }
        }
    }
}
}
