using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSubmission
{
    public interface IQuittable
    {
        public void Quit(Employee Employee)
        {
            Console.WriteLine("The user has quit the game");
        }
    }
}
