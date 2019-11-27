namespace AppNumeroaletorios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLenarcaja = new System.Windows.Forms.Button();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnOrdenarLista = new System.Windows.Forms.Button();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLenarcaja
            // 
            this.btnLenarcaja.Location = new System.Drawing.Point(36, 49);
            this.btnLenarcaja.Name = "btnLenarcaja";
            this.btnLenarcaja.Size = new System.Drawing.Size(187, 32);
            this.btnLenarcaja.TabIndex = 0;
            this.btnLenarcaja.Text = "LLENAR LISTA DE #";
            this.btnLenarcaja.UseVisualStyleBackColor = true;
            this.btnLenarcaja.Click += new System.EventHandler(this.btnLenarcaja_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(36, 100);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(187, 134);
            this.lstNumeros.TabIndex = 1;
            // 
            // btnOrdenarLista
            // 
            this.btnOrdenarLista.Location = new System.Drawing.Point(238, 49);
            this.btnOrdenarLista.Name = "btnOrdenarLista";
            this.btnOrdenarLista.Size = new System.Drawing.Size(187, 32);
            this.btnOrdenarLista.TabIndex = 2;
            this.btnOrdenarLista.Text = "ORDENAR LISTA";
            this.btnOrdenarLista.UseVisualStyleBackColor = true;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio.Location = new System.Drawing.Point(238, 135);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(100, 31);
            this.txtPromedio.TabIndex = 3;
            // 
            // txtSuma
            // 
            this.txtSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuma.Location = new System.Drawing.Point(238, 203);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 31);
            this.txtSuma.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(235, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PROMEDIO  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SUMA   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 11F);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOTAS ALEATORIAS PARA 30 ESTUDIANTES";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 254);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.btnOrdenarLista);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btnLenarcaja);
            this.Name = "Form1";
            this.Text = "NOTAS ALEATORIAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLenarcaja;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnOrdenarLista;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

