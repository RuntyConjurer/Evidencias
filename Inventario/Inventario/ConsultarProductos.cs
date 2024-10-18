using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventario
{
    public partial class ConsultarProductos : Form
    {
        public ConsultarProductos()
        {
            InitializeComponent();
            CargarCategorias();

        }

        private void CargarCategorias()
        {
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-72K7I0M;Database=InventarioDB;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT DISTINCT Categoria From Productos";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxCategoria.Items.Add(reader["Categoria"].ToString());
                    }
                }
            }
        }
        private void ConsultarProductos_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string categoriaSeleccionada = comboBoxCategoria.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection("Server=DESKTOP-72K7I0M;Database=InventarioDB;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT * FROM Productos WHERE Categoria = @Categoria";
                using (SqlCommand command = new SqlCommand(@query, connection))
                {
                    command.Parameters.AddWithValue("@Categoria", categoriaSeleccionada);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewProductos.DataSource = dataTable;
                    

                }
            }
        }
    }
}
