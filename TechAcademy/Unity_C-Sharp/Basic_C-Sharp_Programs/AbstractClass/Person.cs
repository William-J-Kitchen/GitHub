using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
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
