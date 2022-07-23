using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            Book one = (new Book("Animal Farm", 2003,"George Orwell"));
            Book two = (new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace"));
            Book three = (new Book("The Documents in the Case", 1930,"-"));
            Library libraryOne = new Library();
            Library libraryTwo = new Library(one,two,three);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine($"{book.Title} -> {book.Year} -> {String.Join(" & ", book.Authors)}");
            }
        }
    }
}