namespace App_calculadora
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Operaciones = new System.Windows.Forms.GroupBox();
            this.radSuma = new System.Windows.Forms.RadioButton();
            this.radResta = new System.Windows.Forms.RadioButton();
            this.radMultiplicacion = new System.Windows.Forms.RadioButton();
            this.radDivision = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Operaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Tan;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(583, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 40);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Tan;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(583, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 40);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(89, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 313);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Operaciones
            // 
            this.Operaciones.BackColor = System.Drawing.Color.RosyBrown;
            this.Operaciones.Controls.Add(this.radDivision);
            this.Operaciones.Controls.Add(this.radMultiplicacion);
            this.Operaciones.Controls.Add(this.radResta);
            this.Operaciones.Controls.Add(this.radSuma);
            this.Operaciones.Location = new System.Drawing.Point(89, 343);
            this.Operaciones.Name = "Operaciones";
            this.Operaciones.Size = new System.Drawing.Size(643, 109);
            this.Operaciones.TabIndex = 3;
            this.Operaciones.TabStop = false;
            this.Operaciones.Text = "Operaciones";
            // 
            // radSuma
            // 
            this.radSuma.AccessibleName = "";
            this.radSuma.AutoSize = true;
            this.radSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSuma.Location = new System.Drawing.Point(18, 30);
            this.radSuma.Name = "radSuma";
            this.radSuma.Size = new System.Drawing.Size(70, 59);
            this.radSuma.TabIndex = 0;
            this.radSuma.TabStop = true;
            this.radSuma.Text = "+";
            this.radSuma.UseVisualStyleBackColor = true;
            this.radSuma.CheckedChanged += new System.EventHandler(this.Suma_CheckedChanged);
            // 
            // radResta
            // 
            this.radResta.AutoSize = true;
            this.radResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radResta.Location = new System.Drawing.Point(150, 30);
            this.radResta.Name = "radResta";
            this.radResta.Size = new System.Drawing.Size(58, 59);
            this.radResta.TabIndex = 1;
            this.radResta.TabStop = true;
            this.radResta.Text = "-";
            this.radResta.UseVisualStyleBackColor = true;
            this.radResta.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radMultiplicacion
            // 
            this.radMultiplicacion.AutoSize = true;
            this.radMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMultiplicacion.Location = new System.Drawing.Point(297, 30);
            this.radMultiplicacion.Name = "radMultiplicacion";
            this.radMultiplicacion.Size = new System.Drawing.Size(61, 59);
            this.radMultiplicacion.TabIndex = 2;
            this.radMultiplicacion.TabStop = true;
            this.radMultiplicacion.Text = "*";
            this.radMultiplicacion.UseVisualStyleBackColor = true;
            this.radMultiplicacion.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radDivision
            // 
            this.radDivision.AccessibleName = "";
            this.radDivision.AutoSize = true;
            this.radDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDivision.Location = new System.Drawing.Point(464, 30);
            this.radDivision.Name = "radDivision";
            this.radDivision.Size = new System.Drawing.Size(55, 59);
            this.radDivision.TabIndex = 3;
            this.radDivision.TabStop = true;
            this.radDivision.Text = "/";
            this.radDivision.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Operaciones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "App Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Operaciones.ResumeLayout(false);
            this.Operaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Operaciones;
        private System.Windows.Forms.RadioButton radMultiplicacion;
        private System.Windows.Forms.RadioButton radResta;
        private System.Windows.Forms.RadioButton radSuma;
        private System.Windows.Forms.RadioButton radDivision;
        private System.Windows.Forms.Label label1;
    }
}

