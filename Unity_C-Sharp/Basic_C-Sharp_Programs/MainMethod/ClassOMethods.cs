using System;
using System.Collections.Generic;
using System.Text;


public static class ClassOMethods
{
    public static int Multiplication(int mult)
    {
        return (mult * 3);
    }

    public static int Multiplication(decimal decMult)
    {
        int x = Convert.ToInt32(decMult * 3m);
        return (x);
    }

    public static int Multiplication(string stringMult)
    {
        int y = Convert.ToInt32(stringMult);
        return (y * 3);
    }
}

