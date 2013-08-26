namespace Servicio_al_Ciente
{
    partial class Ingreso
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
            this.label_ingreso_descr = new System.Windows.Forms.Label();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.textBox_id_reporte = new System.Windows.Forms.TextBox();
            this.label_Ingreso_id = new System.Windows.Forms.Label();
            this.label_ingreso_fecha = new System.Windows.Forms.Label();
            this.button_regresar = new System.Windows.Forms.Button();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_ingreso_descr
            // 
            this.label_ingreso_descr.AutoSize = true;
            this.label_ingreso_descr.BackColor = System.Drawing.SystemColors.Control;
            this.label_ingreso_descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_ingreso_descr.Location = new System.Drawing.Point(12, 157);
            this.label_ingreso_descr.Name = "label_ingreso_descr";
            this.label_ingreso_descr.Size = new System.Drawing.Size(259, 18);
            this.label_ingreso_descr.TabIndex = 29;
            this.label_ingreso_descr.Text = "Ingrese la descripcion del reporte";
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(285, 157);
            this.textBox_descripcion.Multiline = true;
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(345, 162);
            this.textBox_descripcion.TabIndex = 28;
            // 
            // textBox_id_reporte
            // 
            this.textBox_id_reporte.Location = new System.Drawing.Point(285, 112);
            this.textBox_id_reporte.Name = "textBox_id_reporte";
            this.textBox_id_reporte.Size = new System.Drawing.Size(194, 20);
            this.textBox_id_reporte.TabIndex = 27;
            // 
            // label_Ingreso_id
            // 
            this.label_Ingreso_id.AutoSize = true;
            this.label_Ingreso_id.BackColor = System.Drawing.SystemColors.Control;
            this.label_Ingreso_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_Ingreso_id.Location = new System.Drawing.Point(12, 123);
            this.label_Ingreso_id.Name = "label_Ingreso_id";
            this.label_Ingreso_id.Size = new System.Drawing.Size(188, 18);
            this.label_Ingreso_id.TabIndex = 26;
            this.label_Ingreso_id.Text = "Ingrese el ID del reporte";
            // 
            // label_ingreso_fecha
            // 
            this.label_ingreso_fecha.AutoSize = true;
            this.label_ingreso_fecha.BackColor = System.Drawing.SystemColors.Control;
            this.label_ingreso_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_ingreso_fecha.Location = new System.Drawing.Point(12, 88);
            this.label_ingreso_fecha.Name = "label_ingreso_fecha";
            this.label_ingreso_fecha.Size = new System.Drawing.Size(213, 18);
            this.label_ingreso_fecha.TabIndex = 24;
            this.label_ingreso_fecha.Text = "Ingrese la fecha del reporte";
            // 
            // button_regresar
            // 
            this.button_regresar.BackColor = System.Drawing.SystemColors.Control;
            this.button_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button_regresar.Location = new System.Drawing.Point(545, 331);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(91, 29);
            this.button_regresar.TabIndex = 30;
            this.button_regresar.Text = "Regresar";
            this.button_regresar.UseVisualStyleBackColor = false;
            this.button_regresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(285, 86);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker_fecha.TabIndex = 31;
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 382);
            this.Controls.Add(this.dateTimePicker_fecha);
            this.Controls.Add(this.button_regresar);
            this.Controls.Add(this.label_ingreso_descr);
            this.Controls.Add(this.textBox_descripcion);
            this.Controls.Add(this.textBox_id_reporte);
            this.Controls.Add(this.label_Ingreso_id);
            this.Controls.Add(this.label_ingreso_fecha);
            this.Name = "Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ingreso_descr;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.TextBox textBox_id_reporte;
        private System.Windows.Forms.Label label_Ingreso_id;
        private System.Windows.Forms.Label label_ingreso_fecha;
        private System.Windows.Forms.Button button_regresar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
    }
}