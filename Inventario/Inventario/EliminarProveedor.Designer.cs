namespace Inventario
{
    partial class EliminarProveedor
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
            txtIdProveedor = new TextBox();
            label1 = new Label();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(55, 72);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(100, 23);
            txtIdProveedor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 54);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(177, 72);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // EliminarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Controls.Add(txtIdProveedor);
            Name = "EliminarProveedor";
            Text = "EliminarProveedor";
          
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdProveedor;
        private Label label1;
        private Button btnEliminar;
    }
}