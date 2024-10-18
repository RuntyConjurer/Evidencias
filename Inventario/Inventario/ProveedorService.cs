using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public class ProveedorService
    {
        private readonly string connectionString = "tu_connection_string_aqui"; // Cambia esto por tu cadena de conexión

        public void AgregarProveedor(Proveedor proveedor)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Proveedores (NombreEmpresa, Contacto, Direccion, Telefono) VALUES (@NombreEmpresa, @Contacto, @Direccion, @Telefono)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreEmpresa", proveedor.NombreEmpresa);
                command.Parameters.AddWithValue("@Contacto", proveedor.Contacto);
                command.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                command.Parameters.AddWithValue("@Telefono", proveedor.Telefono);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

}   
