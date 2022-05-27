using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();


            while (text != "find")
            {
                StringBuilder output = new StringBuilder();
                int count = 0;
                for (int y = 0; y < text.Length; y++)
                {
                    char result = Convert.ToChar(text[y] - keys[count]);
                    count++;
                    if (count == keys.Length)
                    {
                        count = 0;
                    }
                    output.Append(result);
                }
                string newtext = output.ToString();
                string type = Type(newtext);

                string coordinates = Coordinates(newtext);

                Console.WriteLine($"Found {type} at {coordinates}");



                text = Console.ReadLine();

            }
            
        }
        public static string Type(string newText)
        {
            int indexFirst = int.Parse(newText.IndexOf('&').ToString()) + 1;
            int indexSecond = int.Parse(newText.IndexOf('&', indexFirst + 1).ToString());
            int lengthType = indexSecond - indexFirst;
            string type = newText.Substring(indexFirst, lengthType);

            return type;
        }
        public static string Coordinates(string newText)
        {
            int indexFirst = int.Parse(newText.IndexOf('<').ToString()) + 1;
            int indexSecond = int.Parse(newText.IndexOf('>', indexFirst + 1).ToString());
            int lengthCoordinate = indexSecond - indexFirst;
            string coordinate = newText.Substring(indexFirst, lengthCoordinate);

            return coordinate; 
        }

    }
}