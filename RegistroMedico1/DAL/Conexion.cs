using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace RegistroMedic.BLL.DAL
{

    public class Conexion
    {

        SqlConnection sqlConexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=RegistroPacientes;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
        /// <summary>
        /// para ejecutar todos los codigos
        /// </summary>
        /// <param name="Codigo"></param>
        /// <returns></returns>
        /// 

        public bool EjecutarDB(string Codigo)
        {
            bool mensaje = false;
            SqlCommand cmd = new SqlCommand();

            try
            {
                sqlConexion.Open(); // abrimos la conexion

                cmd.Connection = sqlConexion; //asignamos la conexion
                cmd.CommandText = Codigo;     //asignamos el comando
                cmd.ExecuteNonQuery(); // ejecutamos el comando

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                mensaje = true;
                sqlConexion.Close(); //cerramos la conexion


            }
            return mensaje;
        }

        /// <summary>
        /// para buscar datos en la base de datos
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public DataTable BuscarDb(string comando)
        {
            SqlDataAdapter adp;
            DataTable dt = new DataTable();
            try
            {
                sqlConexion.Open(); // abrimos la conexion
                adp = new SqlDataAdapter(comando, sqlConexion);

                adp.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConexion.Close(); //cerramos la conexion

            }
            return dt;
        }



    }
}