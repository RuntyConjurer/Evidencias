using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventario
{
    public class ProductoService
    {
        private string connectionString = "C;Database=InventarioDB;Integrated Security=true;";

        public void AgregarProducto(Producto producto)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "INSERT INTO Productos (Nombre, CodigoProducto, Categoria, Precio, Existencia, Proveedor) VALUES (@Nombre, @CodigoProducto, @Categoria, @Precio, @Existencia, @Proveedor)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                command.Parameters.AddWithValue("@Categoria", producto.Categoria);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Existencia", producto.Existencia);
                command.Parameters.AddWithValue("@Proveedor", producto.Proveedor);

                connection.Open();
                command.ExecuteNonQuery();
            }


        }
        public void EditarProducto(Producto producto)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "UPDATE Productos SET Nombre = @Nombre, Categoria = @Categoria, Precio = @Precio, Existencia = @Existencia, Proveedor = @Proveedor WHERE CodigoProducto = @CodigoProducto";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                command.Parameters.AddWithValue("@Categoria", producto.Categoria);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Existencia", producto.Existencia);
                command.Parameters.AddWithValue("@Proveedor", producto.Proveedor);

                connection.Open();
                command.ExecuteNonQuery();
            }

        }
        public void EliminarProducto(string codigoProducto)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "DELETE FROM Productos WHERE CodigoProducto = @CodigoProducto";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Producto ObtenerProductoPorCodigo(string codigoProducto)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Productos WHERE CodigoProducto = @CodigoProducto";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Producto
                        {
                            Id = (int)reader["Id"],
                            Nombre = (string)reader["Nombre"],
                            CodigoProducto = (string)reader["CodigoProducto"],
                            Categoria = (string)reader["Categoria"],
                            Precio = (decimal)reader["Precio"],
                            Existencia = (int)reader["Existencia"],
                            Proveedor = (string)reader["Proveedor"]
                        };
                    }
                }
            }
            return null;
           
        }
        public List<Producto> ObtenerProductosConStockBajo()
        {
            var productosBajos = new List<Producto>();
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM Productos WHERE Existencia < 10";
                var command = new SqlCommand(query, connection);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productosBajos.Add(new Producto
                        {
                            Id = (int)reader["Id"],
                            Nombre = (string)reader["Nombre"],
                            CodigoProducto = (string)reader["CodigoProducto"],
                            Categoria = (string)reader["Categoria"],
                            Precio = (decimal)reader["Precio"],
                            Existencia = (int)reader["Existencia"],
                            Proveedor = (string)reader["Proveedor"]
                        });
                    }
                }
            }
            return productosBajos;
        }




    }
}