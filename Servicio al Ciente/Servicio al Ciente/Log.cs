using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Conexion;

namespace Servicio_al_Ciente
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        public string nomusuario;


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario frm = new RegistroUsuario();
            frm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperaUsuario frm = new RecuperaUsuario();
            frm.Show();
            this.Hide();
        }

     

        public void verifica() {

            conexion con = new conexion();
            con.Conectar();
         
            try
            {
                con.consulta_log(text_user.Text, text_pas.Text);

                if (con.id.Equals("1"))
                {
                    VentanaAdmin frm = new VentanaAdmin();
                    frm.Show();
                    this.Hide();

                }


                if (con.id.Equals("2"))
                {

                    VentanaUser frm = new VentanaUser();
                    
                    frm.Show();
                    this.Hide();
                    

                }

              
            }
            catch
            {
                MessageBox.Show("Error al iniciar session");
                text_user.Text = "";
                text_pas.Text = "";
            }


            con.Desconectar();
        
        }


        private void button_login_Click(object sender, EventArgs e)
        {
            verifica();
                       
        }

        private void text_pas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                // Lo que hará al presionarse Enter
                verifica();
            }
        }
    }
}
