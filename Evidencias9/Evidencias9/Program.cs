using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Generic;

namespace Delegado
{
    class Libro
    {
        public string Titulo { get; }
        public string Autor { get; }
        public decimal PrecioTotal { get; }
        public bool TienePortadaPapel { get; }

        public Libro(string titulo, string autor, decimal precioTotal, bool tienePortadaPapel)
        {
            Titulo = titulo;
            Autor = autor;
            PrecioTotal = precioTotal;
            TienePortadaPapel = tienePortadaPapel;
        }
    }

    class LibroLis
    {
        private List<Libro> libros = new List<Libro>();

        public void AddLibro(Libro libro)
        {
            libros.Add(libro);
        }

        
        public void ProcesarPortada(Action<Libro> proceso)
        {
            foreach (Libro libro in libros)
            {
                if (libro.TienePortadaPapel)
                {
                    proceso(libro);
                }
            }
        }

      
        public decimal ProcesarPortada(Func<decimal, Libro, decimal> totalizador, decimal totalInicial)
        {
            decimal total = totalInicial;

            foreach (Libro libro in libros)
            {
                if (libro.TienePortadaPapel)
                {
                    total = totalizador(total, libro);
                }
            }

            return total;
        }
    }
  class Program
    {
        static void Main(string[] args)
        {
            LibroLis libroLista = new LibroLis();
            AddLibros(libroLista);

            Console.WriteLine(" libros con portada de papel:");
            libroLista.ProcesarPortada(ImprimirTitulo);

            decimal totalLibros = libroLista.ProcesarPortada(CalcularTotal, 0);
            Console.WriteLine($"Precio de todos los libros de portada de papel es: {totalLibros:C}");

            Console.ReadKey();
        }
       
        static void ImprimirTitulo(Libro lb)
        {
            Console.WriteLine(lb.Titulo);
        }    
        static decimal CalcularTotal(decimal total, Libro lb)
        {
            return total + lb.PrecioTotal;
        }
        static void AddLibros(LibroLis libroDB)
        {
            libroDB.AddLibro(new Libro("Los alpinistas de Stalin", "Cedric Gras", 19.95m, true));
            libroDB.AddLibro(new Libro("La carabela San Lesmes", "Luis Gorrochategui", 39.95m, true));
            libroDB.AddLibro(new Libro("En la boca del lobo", "Elvira Lindo", 129.95m, false));
            libroDB.AddLibro(new Libro("No te vere morir", "Antonio Muñoz Molina", 12.00m, true));
        }
    }
}