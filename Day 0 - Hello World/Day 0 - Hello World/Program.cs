﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_0___Hello_World
{
    internal class Program
    {
        static void Main(String[] args)
        {
            // Declare a variable named 'inputString' to hold our input.
            String inputString;

            // Read a full line of input from stdin (cin) and save it to our variable, input_string.
            inputString = Console.ReadLine();

            // Print a string literal saying "Hello, World." to stdout using cout.
            Console.WriteLine("Hello, World.");

            // TODO: Write a line of code here that prints the contents of input_string to stdout.
            Console.WriteLine(inputString);
        }
}
