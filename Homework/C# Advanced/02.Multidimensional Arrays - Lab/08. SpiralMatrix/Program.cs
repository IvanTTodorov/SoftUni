using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        string command = "Right";

        for (int i = 0; i < n * n; i++)
        {
            matrix[row, col] = i + 1;

            if (command == "Right")
            {
                col++;
                if (col == n || matrix[row,col] != 0)
                {
                    col--;
                    
                    command = "Down";
                }
            }
            if (command == "Down")
            {
                row++;
                if (row == n || matrix[row, col] != 0)
                {
                    
                    row--;
                    command = "Left";
                }
            }
            if (command == "Left")
            {
                col--;
                if (col == -1 || matrix[row, col] != 0)
                {

                    col++;
                    command = "Up";
                }
            }
            if (command == "Up")
            {
                row--;
                if (row == -1 || matrix[row,col] != 0)
                {
                    row++;
                    col++;
                    command = "Right";
                }

            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
    
