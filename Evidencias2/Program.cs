using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evidencias2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            Console.Write("Type in your first name");
            string MyFirstName;
            MyFirstName = Console.ReadLine();

            string MyLastName;
            Console.Write("Type your last name");
            MyLastName = Console.ReadLine();

            Console.WriteLine("Hello" + MyFirstName + MyLastName);

                
              
        }
    }
}
