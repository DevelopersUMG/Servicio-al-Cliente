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
    public partial class Producto : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;



        public Producto()
        {
            InitializeComponent();
        }



        //open connection to database
        private bool OpenConnection()
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

            private void button1_Click(object sender, EventArgs e)
            {
                conexion con = new conexion(); 
                string nompr = text_nombrepr.Text;
                string tipo= text_tipo.Text;
                string cant = text_cantidad.Text;
                string precio= text_precio.Text;
            
                  try
                {
                    con.Conectar();
                    con.inserta_producto(nompr, tipo, cant, precio);
                    con.Desconectar();

            
                    text_nombrepr.Text = "";
                    text_tipo.Text = "";
                    text_cantidad.Text = "";
                    text_precio.Text = "";
                    

                    MessageBox.Show("Registro exitoso");
                
                }
                  catch
                  {
                      MessageBox.Show("Error de registro de datos");
                  }                          

            }

            private void Producto_Load(object sender, EventArgs e)
            {
                

               

             server = "localhost";
            database = "servicioalcliente";
            uid = "root";
            password = "toor";
            string connectionString;

            connectionString = "SERVER=localhost;DATABASE=servicioalcliente;UID=root;PASSWORD=toor;";
          //  connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
 
            connection = new MySqlConnection(connectionString);

            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from tblproducto", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

                //close connection
                this.CloseConnection();
            }

        
             }
            private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
            {

                DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();

                if (changes != null)
                {
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                    mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                    mySqlDataAdapter.Update(changes);
                    ((DataTable)dataGridView1.DataSource).AcceptChanges();
                }
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
            

            

    }
}
