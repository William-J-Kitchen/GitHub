using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;


            do
            {
                Console.WriteLine("i = {0}", i);
                i++;

            } while (i <= 10);

            int i2 = 0;
            while (i2 <= 10)
            {
                Console.WriteLine("i2 = {0}", i2);
                i2++;
            }
        }
    }
}
