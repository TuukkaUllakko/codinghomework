namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class TextInterface
  {
    // Create the userinterface here
    private List<Book> books;
    public TextInterface()
    {
      this.books = new List<Book>();
    }

    public void Start()
    {
      while (true)
      {
        Console.WriteLine("Input the name of the book, empty stops");
        string userInputName = Console.ReadLine();

        if (userInputName == "")
        {
          break;
        }

        Console.WriteLine("Input the age recommendation:");
        string userInputAge = Console.ReadLine();

        if (userInputAge == "")
        {
          break;
        }

        int age = Convert.ToInt32(userInputAge);
        this.books.Add(new Book(userInputName, age));
      }
      Console.WriteLine(books.Count + " books in total.");
      Console.WriteLine("\nBooks:");

      books.Sort();
      
      this.books.ForEach(Console.WriteLine);
    }
  }
}