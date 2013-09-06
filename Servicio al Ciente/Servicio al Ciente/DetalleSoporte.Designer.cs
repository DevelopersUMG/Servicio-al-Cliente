namespace Servicio_al_Ciente
{
    partial class DetalleSoporte
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
            this.gbdetalle = new System.Windows.Forms.GroupBox();
            this.btinsertar = new System.Windows.Forms.Button();
            this.lblsoporte = new System.Windows.Forms.Label();
            this.lblpuestoe = new System.Windows.Forms.Label();
            this.cmbsoporte = new System.Windows.Forms.ComboBox();
            this.cmbpuesto = new System.Windows.Forms.ComboBox();
            this.gbdetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbdetalle
            // 
            this.gbdetalle.BackgroundImage = global::Servicio_al_Ciente.Properties.Resources.inserccion;
            this.gbdetalle.Controls.Add(this.btinsertar);
            this.gbdetalle.Controls.Add(this.lblsoporte);
            this.gbdetalle.Controls.Add(this.lblpuestoe);
            this.gbdetalle.Controls.Add(this.cmbsoporte);
            this.gbdetalle.Controls.Add(this.cmbpuesto);
            this.gbdetalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdetalle.Location = new System.Drawing.Point(56, 48);
            this.gbdetalle.Name = "gbdetalle";
            this.gbdetalle.Size = new System.Drawing.Size(434, 262);
            this.gbdetalle.TabIndex = 0;
            this.gbdetalle.TabStop = false;
            this.gbdetalle.Text = "Detalles Caso";
            // 
            // btinsertar
            // 
            this.btinsertar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btinsertar.Location = new System.Drawing.Point(283, 185);
            this.btinsertar.Name = "btinsertar";
            this.btinsertar.Size = new System.Drawing.Size(75, 33);
            this.btinsertar.TabIndex = 9;
            this.btinsertar.Text = "Insertar";
            this.btinsertar.UseVisualStyleBackColor = false;
            this.btinsertar.Click += new System.EventHandler(this.btinsertar_Click);
            // 
            // lblsoporte
            // 
            this.lblsoporte.AutoSize = true;
            this.lblsoporte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblsoporte.Location = new System.Drawing.Point(63, 125);
            this.lblsoporte.Name = "lblsoporte";
            this.lblsoporte.Size = new System.Drawing.Size(61, 19);
            this.lblsoporte.TabIndex = 8;
            this.lblsoporte.Text = "ID caso";
            // 
            // lblpuestoe
            // 
            this.lblpuestoe.AutoSize = true;
            this.lblpuestoe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblpuestoe.Location = new System.Drawing.Point(63, 63);
            this.lblpuestoe.Name = "lblpuestoe";
            this.lblpuestoe.Size = new System.Drawing.Size(124, 19);
            this.lblpuestoe.TabIndex = 7;
            this.lblpuestoe.Text = "Puesto Empleado";
            // 
            // cmbsoporte
            // 
            this.cmbsoporte.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbsoporte.FormattingEnabled = true;
            this.cmbsoporte.Location = new System.Drawing.Point(201, 117);
            this.cmbsoporte.Name = "cmbsoporte";
            this.cmbsoporte.Size = new System.Drawing.Size(157, 27);
            this.cmbsoporte.TabIndex = 6;
            // 
            // cmbpuesto
            // 
            this.cmbpuesto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbpuesto.FormattingEnabled = true;
            this.cmbpuesto.Location = new System.Drawing.Point(201, 60);
            this.cmbpuesto.Name = "cmbpuesto";
            this.cmbpuesto.Size = new System.Drawing.Size(157, 27);
            this.cmbpuesto.TabIndex = 5;
            // 
            // DetalleSoporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Servicio_al_Ciente.Properties.Resources.inserccion;
            this.ClientSize = new System.Drawing.Size(557, 371);
            this.Controls.Add(this.gbdetalle);
            this.Name = "DetalleSoporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Soporte";
            this.Load += new System.EventHandler(this.DetalleSoporte_Load);
            this.gbdetalle.ResumeLayout(false);
            this.gbdetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdetalle;
        private System.Windows.Forms.Button btinsertar;
        private System.Windows.Forms.Label lblsoporte;
        private System.Windows.Forms.Label lblpuestoe;
        private System.Windows.Forms.ComboBox cmbsoporte;
        private System.Windows.Forms.ComboBox cmbpuesto;
    }
}