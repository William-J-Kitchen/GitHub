﻿using System;

namespace VariableAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + favoriteNumber);
            //Console.ReadLine();

            bool isStudying = true;
            byte HoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';
            decimal moneyInBank = 100.5m; //mostly used for financial transactions
            double heightInCentimeters = 211.3022020185;
            float secondsLeft = 2.62f;
            short temperatureOnMars = -341;
            string myName = "Bill";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);

            Console.WriteLine(questionMark);
            Console.ReadLine();

        }
    }
}
