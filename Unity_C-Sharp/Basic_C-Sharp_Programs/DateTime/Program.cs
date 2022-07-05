using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {      
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current time is: " + currentTime.ToString());
            Console.WriteLine("Please input a number.");
            int userInt = Convert.ToInt32(Console.ReadLine());
            DateTime adjusted = currentTime.AddHours(userInt);
            Console.WriteLine("In {0} hours it will be " + adjusted.ToString(), userInt);
        }
    }
}