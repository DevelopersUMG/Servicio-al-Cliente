using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conexion;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections;


namespace Servicio_al_Ciente
{
    public partial class RegistroEmpleado : Form
    {
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;

     /*   private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }


        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        */
        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {
           
            MySqlConnection myConnection = new MySqlConnection();
            myConnection.ConnectionString = "SERVER=localhost;DATABASE=servicioalcliente;UID=root;PASSWORD=toor;";
            myConnection.Open();


            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = "select nom_puesto, id_puestoemp from tblpuestoempleado;";
            da.SelectCommand = new MySqlCommand(sql, myConnection);
            da.Fill(ds);
            cmbpuesto.DataSource = ds.Tables[0];
            cmbpuesto.DisplayMember = "nom_puesto";
            cmbpuesto.ValueMember = "id_puestoemp";
         


          
            MySqlDataAdapter daa = new MySqlDataAdapter();
            DataSet dss = new DataSet();
            string sqll = "select id_tiposop,tipo_sop from tbltiposoporte;";
            daa.SelectCommand = new MySqlCommand(sqll, myConnection);
            daa.Fill(dss);
            cmbsoporte.DataSource = dss.Tables[0];
            cmbsoporte.DisplayMember = "tipo_sop";
            cmbsoporte.ValueMember = "id_tiposop";
        
           
            mySqlDataAdapter = new MySqlDataAdapter("select * from tblusuario", myConnection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];

            myConnection.Close();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            string nom = text_nom.Text;
            string dir = text_dir.Text;     
            string tel = text_tel.Text;
            string puesto = cmbpuesto.SelectedValue.ToString();
            string soporte = cmbsoporte.SelectedValue.ToString();

            
            conexion con = new conexion();

            try
            {
                con.Conectar();
                con.inserta_empleado(nom, dir, tel, puesto, soporte);
                con.Desconectar();
                text_nom.Text = "";
                text_dir.Text = "";
                text_tel.Text = "";
              
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
