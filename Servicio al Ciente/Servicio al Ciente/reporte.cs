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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            Ingreso repo = new Ingreso();
            repo.Show();
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consulta frm = new Consulta();
            frm.Show();
            this.Hide();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
