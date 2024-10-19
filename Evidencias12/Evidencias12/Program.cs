using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Generic;

namespace Ejercicios
{
    class Program
    {
       static void Main(string[] args)
        {
            
            int a = 10;
            int b = 3;

            int suma = a + b;        
            int resta = a - b;       
            int multiplicacion = a * b; 
            double division = (double)a / b;  
            int modulo = a % b;      
            Console.WriteLine("Operadores Aritméticos:");
            Console.WriteLine($"Suma: {a} + {b} = {suma}");
            Console.WriteLine($"Resta: {a} - {b} = {resta}");
            Console.WriteLine($"Multiplicacion: {a} * {b} = {multiplicacion}");
            Console.WriteLine($"Division: {a} / {b} = {division}");
            Console.WriteLine($"Modulo: {a} % {b} = {modulo}");

            Console.WriteLine("\nOperadores Relacionales:");
            Console.WriteLine($"{a} > {b}: {a > b}");  
            Console.WriteLine($"{a} < {b}: {a < b}"); 
            Console.WriteLine($"{a} == {b}: {a == b}"); 
            Console.WriteLine($"{a} != {b}: {a != b}"); 

            bool esMayor = a > b;
            bool esIgual = a == b;

            Console.WriteLine("\nOperadores lgicos:");
            Console.WriteLine($"esmayor AND esigual: {esMayor && esIgual}"); 
            Console.WriteLine($"esmayor OR esigual: {esMayor || esIgual}");  
            Console.WriteLine($"NOT esmayor: {!esMayor}");                   

            Console.WriteLine("\nCondicional if-else:");
            if (a > b)
            {
                Console.WriteLine($"{a} es mayor que {b}");
            }
            else
            {
                Console.WriteLine($"{a} no es mayor que {b}");
            }
            Console.WriteLine("\nBucle con operador de incremento:");
            int contador = 0;
            while (contador < 5) 
            {
                Console.WriteLine($"Contador: {contador}");
                contador++; 
            }
        }
    }
}