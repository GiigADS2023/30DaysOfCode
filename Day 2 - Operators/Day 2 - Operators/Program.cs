﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2___Operators
{
    internal class Program
    {
        class Result
        {

            /*
             * Complete the 'solve' function below.
             *
             * The function accepts following parameters:
             *  1. DOUBLE meal_cost
             *  2. INTEGER tip_percent
             *  3. INTEGER tax_percent
             */

            public static void solve(double meal_cost, int tip_percent, int tax_percent)
            {
                double meal_tip = tip_percent;

                meal_tip = meal_cost * (meal_tip / 100);

                double meal_tax = tax_percent;

                meal_tax = meal_cost * (meal_tax / 100);

                double totalCost = meal_cost + meal_tip + meal_tax;

                int roundTotal = Convert.ToInt32(Math.Round(totalCost));

                Console.WriteLine(roundTotal);
            }
        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            Result.solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
