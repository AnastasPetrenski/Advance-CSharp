using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("ZThe Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 2002);
            Book bookFour = new Book("BTV", 2002);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree, bookFour);

            foreach (var item in libraryTwo)
            {
                Console.WriteLine(item.ToString());
            }

            List<Book> list = new List<Book>();
            list.Add(bookOne);
            list.Add(bookTwo);
            list.Add(bookThree);
            list.Add(bookFour);
            list.Sort(new BookComparator());

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
