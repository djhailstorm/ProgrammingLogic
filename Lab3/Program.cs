using System;
using System.Security.Principal;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        { 
        /* IT-1050
           Brian Kummerer
           Lab2    
        */        
        //Part1
            int a = 10;
            int b = 5;
            int c = 15;
 
            String result1 = (a > b) ? "True" : "False";
            {
                Console.WriteLine("a > b: " + result1);
            } 

            String result2 = (a < c) ? "True" : "False";
            {
                Console.WriteLine("a < c: " + result2);
            } 
   
             String result3 = (a > b && a > c) ? "True" : "False";
            {
                Console.WriteLine("a > b && a > c: " + result3);
            } 
 
              String result4 = (a > b || a > c) ? "True" : "False";
            {
                Console.WriteLine("a > b || a > c: " + result4);
            } 
 
        //Part2
            bool isRaining = true;
            bool haveUmbrella = false;
            if (isRaining == true && haveUmbrella == false)
            {
                Console.WriteLine("Take an umbrella!");
            }
            else
            {
                Console.WriteLine("You're good to go!");
            }

        //Part3
            Console.WriteLine("What's your age?");
            int age= int.Parse(Console.ReadLine());  
            if (age <5)
            {
                Console.WriteLine("Ticket is free!");
            } 
            else if (age >= 5 && age < 13)
            {
                Console.WriteLine("Child ticet: $5");
            }
            else if (age >= 13 && age < 65)
            {   
                Console.WriteLine("Standard ticket: $10");
            }
            else
            {
                Console.WriteLine("Senior ticket: $6");
            }

        //Alternate Part3
        //    Console.WriteLine("What's your age?");
        //    int ticketPrice = int.Parse(Console.ReadLine());
        //    switch(ticketPrice)
        //    {
        //        case  < 5:
        //            Console.WriteLine("Ticket is free!");
        //            break;
        //        case  >= 5 and < 13: //starting in c# 9 you can use "and" to compare case variable
        //            Console.WriteLine("Child ticet: $5");
        //            break;
        //        case int i when i >= 13 && i < 65: // starting in c# 7 range based switching became available 
        //           Console.WriteLine("Standard ticket: $10");
        //            break;
        //        case int i when i >= 65:
        //            Console.WriteLine("Senior ticket: $6");
        //            break;
        //    }

        //Part4
            Console.WriteLine("Enter day of the week (1-7)");
            int dayofWeek = int.Parse(Console.ReadLine());
            switch(dayofWeek)   
            {
                case 1:
                  Console.WriteLine("Monday");
                  break;
                case 2:
                  Console.WriteLine("Tuesday");
                  break;
                case 3:
                  Console.WriteLine("Wednesday");
                  break;
                case 4:
                  Console.WriteLine("Thursday");
                  break;
                case 5:
                  Console.WriteLine("Friday");
                  break;
                case 6:
                  Console.WriteLine("Saturday");
                  break;
                case 7:
                  Console.WriteLine("Sunday");
                  break;
                default:
                  Console.WriteLine("Invalid day!");
                  break;
            }
        }
    }
}
