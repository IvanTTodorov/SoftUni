using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string[] firstSongs = Console.ReadLine().Split(", ");
        

        Queue<string> songs = new Queue<string>(firstSongs);
         while (songs.Count != 0)
        {
            string[] command = Console.ReadLine().Split();
            if (command[0] == "Play")
            {
                songs.Dequeue();
            }
            else if( command[0] == "Add")
            {
                StringBuilder song = new StringBuilder();

                for (int i = 1; i < command.Length; i++)
                {
                    song.Append(command[i] + " ");
                }
                if (songs.Contains(song.ToString().TrimEnd()))
                {
                    Console.WriteLine($"{song}is already contained!");
                }
                else
                {
                    songs.Enqueue(song.ToString().TrimEnd());
                }
            }
            else if (command[0] == "Show")
            {
                Console.WriteLine(String.Join(", ", songs));
            }
        }
         if(songs.Count == 0)
        {
            Console.WriteLine("No more songs!");
        }
    }
}