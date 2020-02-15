using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      // Remember also to create the file Book.cs and class in it!
      List<Book> book = new List<Book>();

      while(true)
      {
        Console.Write("Name: ");
        String title = Console.ReadLine();
        
        if (title == "")
        {
          break;
        }
        
        Console.Write("Pages: ");
        Int32 pages = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Publication year: ");
        Int32 year = Convert.ToInt32(Console.ReadLine());

        book.Add(new Book(title, pages, year));
      }
      Console.WriteLine();

      Console.Write("What information will be printed? ");
      String input = Console.ReadLine();

      foreach (Book books in book)
      {
        if (input == "everything")
        {
          Console.WriteLine(books);
        }
        else if (input == "title")
        {
          Console.WriteLine(books.title);
        }
        else
        {
          break;
        }
      }

    }
  }
}




