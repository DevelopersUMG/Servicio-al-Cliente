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



    public partial class Login : Form
    {

        
       public Login()
        {
            InitializeComponent();
        }

       int contol=0;


   
      
        private void button1_Click(object sender, EventArgs e)
        {

            conexion con = new conexion();
            Boolean estado = false;
           
           
                estado = con.consulta_log(text_user.Text, text_pas.Text);

                if (estado == true)
                {
                    Ventana frm = new Ventana();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error de servidor");
                }       
           

        }

        private void button2_Click(object sender, EventArgs e)
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

    }
}
