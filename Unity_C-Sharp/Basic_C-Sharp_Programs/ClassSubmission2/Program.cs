using System;

namespace ClassSubmission2
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondNum=3;
            Console.WriteLine("Pick a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            PracticeClass myObject = new PracticeClass();
            myObject.Division(userNum);
            myObject.Output(userNum, out int result);
            Console.WriteLine(result);
            myObject.Division(userNum, secondNum);
            StaticClass.TestMethod();
        }
    }
}
