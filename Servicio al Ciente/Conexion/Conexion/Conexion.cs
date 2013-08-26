using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace Conexion
{
    public class conexion
    {
        MySqlConnection connection = new MySqlConnection();
        public String usu;
        public String pas;
        String con;
      

        public void conecta()
        {

            try
            {
                con = "Server=localhost;"
                       + "Port=3306;"
                       + "Database=servicioalcliente;"
                       + "Uid=root;"
                       + "Password=toor";

                connection.ConnectionString = con;
                connection.Open();
                //MessageBox.Show("Conexion Exitosa");

            }
            catch (MySqlException)
            {
                //MessageBox.Show("Error al conectar a la base de datos");
            }

        }

        public Boolean consulta_log(String user, String pass) {

            conecta();

          
            Boolean estado = false;

            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "select user_user,pas_user from usuario where user_user='"
                                 + user + "' and pas_user='" + pass + "';";

            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                usu = reader["user_user"].ToString();
                pas = reader["pas_user"].ToString();

            }

            if (user.Equals(usu) && pass.Equals(pas))
            {

                estado = true;
            }
            else
            {
                estado = false;
            }
            return estado;

        }


        public int count() {

            string query = "SELECT COUNT(*) FROM usuario";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = connection;
            int count = (int)cmd.ExecuteScalar();
            return count;


        }
      

        public void inserta_user(string nom, string ape, string cor, string user,string pas,string nac,string tel,string sex) {
            

            conecta();

            conexion con = new conexion();
            int cod = con.count();

         
        
            MySqlCommand cmd = new MySqlCommand();
<<<<<<< HEAD
            string strSQL = "insert into usuario values(" + 3 + ",'" + nom + "','" + ape + "','" + cor + "','" + user + "','" + pas + "','" + nac + "','" + tel + "','" + sex + "');";
=======
            string strSQL = "insert into usuario values(" + cod + ",'" + nom + "','" + ape + "','" + cor + "','" + user + "','" + pas + "','" + nac + "','" + tel + "','" + sex + "');";
>>>>>>> origin/Olivia-Perez
            cmd.CommandText = strSQL;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();


     
            
            
 
        }

    }
}
