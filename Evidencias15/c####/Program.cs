using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

while (true)
{
    Console.Write("Insete las existencias"); int cantidad;

    bool esNumeroValido = int.TryParse(Console.ReadLine(), out cantidad);

    if (!esNumeroValido)
    {
        Console.WriteLine("Ingrese un numero valido");
        continue;
    }

    
    if (cantidad >= 40 && cantidad >= 30)
    {
        Console.WriteLine("Sistema abastecido");
    }

    else if (cantidad >= 20 && cantidad <= 30)

    {
        Console.WriteLine("Sistema con existencias");

    }

    else if (cantidad <=10  && cantidad > 5)
    {
        Console.WriteLine("Sistema con problemas de existencias");
    }

    else if (cantidad <= 5)
    {
        Console.WriteLine("Abastece el sistema");


    }

}







