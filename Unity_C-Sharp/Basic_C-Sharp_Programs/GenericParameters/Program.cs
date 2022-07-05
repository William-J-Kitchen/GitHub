using System;
using System.Collections.Generic;



namespace GenericParameters
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee<string> emp1 = new Employee<string>();
            emp1.things = new List<string>() { "Stuff", "Other", "Etc.", "And what have you" };

            Employee<int> emp2 = new Employee<int>();
            emp2.things = new List<int>() { 7, 5, 3, 4 };

            for (int i = 0; i < emp1.things.Count; i++)
            {
                Console.WriteLine(emp1.things[i] + " and " + emp2.things[i]);
            }
        }
    }
}