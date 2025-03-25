using System;

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
        	int myInt = 0;
            double myDouble = 0.00000D;
            float myFloat = 0.00F;
            char myChar = '0';
            bool myBool = false;
            string myString = "\"undefined\"";
			Console.WriteLine("Part 1: Variable Declaration");
            Console.WriteLine("myInt = " + myInt);
            Console.WriteLine("myDbouble = " + myDouble);
            Console.WriteLine("myFloat = " + myFloat);
            Console.WriteLine("myChar = " + myChar);
            Console.WriteLine("myBool = " + myBool);
            Console.WriteLine("myString = " + myString);
            Console.WriteLine(); //add a blank line between sections

		//Part2
            myDouble = 9.78d;
            myInt = (int) myDouble;
            Console.WriteLine("Part 2: Type Casting");
            Console.WriteLine("myDouble = " + myDouble);            
            Console.WriteLine("myInt = " + myInt);
		    Console.WriteLine("\"myInt\"  as string: " + Convert.ToString(myInt));
            Console.WriteLine("\"myBool\" as string: " + Convert.ToString(myBool));
            Console.WriteLine(); //add a blank line between sections
            
        //Part3
            Console.WriteLine("Part 3: User Input and Type Conversion");
            Console.WriteLine("Enter your name....");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age....");
            int intAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {userName}, I see that you are {intAge} years old"); 
            Console.WriteLine(); //add a blank line between sections
            
        //Part4
            int num1 = 10; //use a positive value to prevent decimals
            int num2 = 12; //use a positive value to prevent deciamls
            Console.WriteLine("Part 4: Arithmetic Operators");
            Console.WriteLine($"num1 = {num1}");
            Console.WriteLine("First Add 10            = " + (num1 += 10));
            Console.WriteLine("Next Subtract 2         = " + (num1 -= 2));
            Console.WriteLine("Next Multiply by 3      = " + (num1 *= 3));
            Console.WriteLine("Now Divide by 2         = " + (num1 /= 2));
            Console.WriteLine("Finally Modulus 2       = " + (num1 %= 2));
            Console.WriteLine(); 
            Console.WriteLine($"num2 = {num2}");
            Console.WriteLine("Add 10 to \"num2\"        = " + (num2 + 2));
            Console.WriteLine("Subtract 2 from \"num2\"  = " + (num2 - 2));
            Console.WriteLine("Multiply \"num2\" by 3    = " + (num2 * 3));
            Console.WriteLine("Divide \"num2\" by 2      = " + (num2 / 2));
            Console.WriteLine("Modulus 2 of \"num2\"     = " + (num2 % 2));  
            Console.WriteLine();
        //Part5
            float myFloat2 = 1.123456789F;
            double myDouble2 = 1.123456789D;
            Console.WriteLine("Part 5: Floating Point Precision");
            Console.WriteLine(myFloat2);
            Console.WriteLine(myDouble2);
            Console.WriteLine("(The Float variable rounded the 7th digit)");
            Console.WriteLine(); 
        //Part6
            int myInt2 = 10;
            Console.WriteLine("Part 6: Increment and Decrement"); 
            Console.WriteLine("myInt2 initial value   = " + myInt2);
            myInt2++;
            Console.WriteLine($"Increase \"myInt2\" by 1 = {myInt2}");
            myInt2--;
            Console.WriteLine($"Decrease \"myInt2\" by 1 = {myInt2}");
        }
    }
}

