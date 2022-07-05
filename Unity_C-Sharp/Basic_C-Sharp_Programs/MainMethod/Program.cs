using System;
using System.Collections.Generic;


public class Program
{
    public static int mult = 3;
    public static decimal decMult = 3.5m;
    public static string stringMult = "5";
    public static void Main()
    {


        Console.WriteLine(ClassOMethods.Multiplication(mult));
        Console.WriteLine(ClassOMethods.Multiplication(decMult));
        Console.WriteLine(ClassOMethods.Multiplication(stringMult));
    }
}
