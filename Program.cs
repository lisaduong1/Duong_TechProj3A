using System;
using System.Linq;
/*
* Author: Lisa Duong
* Assignment: Tech Project #3A
* Class: ISM4300.001
* Due Date: 9/24/20
*/
namespace Duong_TechProj3A
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
            //calls mymethod
        }
        static void MyMethod()
        {
            try
            {
                Console.WriteLine("Please enter your name:");
                //asks user input
                string input = Console.ReadLine();
                //reads input
                if(input.All(char.IsDigit))
                {
                    Console.WriteLine("Please enter a correct input.");
                    Console.WriteLine("Press any key to exit program.");
                    //if input is digits, this outputs
                }
                else
                {
                    Console.WriteLine("Hello " + input + "!");
                    Console.WriteLine("Press any key to exit program.");
                    //checks if input is letters and ouputs
                }
            }
            catch
            {
                Console.WriteLine("Please enter a correct input.");
                Console.WriteLine("Press any key to exit program.");
                //catch any exceptions
            }
        }
    }
}
