using System;
using System.Collections.Generic;
using System.Text;


public static class Experiment
{
    public static int Optional (int test1, int test2 = 1)
    {
        return (test1 * test2 * 2);
    }
    public static int Optional2 (int uservalue, int uservalue2 = 1)
    {
        return (uservalue / uservalue2);
    }
}
