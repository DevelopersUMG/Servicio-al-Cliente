using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conexion;

namespace Servicio_al_Ciente
{
    public partial class Puestos_de_empleados : Form
    {
        public Puestos_de_empleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion con = new conexion();

            string nom = textbox_puesto.Text;
            string sal = textbox_salario.Text;
            string perm = textbox_permisos.Text;

            try
            {
                con.Conectar();
                con.inserta_puesto(nom, sal, perm);
                con.Desconectar();

                textbox_puesto.Text = "";
                textbox_salario.Text = "";
                textbox_permisos.Text = "";



                MessageBox.Show("Registro exitoso");

            }
            catch
            {
                MessageBox.Show("Error de registro de datos");
            }              
                            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleados puest = new Empleados();
            puest.Show();
            this.Hide();

        }
    }
}
