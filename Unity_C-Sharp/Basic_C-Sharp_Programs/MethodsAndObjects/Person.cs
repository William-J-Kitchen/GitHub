using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{
    public class Person
    {
        public string FirstName = "";
        public string LastName = "";
        public void SayName(Employee employee)
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
