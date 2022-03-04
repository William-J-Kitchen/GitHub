using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        string[] stringArray1 = { "Hello", "my", "name", "is", "Atilla." };
        Console.WriteLine("Please enter a number, 0-4.");
        string IndexString = Console.ReadLine();
        int IndexInt = Convert.ToInt32(IndexString);
        if (IndexInt > stringArray1.Length)
        {
            Console.WriteLine("The entry doesn't meet the requirements. Please enter a number between 1 & 5.");
        }
        else
        {
            Console.WriteLine(stringArray1[IndexInt]);
        }

        int[] intArray1 = { 0, 1, 2, 3, 4 };
        Console.WriteLine("Please enter a number, 0-4.");
        string IndexInteger = Console.ReadLine();
        int IndexInt2 = Convert.ToInt32(IndexInteger);
        if (IndexInt2 > intArray1.Length)
        {
            Console.WriteLine("The entry doesn't meet the requirements. Please enter a number between 1 & 5.");
        }
        else
        {
            Console.WriteLine(intArray1[IndexInt2]);
        }

        List<string> StringList = new List<string> { "String 1", "String 2", "String 3", "String 4", "String 5" };
        Console.WriteLine("Please enter a number, 0-4.");
        string IndexList = Console.ReadLine();
        int IndexInt3 = Convert.ToInt32(IndexList);
        Console.WriteLine(StringList[IndexInt3]);
    }
}

