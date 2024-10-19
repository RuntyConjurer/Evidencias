using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Generic;

namespace EjemploEspaciosNombres
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string filePath = @"C:\temp\miArchivo.txt";
          try
            {
                
                if (!Directory.Exists(@"C:\temp"))
                {
                    Directory.CreateDirectory(@"C:\temp");
                }
 
                File.WriteAllText(filePath, "archivo de ejemplo.\n");

                string contenido = File.ReadAllText(filePath);
                Console.WriteLine("Contenido del archivo:");
                Console.WriteLine(contenido);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            
            List<string> listaDeNombres = new List<string> { "Luis", "Angelo", "Manuel", "Juan" };
            listaDeNombres.Add("Pedro"); 

            Console.WriteLine("\nLista de nombres:");
            foreach (var nombre in listaDeNombres)
            {
                Console.WriteLine(nombre);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("Cadenita jejeje ");
            sb.Append("es útil para la concatenación eficiente de cadenas.");
            Console.WriteLine("\nContenido de StringBuilder:");
            Console.WriteLine(sb.ToString());
        }
    }
}