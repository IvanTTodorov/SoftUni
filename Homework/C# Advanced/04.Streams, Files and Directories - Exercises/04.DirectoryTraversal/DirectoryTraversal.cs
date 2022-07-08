namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath);
            Dictionary<string, List<FileInfo>> fileInfoDict = new Dictionary<string, List<FileInfo>>();

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;

                if (!fileInfoDict.ContainsKey(extension))
                {
                    fileInfoDict.Add(extension, new List<FileInfo>());
                }
                else
                {
                    fileInfoDict[extension].Add(fileInfo);
                }
            }
            
                foreach (var item in fileInfoDict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    string extention = item.Key;
                    Console.WriteLine();
                    List<FileInfo> filesInfo = item.Value;
                    filesInfo.OrderByDescending(x => x.Length); 

                    foreach (var oneFile in filesInfo)
                    {
                        Console.WriteLine($"--{oneFile.Name} - {oneFile.Length / 1024:f3}kb"); 
                    }
                }
            return String.Empty; 
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string pathReport = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(pathReport, textContent);
        }
    }
}
