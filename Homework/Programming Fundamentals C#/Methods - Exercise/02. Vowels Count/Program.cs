using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    { 
        string name = Console.ReadLine().ToLower();
        Console.WriteLine(VowelsCount(name));
    }
    static int VowelsCount (string name)
    {
        int vowelCounter = 0;
        for ( int i = 0; i < name.Length; i++ )
        {
            if ( name [i] == 'a' || name [i] == 'u' || name[i] == 'o'  
               || name[i] == 'i' || name[i] == 'e')
            {
                vowelCounter++;
            }
        }
        return vowelCounter;
        
    } 

}