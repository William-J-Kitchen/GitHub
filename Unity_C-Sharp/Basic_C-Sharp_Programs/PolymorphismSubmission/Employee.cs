using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSubmission
{
    public class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit(Employee Employee)
        {
            Console.WriteLine("The user has quit.");
        }


    }
}
