using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarProductos formAgregarProductos = new FormAgregarProductos();
            formAgregarProductos.ShowDialog();
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarProductos formEditarProductos = new FormEditarProductos();
            formEditarProductos.ShowDialog();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarProductos eliminarProductos = new EliminarProductos();
            eliminarProductos.ShowDialog();
        }

        private void consultarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProductos consultarProductos = new ConsultarProductos();
            consultarProductos.ShowDialog();
        }

        private void agregarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProveedores agregarProveedores = new AgregarProveedores();
            agregarProveedores.ShowDialog();
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarProveedor eliminarProveedor = new EliminarProveedor();
            eliminarProveedor.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCategoria agregarCategoria = new AgregarCategoria();
            agregarCategoria.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarCategoria eliminarCategoria = new EliminarCategoria();
            eliminarCategoria.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCategorias consultaCategorias = new ConsultaCategorias();
            consultaCategorias.ShowDialog();
        }

        private void consultarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProveedores consultarProveedores = new ConsultarProveedores();
            consultarProveedores .ShowDialog();
        }
    }
}
