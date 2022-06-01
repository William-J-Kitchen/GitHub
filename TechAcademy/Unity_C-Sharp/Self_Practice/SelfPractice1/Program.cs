using System;

namespace SelfPractice1
{
    class Program
    {
        public static void Main()
        {
            int i = 0;

            for(; ; )
            {
                if (i < 5)
                    Console.Write(i);
                else
                    break;
                i++;
            }
        }


    }
}
