namespace Clases_Interfaz
{
    partial class fmAtencion
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
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpkFechaAtencion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.paTitulo.SuspendLayout();
            this.paBotones.SuspendLayout();
            this.paDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // paTitulo
            // 
            this.paTitulo.Size = new System.Drawing.Size(512, 32);
            // 
            // paBotones
            // 
            this.paBotones.Location = new System.Drawing.Point(0, 219);
            this.paBotones.Size = new System.Drawing.Size(512, 40);
            // 
            // paDatos
            // 
            this.paDatos.Controls.Add(this.label5);
            this.paDatos.Controls.Add(this.comboBox2);
            this.paDatos.Controls.Add(this.dtpkFechaAtencion);
            this.paDatos.Controls.Add(this.label9);
            this.paDatos.Controls.Add(this.comboBox1);
            this.paDatos.Controls.Add(this.label4);
            this.paDatos.Controls.Add(this.label3);
            this.paDatos.Controls.Add(this.label2);
            this.paDatos.Controls.Add(this.label1);
            this.paDatos.Controls.Add(this.textBox3);
            this.paDatos.Controls.Add(this.textBox2);
            this.paDatos.Controls.Add(this.textBox1);
            this.paDatos.Size = new System.Drawing.Size(512, 187);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "ID Mascota";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 87;
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-5, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "observaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Resumen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "IdAtencion";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 20);
            this.textBox3.TabIndex = 73;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 72;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 71;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dtpkFechaAtencion
            // 
            this.dtpkFechaAtencion.Location = new System.Drawing.Point(77, 54);
            this.dtpkFechaAtencion.Name = "dtpkFechaAtencion";
            this.dtpkFechaAtencion.Size = new System.Drawing.Size(200, 20);
            this.dtpkFechaAtencion.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "ID Medico";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(77, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 90;
            this.comboBox2.Leave += new System.EventHandler(this.comboBox2_Leave);
            // 
            // fmAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 259);
            this.Name = "fmAtencion";
            this.Text = "fmAtencion";
            this.Load += new System.EventHandler(this.fmAtencion_Load);
            this.paTitulo.ResumeLayout(false);
            this.paBotones.ResumeLayout(false);
            this.paDatos.ResumeLayout(false);
            this.paDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpkFechaAtencion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}