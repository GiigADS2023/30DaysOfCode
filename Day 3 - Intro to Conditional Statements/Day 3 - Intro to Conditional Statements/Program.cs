using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3___Intro_to_Conditional_Statements
{
    internal class Program
    {
        static bool checkNumber(int myNumber)
        {
            bool isOdd_number = false;
            int rem = myNumber % 2;
            isOdd_number = rem != 0;
            return isOdd_number;
        }

        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());

            bool isOdd = checkNumber(N);

            if (isOdd) Console.WriteLine("Weird");
            else
            {
                if ((N >= 2) && (N <= 5))
                {
                    Console.WriteLine("Not Weird");
                }
                else
                {
                    if ((N >= 6) && (N <= 20))
                    {
                        Console.WriteLine("Weird");
                    }
                    else
                    {
                        if (N > 20) Console.WriteLine("Not Weird");
                    }
                }
            }
        }
    }
}
