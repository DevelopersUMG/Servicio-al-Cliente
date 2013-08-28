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
            this.label_tipo_sop = new System.Windows.Forms.Label();
            this.label_ingreso_fecha = new System.Windows.Forms.Label();
            this.button_ingresar = new System.Windows.Forms.Button();
            this.dateTimePicker_fecha = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_ingreso_descr
            // 
            this.label_ingreso_descr.AutoSize = true;
            this.label_ingreso_descr.BackColor = System.Drawing.SystemColors.Control;
            this.label_ingreso_descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_ingreso_descr.Location = new System.Drawing.Point(12, 156);
            this.label_ingreso_descr.Name = "label_ingreso_descr";
            this.label_ingreso_descr.Size = new System.Drawing.Size(259, 18);
            this.label_ingreso_descr.TabIndex = 29;
            this.label_ingreso_descr.Text = "Ingrese la descripcion del reporte";
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(277, 156);
            this.textBox_descripcion.Multiline = true;
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(345, 162);
            this.textBox_descripcion.TabIndex = 28;
            // 
            // label_tipo_sop
            // 
            this.label_tipo_sop.AutoSize = true;
            this.label_tipo_sop.BackColor = System.Drawing.SystemColors.Control;
            this.label_tipo_sop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_tipo_sop.Location = new System.Drawing.Point(12, 76);
            this.label_tipo_sop.Name = "label_tipo_sop";
            this.label_tipo_sop.Size = new System.Drawing.Size(210, 18);
            this.label_tipo_sop.TabIndex = 26;
            this.label_tipo_sop.Text = "Seleccione tipo de soporte";
            // 
            // label_ingreso_fecha
            // 
            this.label_ingreso_fecha.AutoSize = true;
            this.label_ingreso_fecha.BackColor = System.Drawing.SystemColors.Control;
            this.label_ingreso_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_ingreso_fecha.Location = new System.Drawing.Point(12, 32);
            this.label_ingreso_fecha.Name = "label_ingreso_fecha";
            this.label_ingreso_fecha.Size = new System.Drawing.Size(174, 18);
            this.label_ingreso_fecha.TabIndex = 24;
            this.label_ingreso_fecha.Text = "Ingrese fecha de caso";
            // 
            // button_ingresar
            // 
            this.button_ingresar.BackColor = System.Drawing.SystemColors.Control;
            this.button_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button_ingresar.Location = new System.Drawing.Point(531, 341);
            this.button_ingresar.Name = "button_ingresar";
            this.button_ingresar.Size = new System.Drawing.Size(91, 29);
            this.button_ingresar.TabIndex = 30;
            this.button_ingresar.Text = "Ingresar";
            this.button_ingresar.UseVisualStyleBackColor = false;
            this.button_ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker_fecha
            // 
            this.dateTimePicker_fecha.Location = new System.Drawing.Point(285, 30);
            this.dateTimePicker_fecha.Name = "dateTimePicker_fecha";
            this.dateTimePicker_fecha.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker_fecha.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fisico",
            "Tecnico",
            "Software"});
            this.comboBox1.Location = new System.Drawing.Point(285, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 382);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker_fecha);
            this.Controls.Add(this.button_ingresar);
            this.Controls.Add(this.label_ingreso_descr);
            this.Controls.Add(this.textBox_descripcion);
            this.Controls.Add(this.label_tipo_sop);
            this.Controls.Add(this.label_ingreso_fecha);
            this.Name = "Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de caso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ingreso_descr;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.Label label_tipo_sop;
        private System.Windows.Forms.Label label_ingreso_fecha;
        private System.Windows.Forms.Button button_ingresar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fecha;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}