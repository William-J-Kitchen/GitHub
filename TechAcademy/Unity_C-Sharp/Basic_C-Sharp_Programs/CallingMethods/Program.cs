using System;
using System.Collections.Generic;


public class Program
{
    public static int userNumber;
    public static void Main()
    {

        Console.WriteLine("Please input a whole number.");
        userNumber = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine(MathClass.Division(userNumber));
        Console.WriteLine(MathClass.Multiplication(userNumber));
        Console.WriteLine(MathClass.Addition(userNumber));
    }
}
