using System;

namespace OverloadedOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Employee Employee = new Employee() { firstName = "Test", Id = 3000 };
            Employee Employee2 = new Employee() { firstName = "Second", Id = 3001 };

            Console.WriteLine(Employee == Employee2);
            Console.WriteLine(Employee != Employee2);


        }
    }
}
