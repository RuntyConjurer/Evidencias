using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FormEditarProductos : Form
    {
        private string codigoProducto;


        public FormEditarProductos()
        {
            InitializeComponent();
           

        }


        private void FormEditarProductos_Load(object sender, EventArgs e)
        {

            CargarProductos();

        }
        private void CargarProductos()
        {
            using(SqlConnection connection = new SqlConnection("Server=DESKTOP-72K7I0M;Database=InventarioDB;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT CodigoProducto, Nombre, Precio, Existencia, Proveedor, Categoria FROM Productos";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                }
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("DESKTOP-72K7I0M"))
            {
                connection.Open();
                string query = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio, Existencia = @Existencia, Proveedor = @Proveedor, Categoria = @Categoria WHERE CodigoProducto = @CodigoProducto";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                    command.Parameters.AddWithValue("@Existencia", Convert.ToInt32(txtExistencia.Text));
                    command.Parameters.AddWithValue("@Proveedor", txtProveedor.Text);
                    command.Parameters.AddWithValue("@Categoria", txtCategoria.Text);
                    command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);


                    int filasAfectadas = command.ExecuteNonQuery();


                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Producto editado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al editar el producto.");
                    }
                }
            }
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0) 
            {
                DataGridViewRow selectedRow = dataGridViewProductos.SelectedRows[0];

                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = selectedRow.Cells["Precio"].Value.ToString();
                txtExistencia.Text = selectedRow.Cells["Existencia"].Value.ToString();
                txtProveedor.Text = selectedRow.Cells["Proveedor"].Value.ToString();
                txtCategoria.Text = selectedRow.Cells["Categoria"].Value.ToString();

                
                codigoProducto = selectedRow.Cells["CodigoProducto"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para editar.");
            }
        }
   
    
    
    
    
    
    
    
    }



}
