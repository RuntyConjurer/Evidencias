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
    public partial class EliminarProveedor : Form
    {
        public EliminarProveedor()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-72K7I0M;Database=InventarioDB;Integrated Security=True;"))
            {
                connection.Open();
                string query = "DELETE FROM Proveedores WHERE IDProveedor = @IDProveedor";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDProveedor", txtIdProveedor.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Proveedor eliminado con éxito.");
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el proveedor. Verifique el ID.");
                    }
                }
            }
        }
    }
}
