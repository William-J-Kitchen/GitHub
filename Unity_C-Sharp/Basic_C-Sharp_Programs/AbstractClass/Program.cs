using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee() { firstName = "Sample", lastName = "Student" };
            Employee.SayName();

        }
    }
}
