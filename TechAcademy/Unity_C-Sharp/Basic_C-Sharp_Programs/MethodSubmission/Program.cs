using System;
public class Program
{
    public static int test1 = 3;
    public static int test2 = 4;
    
    public static void Main()
    {
        Console.WriteLine(Experiment.Optional(test1, test2));
        Console.WriteLine("Please input a number.");
        int divisor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Optionally, input a second number.");
        int dividend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Experiment.Optional2(divisor, dividend));
    }
}

