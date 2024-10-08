using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evidencias3
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            while (true)
            {
                Console.WriteLine("Bob's Big GiveawaYY");
                Console.WriteLine("Chosse a door: 1, 2 or 3");
                string userValue = Console.ReadLine();

                if (userValue == "1")
                {
                    string message = "You won a new car";
                    Console.WriteLine(message);
                }

                else if (userValue == "2")
                {
                    string message = "You won a new cat";
                    Console.WriteLine(message);
                }

                else if (userValue == "3")
                {
                    string message = "You won a new boat";
                    Console.WriteLine(message);
                }
                else
                {
                    string message = "NOT VALID";
                    message += "you lose";
                    Console.WriteLine(message);

                    break;
                }
                Console.ReadLine();
                Console.ReadKey();
                

            }
            */

            Console.WriteLine("Bob's Big GiveawaYY");
            Console.WriteLine("Chosse a door: 1, 2 or 3");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You typed {0}, threfore you won a {1} " , userValue , message);
            Console.ReadLine();
            Console.ReadKey();
        }
   
    }

}