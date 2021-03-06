﻿using System;

namespace SystemConsole
{
    /*
     * The Console class encapsulates input, output, and error-stream manipulations for console-based applications.
     */
    class ProgramBasicConsoleIo
    {
        static void Main(string[] args)
        {
            Console.Title = "Basic Console I/O";
            
            Console.WriteLine();
            GetUserData();

            Console.WriteLine();
            FormatNumericalData();

            Console.WriteLine();
            DisplayMessage();

            Console.ReadLine(); // Wait for Enter key to be pressed before shutting down.
            Console.Clear();
        }

        static void GetUserData()
        {
            // Get name and age.
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string userAge = Console.ReadLine();

            // Change echo color, just for fun.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Echo to the console.
            Console.WriteLine("Hello {0}! You are {1} years old.",
            userName, userAge);

            // Restore previous color.
            Console.ForegroundColor = prevColor;
        }

        // Make use of format tags embedded within string literals.
        static void FormatNumericalData()
        {
            ConsoleColor prevColor = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);

            // Notice that upper- or lowercasing for hex determines if letters are upper- or lowercase.
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);

            Console.BackgroundColor = prevColor;
        }

        // Make use of string formatting characters 
        static void DisplayMessage()
        {
            // Using string.Format() to format a string literal.
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);

            // Pop up a message window by referencing PresentationFramework.dll
            System.Windows.MessageBox.Show(userMessage);
        }



    }
}
