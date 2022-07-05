using System;
using System.Collections;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //string[] stringArray = new string[] { "String 1 ", "String 2 ", "String 3 ", "String 4 ", "String 5 " };
        //Console.WriteLine("Please input text to append to strings.");
        //string userString = Console.ReadLine();
        //int i = 0;
        //while (i < stringArray.Length)
        //{
        //    stringArray[i] += userString;
        //    Console.WriteLine(stringArray[i]);
        //    i++;
        //}


        ////This is an infinite loop.
        //int count = 0;
        //while (count == count)
        //{
        //    Console.WriteLine(count);
        //    count++;
        //}

        //int j = 0;
        //while (j <= 4)
        //{
        //    Console.WriteLine(stringArray[j]);
        //    j++;
        //}


        var uniqueList = new List<string>() { "Kevin", "Dave", "Sharon", "Becky", "Kevin" };
        Console.WriteLine("Please input text to search string.");
        string userSearch = Console.ReadLine();

        //bool found = false;
        //for (int k = 0; k < uniqueList.Count; k++)
        //{
        //    if (uniqueList[k].Contains(userSearch))
        //    {
        //        Console.WriteLine("Your search was found within this string:\n" + uniqueList[k] + " at index " + k);
        //        found = true;
        //    }
        //}
        //if (found == false) Console.WriteLine("The string you were searching for wasn't found. Please try again.");

        bool found2 = false;
        int l = 0;
        foreach (string Name in uniqueList)
        {
            l++;
            if (Name == userSearch && found2 == false)
            {
                Console.WriteLine(Name + " was found.");
                found2 = true;
            }
            else if (Name == userSearch && found2 == true)
            {
                Console.WriteLine("The name " + Name + " was found again in your search.");
            }
            else if (found2 == false && uniqueList.Count == l)
            {
                Console.WriteLine("Your search has returned no results. Please try again.");
                break;
            }
        }
    }
}

