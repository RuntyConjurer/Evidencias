namespace Inventario
{
    partial class FormAgregarProductos
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
            txtNombre = new TextBox();
            txtProveedor = new TextBox();
            txtCodigo = new TextBox();
            txtExistencia = new TextBox();
            txtCategoria = new TextBox();
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(38, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(196, 118);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(100, 23);
            txtProveedor.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(196, 57);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(38, 118);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(100, 23);
            txtExistencia.TabIndex = 3;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(338, 118);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(338, 57);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 39);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 7;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 39);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 100);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 9;
            label4.Text = "Existencia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 100);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 10;
            label5.Text = "Proveedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 100);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 11;
            label6.Text = "Categoria";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(477, 92);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormAgregarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(txtCategoria);
            Controls.Add(txtExistencia);
            Controls.Add(txtCodigo);
            Controls.Add(txtProveedor);
            Controls.Add(txtNombre);
            ForeColor = SystemColors.ControlText;
            Name = "FormAgregarProductos";
            Text = "FormAgregarProductos";
            Load += FormAgregarProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtProveedor;
        private TextBox txtCodigo;
        private TextBox txtExistencia;
        private TextBox txtCategoria;
        private TextBox txtPrecio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAgregar;
    }
}