using System;

namespace OverloadedOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            public static bool operator == (Employee Id, Employee Id2)
            {
            if (Id == Id2)
            {  
                return true;
            }
            else
            {
                return false;
            }
            
            }

            public static bool operator != (Employee Id, bool test)
            {
            return false;
            }
        }
    }
}
