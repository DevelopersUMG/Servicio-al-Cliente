namespace Servicio_al_Ciente
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.label_consulta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_regresar = new System.Windows.Forms.Button();
            this.pictureBox_ejemplo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ejemplo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_consulta
            // 
            this.label_consulta.AutoSize = true;
            this.label_consulta.BackColor = System.Drawing.SystemColors.Control;
            this.label_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_consulta.Location = new System.Drawing.Point(180, 27);
            this.label_consulta.Name = "label_consulta";
            this.label_consulta.Size = new System.Drawing.Size(386, 37);
            this.label_consulta.TabIndex = 9;
            this.label_consulta.Text = "Consulta De Problemas ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-273, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tecnico a cargo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-169, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // button_regresar
            // 
            this.button_regresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button_regresar.Location = new System.Drawing.Point(756, 261);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(89, 33);
            this.button_regresar.TabIndex = 6;
            this.button_regresar.Text = "Regresar";
            this.button_regresar.UseVisualStyleBackColor = false;
            this.button_regresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_ejemplo
            // 
            this.pictureBox_ejemplo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ejemplo.Image")));
            this.pictureBox_ejemplo.Location = new System.Drawing.Point(3, 96);
            this.pictureBox_ejemplo.Name = "pictureBox_ejemplo";
            this.pictureBox_ejemplo.Size = new System.Drawing.Size(862, 78);
            this.pictureBox_ejemplo.TabIndex = 5;
            this.pictureBox_ejemplo.TabStop = false;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 306);
            this.Controls.Add(this.label_consulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_regresar);
            this.Controls.Add(this.pictureBox_ejemplo);
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consulta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ejemplo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_regresar;
        private System.Windows.Forms.PictureBox pictureBox_ejemplo;
    }
}