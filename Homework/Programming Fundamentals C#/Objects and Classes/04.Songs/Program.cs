using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            

            for (int i = 0; i < n; i++)
            { 
                string[] input = Console.ReadLine().Split('_').ToArray();
                Song song = new Song(input[0], input[1], input[2]);
                songs.Add(song);
            }

            string textType = Console.ReadLine();
            if (textType == "all")
            {
                foreach(Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            } 
            else
            {
                List<Song> filteredSong = songs.Where(x => x.TypeList == textType).ToList();  
                foreach (Song song in filteredSong)
                {
                    Console.WriteLine(song.Name);
                }
            }
            
        }
    }
}
class Song
{
   
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

    public Song(string typeList, string name, string time) 
    {
        TypeList = typeList;
        Name = name;
        Time = time; 
    }

  
    }


