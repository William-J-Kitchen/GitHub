using System;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DaysOfTheWeek day;
                Console.WriteLine("Please enter a day of the week.");
                string userInput = Console.ReadLine();
                day=Enum.Parse<DaysOfTheWeek>(userInput);
                int underlyingValue = (int)day;
                Console.WriteLine(underlyingValue);
                //DaysOfTheWeek underlyingValue = (DaysOfTheWeek)day;
                //Console.WriteLine(underlyingValue);
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

        }
    }
    enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
