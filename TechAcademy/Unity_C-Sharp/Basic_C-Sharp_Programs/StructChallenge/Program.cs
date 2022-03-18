using System;

namespace StructChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Number practice;
            practice.Amount = 12;
            Console.WriteLine(practice.Amount);
        }

    public struct Number { public decimal Amount; }

    }
}
