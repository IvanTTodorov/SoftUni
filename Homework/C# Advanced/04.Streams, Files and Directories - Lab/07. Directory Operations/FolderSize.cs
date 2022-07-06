using System;
using System.IO;
namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"C:\Users\Ivan\Desktop\SoftUni";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            decimal folderSize = 0;
            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);

            foreach (var folder in dirInfo.EnumerateFiles("*.*", SearchOption.AllDirectories))
            {
                folderSize += folder.Length;
            }
            

            StreamWriter writer = new StreamWriter(outputFilePath);
            using (writer)
            {
                writer.Write(folderSize / 1024 + " KB"); 
            }
        }
    }
}
