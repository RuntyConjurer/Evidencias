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
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-72K7I0M;Database=InventarioDB;Integrated Security=True;"))
            {
                connection.Open();
                string query = "INSERT INTO Categorias (Nombre) VALUES (@Nombre)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", txtNombreCategoria.Text);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Categoría agregada con éxito.");
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar la categoría.");
                    }
                }
            }
        }

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
