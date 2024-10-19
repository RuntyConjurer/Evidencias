using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Generic;
using System.IO;
using Topshelf;

namespace MiServicio
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<MiServicio>(s =>
                {
                    s.ConstructUsing(name => new MiServicio());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });

                // Configuración del servicio
                x.RunAsLocalSystem(); // Ejecutar como sistema local
                x.SetDescription("Servicio que borra un archivo cada hora");
                x.SetDisplayName("Mi Servicio");
                x.SetServiceName("MiServicio");
            });
        }
    }

    public class MiServicio
    {
        private System.Timers.Timer timer;

        public void Start()
        {
            timer = new System.Timers.Timer(3600000);
            timer.Elapsed += (sender, e) =>
            {
                string archivoABorrar = @"C:\temp\archivo_a_borrar.txt"; 
                try
                {
                    if (File.Exists(archivoABorrar))
                    {
                        File.Delete(archivoABorrar);
                        Console.WriteLine($"archivo borrado: {archivoABorrar}");
                    }
                    else
                    {
                        Console.WriteLine($"no se encontro el archivo: {archivoABorrar}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"error al borrar el archivo: {ex.Message}");
                }
            };

            timer.Start();
            Console.WriteLine("servicio iniciado.");
        }

        public void Stop()
        {
            
            timer.Stop();
            timer.Dispose();
            Console.WriteLine("servicio detenido.");
        }
    }
}