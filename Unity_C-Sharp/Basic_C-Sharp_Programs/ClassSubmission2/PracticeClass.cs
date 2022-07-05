using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmission2
{
    public class PracticeClass
    {
        public void Division(int userNum)
        { Console.WriteLine(userNum / 2); }

        public void Output(int userNum, out int result)
        {
            result = userNum * 2;
            
        }

        public void Division(int userNum, int x)
        {
            //overloaded method
            { Console.WriteLine(userNum / x); }
        }
    }
}
