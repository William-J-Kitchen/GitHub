﻿using System;

namespace BranchingSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Expresss. Please follow the instructions below.\nPlease enter the package weight:");
            int Weight = Convert.ToInt32(Console.ReadLine());
            if (Weight > 50) {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width:");
            int Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int Length = Convert.ToInt32(Console.ReadLine());

            if (Height + Width + Length > 50) {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Environment.Exit(0);
            }

            decimal Total = ((Height * Width * Length) * Weight) / 100;
            string Quote = Total.ToString("0.00");
            Console.WriteLine("Your estimated total for shipping this package is: $" + Quote);
        }
    }
}
