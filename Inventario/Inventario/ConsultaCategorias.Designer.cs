namespace Inventario
{
    partial class ConsultaCategorias
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
            btnCerrar = new Button();
            dataGridViewCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorias).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(697, 187);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dataGridViewCategorias
            // 
            dataGridViewCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategorias.Location = new Point(12, 216);
            dataGridViewCategorias.Name = "dataGridViewCategorias";
            dataGridViewCategorias.Size = new Size(776, 222);
            dataGridViewCategorias.TabIndex = 1;
            dataGridViewCategorias.CellContentClick += dataGridViewCategorias_CellContentClick;
            // 
            // ConsultaCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewCategorias);
            Controls.Add(btnCerrar);
            Name = "ConsultaCategorias";
            Text = "ConsultaCategorias";
            Load += ConsultaCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrar;
        private DataGridView dataGridViewCategorias;
    }
}