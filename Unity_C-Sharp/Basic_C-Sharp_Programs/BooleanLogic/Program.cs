using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string Age = Console.ReadLine();
            decimal dAge = decimal.Parse(Age);
            Console.WriteLine("Have you ever had a DUI? Please enter 'true' or 'false.'");
            string DUI = Console.ReadLine();
            bool bDUI = Convert.ToBoolean(DUI);
            Console.WriteLine("How many speeding tickets have you had?");
            string Tickets = Console.ReadLine();
            decimal dTickets = decimal.Parse(Tickets);
            bool Qualified = dAge > 15 && bDUI == false && dTickets <= 3;
            Console.WriteLine("Qualified?\n" + Qualified);
            
        }
    }
}
