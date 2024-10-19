using System;
using System.Collections.Generic;
using System.Text;

namespace Numeros
{
    class Program
    {
        public static void Main(string[] args)
        {
            NumerosFibonacci fibona = new NumerosFibonacci();
            int cantidadelementos;

            while (true)
            {
                Console.WriteLine("Ingresa la cantidad de elementos");
                cantidadelementos = int.Parse(Console.ReadLine());

                if (cantidadelementos == 0)
                {
                    Console.WriteLine("Hablamos");
                    break;
                }
                if (cantidadelementos > 0)
                {
                    fibona.fibonacci(cantidadelementos);
                }
                else
                {
                    Console.WriteLine("Nice try diddy");
                }
                Console.ReadKey();
            }



        }
    }
    public class NumerosFibonacci
    {
        public void fibonacci(int cantidadelementos)
        {
            int a = 0, b = 1, c;
            Console.WriteLine("Secuencia de fibonacci");
            for (int i = 0; i < cantidadelementos; i++)
            {
                Console.WriteLine(a + "");
                c = a + b;
                a = b;
                b = c;

            }
        }
    }
}

