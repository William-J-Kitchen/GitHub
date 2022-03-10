using System;
using System.Collections.Generic;
using System.Text;


class PracticeClass
{
    public static int y = 0;
    public static void Division(int userNum)
    { Console.WriteLine( userNum / 2); }

    public static int Multiplication(int userNum)
    {
        return (userNum * 2);
    }

    public static float Multiplication(float userNum, float defaultNum)
    {
        return (userNum * defaultNum);
    }
}

