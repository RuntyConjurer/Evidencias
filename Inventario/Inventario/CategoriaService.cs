using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public class CategoriaService
    {

        private readonly string connectionString = "tu_connection_string_aqui"; // Cambia esto por tu cadena de conexión

        public void AgregarCategoria(Categoria categoria)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Categorias (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                command.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }   
}
