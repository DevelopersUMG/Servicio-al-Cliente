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


   
      
        private void button1_Click(object sender, EventArgs e)
        {
          
            conexion con = new conexion();
            con.Conectar();

            try
            {
                con.consulta_log(text_user.Text, text_pas.Text);

                
                if (con.session == true && con.estado==2)
                {                    
                    VentanaUser frm = new VentanaUser();
                    frm.Show();
                    this.Hide();                    
                }

                if (con.session == true && con.estado == 1)
                {
                    VentanaAdmin frm = new VentanaAdmin();
                    frm.Show();
                    this.Hide();

                }
                if(con.session == false) {
                    MessageBox.Show("Error al inciar session");
                    text_user.Text = "";
                    text_pas.Text = "";
                }
               
            }
            catch {
                MessageBox.Show("Error de servidor");
            }
               

                con.Desconectar();
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
