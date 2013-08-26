namespace Servicio_al_Ciente
{
    partial class Reporte
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
            this.label_bienvenido = new System.Windows.Forms.Label();
            this.button_buscar = new System.Windows.Forms.Button();
            this.button_consulta = new System.Windows.Forms.Button();
            this.button_ingreso = new System.Windows.Forms.Button();
            this.button_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_bienvenido
            // 
            this.label_bienvenido.AutoSize = true;
            this.label_bienvenido.BackColor = System.Drawing.SystemColors.Control;
            this.label_bienvenido.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bienvenido.ForeColor = System.Drawing.Color.Black;
            this.label_bienvenido.Location = new System.Drawing.Point(37, 32);
            this.label_bienvenido.Name = "label_bienvenido";
            this.label_bienvenido.Size = new System.Drawing.Size(602, 38);
            this.label_bienvenido.TabIndex = 16;
            this.label_bienvenido.Text = "Bienvenido usuario al menu de reportes";
            // 
            // button_buscar
            // 
            this.button_buscar.BackColor = System.Drawing.SystemColors.Control;
            this.button_buscar.Font = new System.Drawing.Font("Forte", 15.75F);
            this.button_buscar.Location = new System.Drawing.Point(189, 216);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(247, 36);
            this.button_buscar.TabIndex = 15;
            this.button_buscar.Text = "Buscar Reporte";
            this.button_buscar.UseVisualStyleBackColor = false;
            this.button_buscar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_consulta
            // 
            this.button_consulta.BackColor = System.Drawing.SystemColors.Control;
            this.button_consulta.Font = new System.Drawing.Font("Forte", 15.75F);
            this.button_consulta.Location = new System.Drawing.Point(189, 159);
            this.button_consulta.Name = "button_consulta";
            this.button_consulta.Size = new System.Drawing.Size(247, 40);
            this.button_consulta.TabIndex = 14;
            this.button_consulta.Text = "Consultar Reporte";
            this.button_consulta.UseVisualStyleBackColor = false;
            this.button_consulta.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_ingreso
            // 
            this.button_ingreso.BackColor = System.Drawing.SystemColors.Control;
            this.button_ingreso.Font = new System.Drawing.Font("Forte", 15.75F);
            this.button_ingreso.Location = new System.Drawing.Point(189, 100);
            this.button_ingreso.Name = "button_ingreso";
            this.button_ingreso.Size = new System.Drawing.Size(249, 43);
            this.button_ingreso.TabIndex = 13;
            this.button_ingreso.Text = "Ingresar Reporte";
            this.button_ingreso.UseVisualStyleBackColor = false;
            this.button_ingreso.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_regresar
            // 
            this.button_regresar.BackColor = System.Drawing.SystemColors.Control;
            this.button_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button_regresar.Location = new System.Drawing.Point(545, 262);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(94, 30);
            this.button_regresar.TabIndex = 17;
            this.button_regresar.Text = "regresar";
            this.button_regresar.UseVisualStyleBackColor = false;
            this.button_regresar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 316);
            this.Controls.Add(this.button_regresar);
            this.Controls.Add(this.label_bienvenido);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.button_consulta);
            this.Controls.Add(this.button_ingreso);
            this.Name = "Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_bienvenido;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Button button_consulta;
        private System.Windows.Forms.Button button_ingreso;
        private System.Windows.Forms.Button button_regresar;

    }
}