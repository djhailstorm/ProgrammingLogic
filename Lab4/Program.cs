using System;
using System.Security;
namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        { 
        /* IT-1050
           Brian Kummerer
           Lab4
        */        
        //Part1
            Console.WriteLine("Problem 1: Simple For Loop"); //part 1 title
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();  //add line for readablitiy 

        //Part2
            Console.WriteLine("Problem 2: Even Numbers from 1 to 20"); //part 2 title

            for (int i = 1; i <=20; i++)
            {
                if (i % 2 == 0)
                {
                   Console.WriteLine(i);
                }
            }
            Console.WriteLine();  //add line for readablitiy 

        //Part3
            Console.WriteLine("Problem 3: While Loop Countdown"); //part 3 title
            int l = 5;
            while (l >= 1)
            {
               Console.WriteLine(l);
               l--;
            }
            Console.WriteLine();  //add line for readablitiy 

        //Part4
            Console.WriteLine("Problem 4: Do/While User Input"); //Part 4 title
            int d = 0;
            do
            {
               Console.Write("Enter a value Greater than 100: ");
               d = int.Parse(Console.ReadLine());               
            }
            while (d <= 100);
            Console.WriteLine();  //add line for readablitiy 

        //Part5
            Console.WriteLine("Problem 5: While Loop Multiples of 10 from 10 to 1000"); //part 5 title
            int v = 10;
            while (v <= 1001)
            {
                Console.WriteLine(v);
                v = v + 10;
            }
             Console.WriteLine();  //add line for readablitiy 

        //Part6     
            Console.WriteLine("Problem 6: Pattern Printer (Using Nested Loops)"); //Part 6 title       
            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
