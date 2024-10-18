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
    public partial class EliminarCategoria : Form
    {
        public EliminarCategoria()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(btnEliminar.Text))
            {
                MessageBox.Show("Ingresa el ID de una categoria");
                return;
            }
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-72K7I0M;Database=InventarioDB;Integrated Security=True;"))
            {
                connection.Open();
                string query = "DELETE FROM Categorias WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", txtIdCategoria.Text);
                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Categoría eliminada con éxito.");
                        this.Close();
                    }
                    else
                    {

                    }
                }
            }
        }

        private void EliminarCategoria_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Error al eliminar la categoría");
        }
    }
}
