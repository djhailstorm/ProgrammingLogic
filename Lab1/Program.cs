using System;
class Program
{
  static void Main(string[] args)
  {
    // Step 1
    Console.WriteLine("Brian Kummerer");
    // Step 2
    /* Name:  Brian Kummerer
       Title: IT-1050 - Lab1  
    */
    //   
    // Step 3 
    int favoriteNumber = 7;
    string favoriteLanguage = "C++";
    double previousPrograms = 99.5;
    bool programmingExp = true;
    // Step 4
    Console.WriteLine("My favorite number is " + favoriteNumber);
    Console.WriteLine("My favorite Programming Language is " + favoriteLanguage);
    Console.WriteLine("I have previously written over " + previousPrograms + " Programs");
    if (programmingExp = true)
        {
        Console.WriteLine("I do have previous Programming Experience");
        } 
    else if (programmingExp = false) 
        {
        Console.WriteLine("I do not have previous Programming Experience");    
        } 
    //Step 5
    const string schoolName = "Cuyahoga Community College";
    Console.WriteLine(schoolName);

  }

}