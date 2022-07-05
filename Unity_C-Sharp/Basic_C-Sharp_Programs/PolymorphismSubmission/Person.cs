using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSubmission
{
    public abstract class Person
    {
        public string firstName = "";
        public string lastName = "";

        public void SayName(Employee employee)
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

    }
}
