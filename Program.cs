using System;
using System.Collections.Generic;
using System.Linq; // Add this namespace

class Program
{
    static void Main(string[] args)
    {
        var myBooks = new List<Book>
        {
            new Book() { Title = " Advance C# ", Price = 9.99},
            new Book() { Title = " OOP with C# ", Price = 14.99 },
            new Book() { Title = " C# For beginners ", Price = 19.99 },
            new Book() { Title = " Complete ASP.NET ", Price = 29.99 }
        };

        Console.WriteLine("LINQ-Essentials");

        // Without LINQ: for each aspect your have to write a loop and a if statement
        /*foreach (var book in myBooks)
        {
            if (book.Title.Contains("C#"))
            {
                Console.WriteLine(book.Title);
            }
        }*/

        /* With LINQ: using lambda where we define a variable that allows us to 
           exectute sql base statement a filter the data         
        */
        Console.WriteLine("Print titles of books that contains c#");
        var booksList = myBooks.Where(book => book.Title.Contains("C#")).ToList();
        foreach (var book in booksList)
        {
            Console.WriteLine(book.Title);
        }
        Console.WriteLine("\n");
        Console.WriteLine("Print titles of books that contains c# versione2");
        var booksTitle = myBooks.Where(book => book.Title.Contains("C#")).Select(book => book.Title);
        foreach (var book in booksTitle)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine("\n");
        Console.WriteLine("Print titles of books that contains c# and get only price");
        var booksPrice = myBooks.Where(book => book.Title.Contains("C#")).Select(book => book.Price);
        foreach (var book in booksPrice)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine("\n");
        Console.WriteLine("Print titles of books that contains c# and ordered by title");
        var orderedBooks = myBooks.Where(book => book.Title.Contains("C#")).OrderBy(book => book.Title);
        foreach (var book in orderedBooks)
        {
            Console.WriteLine(book.Title);
        }
        Console.WriteLine("\n");
        Console.WriteLine("Print titles of books that contains c# ordered by title and get only title");
        var orderedBooks2 = myBooks.Where(book => book.Title.Contains("C#"))
        .OrderBy(book => book.Title).Select(book => book.Title);
        foreach (var book in orderedBooks2)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine("\n");



    }
}