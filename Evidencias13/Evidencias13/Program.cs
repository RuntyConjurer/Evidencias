using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Generic;

namespace lol
{
    class Program
    {
        static void Main(string[] args)
        {        
            Console.WriteLine("Primer numero:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Segundo numero:");
            double num2 = Convert.ToDouble(Console.ReadLine());
           
            double suma = num1 + num2;
                       
            Console.WriteLine("sumados: " + suma);
        }
    }

}
