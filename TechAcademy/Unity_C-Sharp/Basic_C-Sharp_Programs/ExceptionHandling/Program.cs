using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var numList = new List<int> { 12, 14, 62, 3, 10 };
            Console.WriteLine("Pick a number.");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            foreach(int dividend in numList)
            {
                int quotient = dividend / divisor;
                Console.WriteLine(dividend + " divided by " + divisor + " equals " + quotient + ".");
            }

        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Please don't divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
            //database log may go here
        }

    }
}
