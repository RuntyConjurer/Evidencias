namespace Inventario
{
    partial class ConsultarProveedores
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
            dataGridViewProveedores = new DataGridView();
            btnCargarProveedores = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProveedores
            // 
            dataGridViewProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedores.Location = new Point(61, 288);
            dataGridViewProveedores.Name = "dataGridViewProveedores";
            dataGridViewProveedores.Size = new Size(653, 150);
            dataGridViewProveedores.TabIndex = 0;
            dataGridViewProveedores.CellContentClick += dataGridViewProveedores_CellContentClick;
            // 
            // btnCargarProveedores
            // 
            btnCargarProveedores.Location = new Point(323, 247);
            btnCargarProveedores.Name = "btnCargarProveedores";
            btnCargarProveedores.Size = new Size(146, 23);
            btnCargarProveedores.TabIndex = 1;
            btnCargarProveedores.Text = "Cargar Proveedores";
            btnCargarProveedores.UseVisualStyleBackColor = true;
            btnCargarProveedores.Click += btnCargarProveedores_Click;
            // 
            // ConsultarProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargarProveedores);
            Controls.Add(dataGridViewProveedores);
            Name = "ConsultarProveedores";
            Text = "ConsultarProveedores";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProveedores;
        private Button btnCargarProveedores;
    }
}