namespace Servicio_al_Ciente
{
    partial class RecuperaUsuario
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
            this.label_opcion = new System.Windows.Forms.Label();
            this.combobox_opcion = new System.Windows.Forms.ComboBox();
            this.button_recuperar = new System.Windows.Forms.Button();
            this.button_regresar = new System.Windows.Forms.Button();
            this.label_informacion = new System.Windows.Forms.Label();
            this.text_informacion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_opcion
            // 
            this.label_opcion.AutoSize = true;
            this.label_opcion.BackColor = System.Drawing.SystemColors.Control;
            this.label_opcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_opcion.Location = new System.Drawing.Point(15, 46);
            this.label_opcion.Name = "label_opcion";
            this.label_opcion.Size = new System.Drawing.Size(143, 20);
            this.label_opcion.TabIndex = 0;
            this.label_opcion.Text = "Escoja la Opcion";
            // 
            // combobox_opcion
            // 
            this.combobox_opcion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.combobox_opcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_opcion.FormattingEnabled = true;
            this.combobox_opcion.Items.AddRange(new object[] {
            "Correo",
            "Usuario"});
            this.combobox_opcion.Location = new System.Drawing.Point(220, 46);
            this.combobox_opcion.Name = "combobox_opcion";
            this.combobox_opcion.Size = new System.Drawing.Size(192, 28);
            this.combobox_opcion.TabIndex = 1;
            // 
            // button_recuperar
            // 
            this.button_recuperar.BackColor = System.Drawing.SystemColors.Control;
            this.button_recuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_recuperar.Location = new System.Drawing.Point(263, 165);
            this.button_recuperar.Name = "button_recuperar";
            this.button_recuperar.Size = new System.Drawing.Size(114, 37);
            this.button_recuperar.TabIndex = 2;
            this.button_recuperar.Text = "Recuperar";
            this.button_recuperar.UseVisualStyleBackColor = false;
            this.button_recuperar.Click += new System.EventHandler(this.button_recuperar_Click);
            // 
            // button_regresar
            // 
            this.button_regresar.BackColor = System.Drawing.SystemColors.Control;
            this.button_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_regresar.Location = new System.Drawing.Point(491, 165);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(113, 36);
            this.button_regresar.TabIndex = 3;
            this.button_regresar.Text = "Regresar";
            this.button_regresar.UseVisualStyleBackColor = false;
            this.button_regresar.Click += new System.EventHandler(this.button_regresar_Click);
            // 
            // label_informacion
            // 
            this.label_informacion.AutoSize = true;
            this.label_informacion.BackColor = System.Drawing.SystemColors.Control;
            this.label_informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_informacion.Location = new System.Drawing.Point(15, 107);
            this.label_informacion.Name = "label_informacion";
            this.label_informacion.Size = new System.Drawing.Size(188, 20);
            this.label_informacion.TabIndex = 4;
            this.label_informacion.Text = "Escriba la Informacion";
            // 
            // text_informacion
            // 
            this.text_informacion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.text_informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_informacion.Location = new System.Drawing.Point(220, 101);
            this.text_informacion.Name = "text_informacion";
            this.text_informacion.Size = new System.Drawing.Size(384, 26);
            this.text_informacion.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_opcion);
            this.groupBox1.Controls.Add(this.button_regresar);
            this.groupBox1.Controls.Add(this.text_informacion);
            this.groupBox1.Controls.Add(this.button_recuperar);
            this.groupBox1.Controls.Add(this.label_informacion);
            this.groupBox1.Controls.Add(this.combobox_opcion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(41, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 240);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recuperacion de Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RecuperaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 328);
            this.Controls.Add(this.groupBox1);
            this.Name = "RecuperaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar datos de usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_opcion;
        private System.Windows.Forms.ComboBox combobox_opcion;
        private System.Windows.Forms.Button button_recuperar;
        private System.Windows.Forms.Button button_regresar;
        private System.Windows.Forms.Label label_informacion;
        private System.Windows.Forms.TextBox text_informacion;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}