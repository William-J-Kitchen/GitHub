﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadedOperators
{
    public class Employee
    {
        public string firstName { get; set; }
        public int Id { get; set; }

        public static bool operator== (Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }
        public static bool operator!= (Employee emp13, Employee emp23)
        {
            return emp13.Id != emp23.Id;
        }
    }
}
