using System;
using System.Runtime.InteropServices.Marshalling;

namespace Lab6
{
    /* IT-1050
    Brian Kummerer
    Lab6
    */       
    class Car
    {
        public string model = default!; // tired of look at the "CS8618" error 
        public string color = default!; // tired of look at the "CS8618" error 
        public int year;
        

        // Example method to display car details. You can use this as an example for the other methods.
        public void Display()
        {
            Console.WriteLine(); // making runtime more readable           
            Console.WriteLine("Car Details:");
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Year: " + year);
            Console.WriteLine(); // making runtime more readable
        }
        // Part 1 method Start 
        public void Start()
        {
            Console.WriteLine("The car is starting.");
        }
        // Part 2 method Drive
        public void Drive(int miles)
        {
            Console.WriteLine("The car drove " + miles + " miles.");
        }
        // Part 3 method GetDescription
        public void GetDescription()
        {
            string getDescription= $"{year} {color} {model}"; // used for clean spacing instead of adding space on sides of parameters
            Console.WriteLine(getDescription);
        }
        // Part 4 method Repaint
        public void Repaint(string newColor)
        {
            color = newColor; // string parameter updates color
            Console.WriteLine("The car has been repainted to " + color + ".");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating a Car object and assigning values to its properties
            Car myCar = new Car();
            myCar.model = "Civic";
            myCar.color = "Black";
            myCar.year = 2020; 

            myCar.Display(); // Calling the Display method
            myCar.Start(); // Calling Start method
            myCar.Drive(50); // Calling Drive method and passes parameter 50
            myCar.GetDescription(); // Calling Drive method
            myCar.Repaint("Red"); // Calling Repaint method and passing parameter "Red"
            Console.WriteLine(); // making runtime more readable
        }
    }
}   