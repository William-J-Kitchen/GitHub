using System;
public class Program
{
    public static int test1 = 3;
    public static int test2 = 4;
    public static int userValue, userValue2;
    static int result;
    
    public static void Main()
    {
        Console.WriteLine(Experiment.Optional(test1, test2));
        Console.WriteLine("Please input a number.");     
        if (!int.TryParse(Console.ReadLine(), out userValue))
            throw new ArgumentException("This is not a valid number.");
        Console.WriteLine("Optionally, input a second number.");
        if (int.TryParse(Console.ReadLine(), out userValue2))
            result = Experiment.Optional2(userValue, userValue2);
        else
            result = Experiment.Optional2(userValue);
        Console.WriteLine(result);
    }
}

