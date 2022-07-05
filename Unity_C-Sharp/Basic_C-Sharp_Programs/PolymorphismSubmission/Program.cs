using System;

namespace PolymorphismSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee() { firstName = "Sample", lastName = "Student" };
            Employee.SayName(Employee);

            IQuittable Quitter = new Employee();
            Quitter.Quit(Employee);
        }
    }
}
