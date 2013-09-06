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
    public partial class GestorUsuario : Form
    {
        public GestorUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroUsuario reg = new RegistroUsuario();
            reg.MdiParent = this.MdiParent;
            reg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizaDatos act = new ActualizaDatos();
            act.MdiParent = this.MdiParent;
            act.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RecuperaUsuario rec = new RecuperaUsuario();
            rec.MdiParent = this.MdiParent;
            rec.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActualizaPermisos act = new ActualizaPermisos();
            act.MdiParent = this.MdiParent;
            act.Show();
            this.Hide();
        }

        
    }
}
