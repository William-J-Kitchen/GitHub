using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nHourly Rate?");
            string P1Hourly = Console.ReadLine();
            decimal dP1Hourly = decimal.Parse(P1Hourly);
            Console.WriteLine("Hours worked per week?");
            string P1WeeklyHours = Console.ReadLine();
            decimal dP1WeeklyHours = decimal.Parse(P1WeeklyHours);
            Console.WriteLine("Person 2\nHourly Rate?");
            string P2Hourly = Console.ReadLine();
            decimal dP2Hourly = decimal.Parse(P2Hourly);
            Console.WriteLine("Hours worked per week?");
            string P2WeeklyHours = Console.ReadLine();
            decimal dP2WeeklyHours = decimal.Parse(P2WeeklyHours);
            Decimal dP1Salary = dP1Hourly * dP1WeeklyHours * 52;
            Console.WriteLine("Annual Salary of Person 1:\n" + dP1Salary);
            Decimal dP2Salary = dP2Hourly * dP2WeeklyHours * 52;
            Console.WriteLine("Annual Salary of Person 2:\n" + dP2Salary);
            bool greater = dP1Salary > dP2Salary;
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + greater);
            Console.ReadLine();
        }
    }
}
