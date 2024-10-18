using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Inventario
{
    public partial class EliminarProductos : Form
    {
        public EliminarProductos()
        {
            InitializeComponent();
        }
         
        

        
        private void EliminarProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
              string codigoProducto= txtCodigo.Text;
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-72K7I0M;Database=InventarioDB;Integrated Security=True;"))
            {
                connection.Open();
                string query = "DELETE FROM Productos WHERE CodigoProducto = @CodigoProducto";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Producto eliminado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                }

            }
            this.Close();
        }
    }
}
