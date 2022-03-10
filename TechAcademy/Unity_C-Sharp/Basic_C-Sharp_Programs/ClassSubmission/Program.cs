using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static float defaultNum = 3.5f;
    public static void Main()
    {
        Console.WriteLine("Pick a number.");
        int userNum = Convert.ToInt32(Console.ReadLine());
        PracticeClass.Division(userNum);
        Console.WriteLine(PracticeClass.Multiplication(userNum));
        Console.WriteLine(PracticeClass.Multiplication(userNum, defaultNum));
    }
}

