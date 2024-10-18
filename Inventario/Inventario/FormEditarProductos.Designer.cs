
namespace Inventario
{
    partial class FormEditarProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCategoria = new TextBox();
            txtProveedor = new TextBox();
            txtPrecio = new TextBox();
            txtExistencia = new TextBox();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            btnEditar = new Button();
            dataGridViewProductos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 42);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 43);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 109);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Existencia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 109);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Proveedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 109);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "Categoria";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(319, 127);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 6;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(186, 127);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(100, 23);
            txtProveedor.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(319, 61);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 8;
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(32, 127);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(100, 23);
            txtExistencia.TabIndex = 9;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(171, 60);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(32, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 11;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(469, 101);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(69, 242);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.Size = new Size(635, 150);
            dataGridViewProductos.TabIndex = 13;
            dataGridViewProductos.CellContentClick += dataGridViewProductos_CellContentClick;
            // 
            // FormEditarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewProductos);
            Controls.Add(btnEditar);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(txtExistencia);
            Controls.Add(txtPrecio);
            Controls.Add(txtProveedor);
            Controls.Add(txtCategoria);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEditarProductos";
            Text = "FormEditarProductos";
            Load += FormEditarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCategoria;
        private TextBox txtProveedor;
        private TextBox txtPrecio;
        private TextBox txtExistencia;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Button btnEditar;
        private DataGridView dataGridViewProductos;
    }
}