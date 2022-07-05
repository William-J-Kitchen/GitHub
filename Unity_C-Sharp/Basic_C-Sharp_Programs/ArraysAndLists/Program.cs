using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Bubba");
        intList.Remove("Bubba");

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        byte[] byteArray = new byte[5000];

        //int[] numArray1 = new int[5];
        //numArray1[0] = 5;
        //numArray1[1] = 2;
        //numArray1[2] = 10;
        //numArray1[3] = 200;
        //numArray1[4] = 5000;

        //int[] numArray2 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray3 = { 5, 2, 10, 200, 5000 };

        //Console.WriteLine(numArray3[3]);
        //Console.ReadLine();
    }
}

