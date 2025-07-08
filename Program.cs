using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgBasicsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            // Declare variables to store user input
            string myName;
            int myAge;
            int myId;

            // Ask for the user's name and store it in myName
            Console.WriteLine("Enter your name:");
            myName = Console.ReadLine();

            // Ask for the user's ID number and convert it to int (using long to avoid overflow on large IDs)
            Console.WriteLine("Enter your ID number:");
            myId = (int)Convert.ToInt64(Console.ReadLine());

            // Ask for the user's age and convert it to an integer
            Console.WriteLine("Enter your age:");
            myAge = Convert.ToInt32(Console.ReadLine());

            // Display the minimum and maximum values between 1 and 4
            Console.WriteLine(Math.Min(1, 4)); // Outputs: 1
            Console.WriteLine(Math.Max(1, 4)); // Outputs: 4

            // Work with a string and display its length
            string text = "uhaiodhweiohweyfweiffhwflilbflq";
            Console.WriteLine("The length of the text is: " + text.Length); // Outputs: 30

            // Convert a string to upper and lower case
            string name = "mahlangu";
            Console.WriteLine("The capital letter of name: " + name.ToUpper()); // Outputs: MAHLANGU
            Console.WriteLine("The lower case of name is: " + name.ToLower());  // Outputs: mahlangu

            // Declare variables for mathematical comparison
            int num1, num2;

            // Get the first number from user
            Console.WriteLine("Enter the value:");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Get the second number from user
            Console.WriteLine("Enter the value:");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Display the smaller of the two numbers entered
            Console.WriteLine(Math.Min(num1, num2));
        }
    }
}
