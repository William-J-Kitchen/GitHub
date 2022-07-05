using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            
            Employee.SayName(Employee);
        }
    }
}
