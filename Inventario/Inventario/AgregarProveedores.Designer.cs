namespace Inventario
{
    partial class AgregarProveedores
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
            txtNombreEmpresa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            a = new Label();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtContacto = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // txtNombreEmpresa
            // 
            txtNombreEmpresa.Location = new Point(53, 92);
            txtNombreEmpresa.Name = "txtNombreEmpresa";
            txtNombreEmpresa.Size = new Size(100, 23);
            txtNombreEmpresa.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 74);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "NombreEmpresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 74);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Contacto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 144);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Direccion";
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(188, 144);
            a.Name = "a";
            a.Size = new Size(52, 15);
            a.TabIndex = 4;
            a.Text = "Telefono";
            
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(188, 162);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 5;
            txtTelefono.TextChanged += this.txtTelefono_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(53, 162);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 6;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(188, 92);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(341, 123);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += this.btnAgregar_Click;
            // 
            // AgregarProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(txtContacto);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(a);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombreEmpresa);
            Name = "AgregarProveedores";
            Text = "AgregarProveedor";
            Load += this.AgregarProveedores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreEmpresa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label a;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtContacto;
        private Button btnAgregar;
    }
}