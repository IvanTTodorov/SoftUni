using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int counter = 1000000;
        int containsCounter = 100000; 

        List<string> list = new List<string>(counter);
        HashSet<string> hash = new HashSet<string>(counter);
        StringHashSet ourSet = new StringHashSet(counter);

        for (int i = 0; i < counter; i++)
        {
            list.Add(i.ToString());
            hash.Add(i.ToString());
            ourSet.Add(i.ToString());
        }
        Console.WriteLine("Start:");
        var timer = Stopwatch.StartNew();

        /* for (int i = 0; i < containsCounter; i++)
        {
            bool exist = list.Contains(i.ToString()); 
        }
        
        timer.Stop();
        Console.WriteLine("List:");
        Console.WriteLine(timer.ElapsedMilliseconds);
        timer.Reset();
        timer.Start(); */

        for (int i = 0; i < containsCounter; i++)
        {
            bool exist = hash.Contains(i.ToString());
        }

        timer.Stop();
        Console.WriteLine("Hash of C#:");
        Console.WriteLine(timer.ElapsedMilliseconds);
        timer.Reset();
        timer.Start();

        for (int i = 0; i < containsCounter; i++)
        {
            bool exist = ourSet.Contains(i.ToString());
        }

        timer.Stop();
        Console.WriteLine("Ours:");
        Console.WriteLine(timer.ElapsedMilliseconds);
        timer.Reset();
        timer.Start();
    }
    static string GenerateString(int length=8)
    {

        StringBuilder sb = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            sb.Append(random.Next(0, 9)); 
        }
        return sb.ToString();
    }
}

public class StringHashSet
{
    private SetElement[] array;
    public StringHashSet(int capacity = 8)
    {
        array = new SetElement[capacity];
    }
    public void Add(string key)
    {
        int index = HashFunction(key);
        if (array[index] != null)
        {
            array[index].Keys.Add(key);
        }
        else
        {
            array[index] = new SetElement() { Keys = new List<string>() { key } };
        }

    }
    private int HashFunction(string key)
    {
        return Math.Abs(key.GetHashCode() % array.Length);
        /* int asciiResult = key[0] << 5 | key[key.Length - 1] >> 4;
        return asciiResult % array.Length;
        */
    }
    public bool Contains(string key)
    {
        int index = HashFunction(key);
        if (array[index] != null)
        {
            for (int i = 0; i < array[index].Keys.Count; i++)
            {
                if (array[index].Keys[i] == key)
                {
                    return true;
                }
            }

        }
        return false;
    }
}
public class SetElement
{
    public List<string> Keys { get; set; }
}
