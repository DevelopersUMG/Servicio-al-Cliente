namespace Servicio_al_Ciente
{
    partial class VentanaAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gentionDeUsuaiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insercionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segimientoDeCasosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gentionDeUsuaiosToolStripMenuItem,
            this.insercionToolStripMenuItem,
            this.segimientoDeCasosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gentionDeUsuaiosToolStripMenuItem
            // 
            this.gentionDeUsuaiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.actualizacionToolStripMenuItem,
            this.recuperacionToolStripMenuItem});
            this.gentionDeUsuaiosToolStripMenuItem.Name = "gentionDeUsuaiosToolStripMenuItem";
            this.gentionDeUsuaiosToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.gentionDeUsuaiosToolStripMenuItem.Text = "Gestion de usuaios";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // actualizacionToolStripMenuItem
            // 
            this.actualizacionToolStripMenuItem.Name = "actualizacionToolStripMenuItem";
            this.actualizacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.actualizacionToolStripMenuItem.Text = "Actualizacion";
            this.actualizacionToolStripMenuItem.Click += new System.EventHandler(this.actualizacionToolStripMenuItem_Click);
            // 
            // recuperacionToolStripMenuItem
            // 
            this.recuperacionToolStripMenuItem.Name = "recuperacionToolStripMenuItem";
            this.recuperacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recuperacionToolStripMenuItem.Text = "Recuperacion";
            this.recuperacionToolStripMenuItem.Click += new System.EventHandler(this.recuperacionToolStripMenuItem_Click);
            // 
            // insercionToolStripMenuItem
            // 
            this.insercionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.soportesToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.insercionToolStripMenuItem.Name = "insercionToolStripMenuItem";
            this.insercionToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.insercionToolStripMenuItem.Text = "Gestion de tablas";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // segimientoDeCasosToolStripMenuItem
            // 
            this.segimientoDeCasosToolStripMenuItem.Name = "segimientoDeCasosToolStripMenuItem";
            this.segimientoDeCasosToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.segimientoDeCasosToolStripMenuItem.Text = "Segimiento de Casos";
            // 
            // soportesToolStripMenuItem
            // 
            this.soportesToolStripMenuItem.Name = "soportesToolStripMenuItem";
            this.soportesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.soportesToolStripMenuItem.Text = "Soportes";
            this.soportesToolStripMenuItem.Click += new System.EventHandler(this.soportesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // VentanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Servicio_al_Ciente.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 638);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de casos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gentionDeUsuaiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insercionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segimientoDeCasosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    }
}