using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BetterConsoleTables;

namespace Desarrollo1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ingrese la cantidad de empleados, 0 para salir:");
                int CantidadEmpleados = int.Parse(Console.ReadLine());
                if (CantidadEmpleados == 0)
                {
                    break;
                }

                List<Empleados> empleados = new List<Empleados>();
                decimal TotalSalarios = 0, TotalAFP = 0, TotalSFS = 0, TotalISR = 0, TotalDeducciones = 0, TotalNeto = 0;

                for (int i = 0; i < CantidadEmpleados; i++)
                {
                    Console.WriteLine($"\n--- Empleado {i + 1}---");

                    Console.Write("Nombre:");
                    string nombre = Console.ReadLine();

                    Console.Write("Apellido:");
                    string apellido = Console.ReadLine();

                    Console.Write("Sueldo bruto:");
                    decimal sueldobruto = decimal.Parse(Console.ReadLine());

                    decimal afp = CalcularAFP(sueldobruto);
                    decimal sfs = CalcularSFS(sueldobruto);
                    decimal isr = CalcularISR(sueldobruto);
                    decimal TotalDeduccionesEmpleado = afp + sfs + isr;
                    decimal SalarioNeto = sueldobruto - TotalDeduccionesEmpleado;

                    empleados.Add(new Empleados()
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        SueldoBruto = sueldobruto,
                        AFP = afp,
                        ISR = isr,
                        SFS = sfs,
                        Deducciones = TotalDeduccionesEmpleado,
                        SueldoNeto = SalarioNeto,


                    });

                    TotalSalarios += sueldobruto;
                    TotalAFP += afp;
                    TotalISR += isr;
                    TotalSFS += sfs;
                    TotalDeducciones += TotalDeduccionesEmpleado;
                    TotalNeto += SalarioNeto;


                }
                MostrarReporte(empleados);

                Console.WriteLine("\nTotal General");
                Console.WriteLine($"Total Salarios Brutos: {TotalSalarios}");
                Console.WriteLine($"Total AFP: {TotalAFP}");
                Console.WriteLine($"Total SFS: {TotalSFS}");
                Console.WriteLine($"Total ISR: {TotalISR}");
                Console.WriteLine($"Total Deducciones: {TotalDeducciones:C}");
                Console.WriteLine($"Total Neto:{TotalNeto}");

            }
            Console.ReadKey();


        }

        static decimal CalcularAFP(decimal salario)
        {
            return salario * 0.0287m;
        }

        static decimal CalcularSFS(decimal salario)
        {
            return salario * 0.0304m;
        }

        static decimal CalcularISR(decimal salario)
        {
            if (salario <= 34685) return 0;
            if (salario <= 52027) return (salario - 34685) * 0.15m;
            if (salario <= 72260) return 2605.50m + (salario - 52027) * 0.20m;
            return 6648.50m + (salario - 72260) * 0.25m;
        }
        static void MostrarReporte(List<Empleados> empleados)
        {
            var tabla = new Table(TableConfiguration.Unicode());

            // Añadir las columnas manualmente
            tabla.AddColumn("Nombre");
            tabla.AddColumn("Apellido");
            tabla.AddColumn("Salario Bruto");
            tabla.AddColumn("AFP");
            tabla.AddColumn("SFS");
            tabla.AddColumn("ISR");
            tabla.AddColumn("Total Deducciones");
            tabla.AddColumn("Salario Neto");

            // Agregar las filas
            foreach (var empleado in empleados)
            {
                tabla.AddRow(
                    empleado.Nombre,
                    empleado.Apellido,
                    empleado.SueldoBruto,
                    empleado.AFP,
                    empleado.SFS,
                    empleado.ISR,
                    empleado.Deducciones,
                    empleado.SueldoNeto
                );
            }

            tabla.Config = TableConfiguration.Unicode();

            
            Console.WriteLine(tabla.ToString());
        }
   
    
    }

    class Empleados
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal SueldoBruto { get; set; }
        public decimal AFP { get; set; }
        public decimal SFS { get; set; }
        public decimal ISR { get; set; }
        public decimal Deducciones { get; set; }
        public decimal SueldoNeto { get; set; }

    }
}  