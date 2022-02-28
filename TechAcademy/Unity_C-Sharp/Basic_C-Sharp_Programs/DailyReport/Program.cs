using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            short currentPage = Convert.ToInt16(pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string needHelp = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(needHelp);
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            byte studyHours = Convert.ToByte(hoursStudied);
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        }
    }
}
