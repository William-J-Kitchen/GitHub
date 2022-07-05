using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { FirstName = "Busta", LastName = "Move", ID = 707 });
            employees.Add(new Employee() { FirstName = "Kevin", LastName = "Bogart", ID = 101 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Swancy", ID = 202 });
            employees.Add(new Employee() { FirstName = "Softie", LastName = "Tools", ID = 404 });
            employees.Add(new Employee() { FirstName = "Mason", LastName = "Free", ID = 505 });
            employees.Add(new Employee() { FirstName = "Linda", LastName = "Rodriguez", ID = 606 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Hill", ID = 4 });
            employees.Add(new Employee() { FirstName = "Mai", LastName = "Thyme", ID = 111 });
            employees.Add(new Employee() { FirstName = "Thanh", LastName = "Huin", ID = 112 });
            employees.Add(new Employee() { FirstName = "Melvin", LastName = "Brogglesnort", ID = 1 });

            foreach (Employee Employee in employees)
            {
                if (Employee.FirstName == "Joe")
                {
                    Console.WriteLine(Employee.FirstName + " " + Employee.LastName);
                }
            }

            foreach (Employee Employee in employees.Where(x => x.FirstName == "Joe"))
            {
                Console.WriteLine(Employee.FirstName + " " + Employee.LastName);

            }
            foreach (Employee Employee in employees.Where(x => x.ID > 5))
            {
                Console.WriteLine(Employee.FirstName + " " + Employee.LastName + " " + Employee.ID);
            }

        }
    }
}
