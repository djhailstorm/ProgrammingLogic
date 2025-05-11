using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

namespace Lab7
{
    /* IT-1050
    Brian Kummerer
    Lab7
    */       
    class Book
    {
        private string title;
        private string author; 

        public Book()  // Default Constructor
        {
            title = "Unknown Title";
            author = "Unkown Author";
        }

        public Book(string title) // Parametized Constructor used for Part2 
        {
            this.title = title;
        }

        public Book(string title, string author) // Overloaded Constructor used for Part3
        {
            this.title = title;
            this.author = author;
        }
        public string GetTitle()
        {
            return this.title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public string GetAuthor()
        {
            return this.author;
        }

        public void SetAuthor(string newAuthor)
        {
            this.author = newAuthor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1"); 
            Book book1 = new Book();
            Console.WriteLine(book1.GetTitle());  // Output: Unknown Title

            book1.SetTitle("C# Fundamentals"); 
            Console.WriteLine(book1.GetTitle());  // Output: C# Fundamentals
            Console.WriteLine();           
           
            Console.WriteLine("Problem 2"); 
            Book book2 = new Book("Learning C#"); 
            Console.WriteLine(book2.GetTitle()); // Output: Learning C# (not "Advanced C#" like your lesson showed, thats for below step)
            Console.WriteLine();
            
            Console.WriteLine("Problem 3"); 
            Book book3 = new Book("Advanced C#", "John Doe"); // Constructor Overload 
            Console.WriteLine("Title: " + book3.GetTitle());
            Console.WriteLine("Author: " + book3.GetAuthor()); 
            Console.WriteLine();

            Console.WriteLine("Problem 4");
            Book book4 = new Book();          
            book4.SetTitle("Mastering C#"); // Setter for Title
            book4.SetAuthor("Jane Smith");  // Setter for Author's name/
            Console.WriteLine("Title: " + book4.GetTitle());  // Getter for Title
            Console.WriteLine("Author: " + book4.GetAuthor()); // Getter for Author             


        }
    }
}
