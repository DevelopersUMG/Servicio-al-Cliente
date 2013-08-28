using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conexion;
using MySql.Data.MySqlClient;

namespace Servicio_al_Ciente
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

     

        private void button_registrar_Click(object sender, EventArgs e)
        {
            conexion con = new conexion();           
            string nom = text_nombre.Text;
            string ape=text_apellido.Text;
            string cor = text_correo.Text + "@" + combobox_correo.SelectedItem.ToString();
            string user=text_user.Text;
            string pas=text_pasword.Text;
            string nac=dt_fecha.Text;
            string tel = text_telefono.Text;
            string sex=combobox_sexo.SelectedItem.ToString();




            try
            {
                con.Conectar();
                con.inserta_user(nom, ape, cor, user, pas, nac, tel, sex);
                con.Desconectar();

                text_nombre.Text = "";
                text_apellido.Text = "";
                text_correo.Text = "";
                text_user.Text = "";
                text_pasword.Text = "";
                dt_fecha.Text = "";
                text_telefono.Text = "";
                combobox_correo.Text = "";
                combobox_sexo.Text = "";

                MessageBox.Show("Registro exitoso");
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Error de registro de datos");
            }              
                            

        }

       
    }
}
