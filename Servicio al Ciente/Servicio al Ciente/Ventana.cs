using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Servicio_al_Ciente
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte rep = new Reporte();
            rep.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario reg = new RegistroUsuario();
            reg.MdiParent = this;
            reg.Show();
        }

        private void actualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizaDatos act = new ActualizaDatos();
            act.MdiParent = this;
            act.Show();

        }

        private void recuperacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecuperaUsuario rec = new RecuperaUsuario();
            rec.MdiParent = this;
            rec.Show();
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventana ext = new Ventana();
            ext.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte repor = new Reporte();
            repor.MdiParent = this;
            repor.Show();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
