namespace Servicio_al_Ciente
{
    partial class Solucion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btinsertar = new System.Windows.Forms.Button();
            this.cmbdetalle = new System.Windows.Forms.ComboBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Servicio_al_Ciente.Properties.Resources.inserccion;
            this.groupBox1.Controls.Add(this.btinsertar);
            this.groupBox1.Controls.Add(this.cmbdetalle);
            this.groupBox1.Controls.Add(this.txttipo);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Solucion";
            // 
            // btinsertar
            // 
            this.btinsertar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btinsertar.Location = new System.Drawing.Point(430, 255);
            this.btinsertar.Name = "btinsertar";
            this.btinsertar.Size = new System.Drawing.Size(75, 28);
            this.btinsertar.TabIndex = 13;
            this.btinsertar.Text = "Insertar";
            this.btinsertar.UseVisualStyleBackColor = false;
            this.btinsertar.Click += new System.EventHandler(this.btinsertar_Click);
            // 
            // cmbdetalle
            // 
            this.cmbdetalle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbdetalle.FormattingEnabled = true;
            this.cmbdetalle.Location = new System.Drawing.Point(384, 47);
            this.cmbdetalle.Name = "cmbdetalle";
            this.cmbdetalle.Size = new System.Drawing.Size(121, 27);
            this.cmbdetalle.TabIndex = 12;
            // 
            // txttipo
            // 
            this.txttipo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txttipo.Location = new System.Drawing.Point(161, 47);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(100, 26);
            this.txttipo.TabIndex = 11;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtdescripcion.Location = new System.Drawing.Point(52, 118);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(453, 118);
            this.txtdescripcion.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(267, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Detalle Soporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(49, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo de Caso";
            // 
            // Solucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Servicio_al_Ciente.Properties.Resources.inserccion;
            this.ClientSize = new System.Drawing.Size(643, 349);
            this.Controls.Add(this.groupBox1);
            this.Name = "Solucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solucion";
            this.Load += new System.EventHandler(this.Solucion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btinsertar;
        private System.Windows.Forms.ComboBox cmbdetalle;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}