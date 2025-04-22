using System;
using System.Runtime.InteropServices.Marshalling;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        { 
        /* IT-1050
           Brian Kummerer
           Lab5
        */        
        //Part1
            Console.WriteLine("Problem 1: Seasons of the Year"); //part 1 title
            string[] season = {"Spring", "Summer", "Fall", "Winter"};
            foreach (string i in season)
            {
                Console.WriteLine("Season: " + i);
            }
            Console.WriteLine();  //add line for readablitiy 

        //Part2
            Console.WriteLine("Problem 2: Days of the Week (1–7)"); //part 2 title
            int d;  // needed to declare "d" before the do loop
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Satruday", "Sunday"};
            Console.WriteLine("Enter a number (1-7)");
            do // do while ensures loop is ran atleast once to give oportunity for user input
            {

                d = int.Parse(Console.ReadLine());
                if (d < 1 || d > 7)
                {
                    Console.WriteLine("Invalid Entry! Please enter a value between 1 and 7");
                } 
            }
            while (d < 1 || d > 7); //condition to guarentee an output
            Console.WriteLine(days[d-1]);
            Console.WriteLine();  //add line for readablitiy 

        //Part3
            Console.WriteLine("Problem 3: Favorite Books and Authors"); //part 3 title
            string[] books = {"The Hobbit", "Charlotte's Web", "1984"};
            string[] authors = {"J.R.R. Tolkien", "E.B. White", "George Orwell"};
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("Book " + (i+1) + " : " + books[i] + " by " + authors[i]);
            }
            Console.WriteLine();  //add line for readablitiy 

        //Part4
            Console.WriteLine("Problem 4: Temperature Tracker"); //Part 4 title
            int[] temperatures = { 65, 72, 78, 70, 68 };
            Array.Sort(temperatures);
            Console.Write("Sorted Temperatures: "); 
            foreach (int i in temperatures)
            {
                Console.Write(" " + i); // used quotes to add a space bewtween #'s & used "Console.Write" to keep all values looped on to same line
            }
            Console.WriteLine(); // Used to print values on next line
            Console.WriteLine("Highest Temperature: " + temperatures.Max());
            Console.WriteLine("Lowest Temperature: " + temperatures.Min());
            Console.WriteLine();  //add line for readablitiy 

        //Part5
            Console.WriteLine("Problem 5: Reverse Countdown"); //part 5 title
            int[] countdown = {5, 4, 3, 2, 1 };
            Array.Reverse(countdown);
            Console.Write("Countdown: " );
            foreach (int i in countdown)
            {
                Console.Write(" " + i); // used quotes to add a space bewtween #'s & used "Console.Write" to keep all values looped on to same line
            }
            Console.WriteLine();  //add line for readablitiy  
            
        }
    }
}
