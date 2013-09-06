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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_prod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ingresar = new System.Windows.Forms.Button();
            this.label_ingreso_descr = new System.Windows.Forms.Label();
            this.text_descr = new System.Windows.Forms.TextBox();
            this.cmb_sop = new System.Windows.Forms.ComboBox();
            this.label_tipo_sop = new System.Windows.Forms.Label();
            this.dt_fech = new System.Windows.Forms.DateTimePicker();
            this.label_ingreso_fecha = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label_bienvenido
            // 
            this.label_bienvenido.AutoSize = true;
            this.label_bienvenido.BackColor = System.Drawing.SystemColors.Control;
            this.label_bienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bienvenido.ForeColor = System.Drawing.Color.Black;
            this.label_bienvenido.Location = new System.Drawing.Point(136, 27);
            this.label_bienvenido.Name = "label_bienvenido";
            this.label_bienvenido.Size = new System.Drawing.Size(627, 39);
            this.label_bienvenido.TabIndex = 16;
            this.label_bienvenido.Text = "Bienvenido usuario al menu de reportes";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 80);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 437);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso de caso";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.cmb_prod);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_ingresar);
            this.groupBox2.Controls.Add(this.label_ingreso_descr);
            this.groupBox2.Controls.Add(this.text_descr);
            this.groupBox2.Controls.Add(this.cmb_sop);
            this.groupBox2.Controls.Add(this.label_tipo_sop);
            this.groupBox2.Controls.Add(this.dt_fech);
            this.groupBox2.Controls.Add(this.label_ingreso_fecha);
            this.groupBox2.Location = new System.Drawing.Point(65, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 334);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso de datos del caso";
            // 
            // cmb_prod
            // 
            this.cmb_prod.FormattingEnabled = true;
            this.cmb_prod.Location = new System.Drawing.Point(302, 113);
            this.cmb_prod.Name = "cmb_prod";
            this.cmb_prod.Size = new System.Drawing.Size(236, 21);
            this.cmb_prod.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Seleccione el producto ";
            // 
            // button_ingresar
            // 
            this.button_ingresar.BackColor = System.Drawing.SystemColors.Control;
            this.button_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button_ingresar.Location = new System.Drawing.Point(556, 299);
            this.button_ingresar.Name = "button_ingresar";
            this.button_ingresar.Size = new System.Drawing.Size(91, 29);
            this.button_ingresar.TabIndex = 38;
            this.button_ingresar.Text = "Ingresar";
            this.button_ingresar.UseVisualStyleBackColor = false;
            this.button_ingresar.Click += new System.EventHandler(this.button_ingresar_Click);
            // 
            // label_ingreso_descr
            // 
            this.label_ingreso_descr.AutoSize = true;
            this.label_ingreso_descr.BackColor = System.Drawing.SystemColors.Control;
            this.label_ingreso_descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_ingreso_descr.Location = new System.Drawing.Point(29, 149);
            this.label_ingreso_descr.Name = "label_ingreso_descr";
            this.label_ingreso_descr.Size = new System.Drawing.Size(259, 18);
            this.label_ingreso_descr.TabIndex = 37;
            this.label_ingreso_descr.Text = "Ingrese la descripcion del reporte";
            // 
            // text_descr
            // 
            this.text_descr.Location = new System.Drawing.Point(302, 149);
            this.text_descr.Multiline = true;
            this.text_descr.Name = "text_descr";
            this.text_descr.Size = new System.Drawing.Size(345, 137);
            this.text_descr.TabIndex = 36;
            // 
            // cmb_sop
            // 
            this.cmb_sop.FormattingEnabled = true;
            this.cmb_sop.Location = new System.Drawing.Point(302, 74);
            this.cmb_sop.Name = "cmb_sop";
            this.cmb_sop.Size = new System.Drawing.Size(236, 21);
            this.cmb_sop.TabIndex = 35;
            // 
            // label_tipo_sop
            // 
            this.label_tipo_sop.AutoSize = true;
            this.label_tipo_sop.BackColor = System.Drawing.SystemColors.Control;
            this.label_tipo_sop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_tipo_sop.Location = new System.Drawing.Point(29, 73);
            this.label_tipo_sop.Name = "label_tipo_sop";
            this.label_tipo_sop.Size = new System.Drawing.Size(210, 18);
            this.label_tipo_sop.TabIndex = 34;
            this.label_tipo_sop.Text = "Seleccione tipo de soporte";
            // 
            // dt_fech
            // 
            this.dt_fech.Location = new System.Drawing.Point(302, 37);
            this.dt_fech.Name = "dt_fech";
            this.dt_fech.Size = new System.Drawing.Size(236, 20);
            this.dt_fech.TabIndex = 33;
            // 
            // label_ingreso_fecha
            // 
            this.label_ingreso_fecha.AutoSize = true;
            this.label_ingreso_fecha.BackColor = System.Drawing.SystemColors.Control;
            this.label_ingreso_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_ingreso_fecha.Location = new System.Drawing.Point(29, 39);
            this.label_ingreso_fecha.Name = "label_ingreso_fecha";
            this.label_ingreso_fecha.Size = new System.Drawing.Size(174, 18);
            this.label_ingreso_fecha.TabIndex = 32;
            this.label_ingreso_fecha.Text = "Ingrese fecha de caso";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(814, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(49, 34);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(715, 371);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(707, 345);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Todos los casos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(707, 345);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Casos Pendiente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(45, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(620, 289);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(707, 345);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Casos Resueltos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(45, 26);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(620, 289);
            this.dataGridView3.TabIndex = 0;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Servicio_al_Ciente.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 559);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_bienvenido);
            this.Name = "Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Casos";
            this.Load += new System.EventHandler(this.Reporte_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_bienvenido;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dt_fech;
        private System.Windows.Forms.Label label_ingreso_fecha;
        private System.Windows.Forms.ComboBox cmb_sop;
        private System.Windows.Forms.Label label_tipo_sop;
        private System.Windows.Forms.Button button_ingresar;
        private System.Windows.Forms.Label label_ingreso_descr;
        private System.Windows.Forms.TextBox text_descr;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox cmb_prod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;

    }
}