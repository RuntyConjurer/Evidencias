using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReferenceVAlue

{
    class Program
    {
        static void Main(string[] args)
        {
            Arreglodenumeros arreglo = new Arreglodenumeros();
            Console.WriteLine($"secuencia Original: {arreglo.Cadena()}");

            // Buscamos el número 63 y lo referenciamos para modificar su valor
            ref int numero = ref arreglo.BuscaNumero(63);
            numero *= 2; // Multiplicamos el valor por 2

            Console.WriteLine($"nueva secuencia: {arreglo.Cadena()}");
        }
    }
    class Arreglodenumeros

    {
        private int[] numeros = { 1, 3, 5, 15, 31, 63, 127, 255, 511, 1023 };
     
        public ref int BuscaNumero(int objetivo)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == objetivo)
                {
                    return ref numeros[i]; 
                }
            }

            throw new IndexOutOfRangeException("Número no encontrado");
        }
        
        public string Cadena()
        {
            return string.Join(", ", numeros);
        }
    }
}