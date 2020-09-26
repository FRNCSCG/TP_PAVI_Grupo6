using Proyecto_PAVI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAVI.AccesoDatos
{
    public class AD_Objetivo
    {
        public static DataTable obtenerListadoObjetivos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT ID_OBJETIVO,NOMBRE_CORTO,NOMBRE_LARGO FROM OBJETIVOS WHERE BORRADO=@BORRADO";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@BORRADO", 0);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();

                da.Fill(table);
                return table;

            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        public static DataTable obtenerObjetivos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM OBJETIVOS WHERE BORRADO=@BORRADO";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@BORRADO", 0);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();

                da.Fill(table);
                return table;

            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool EliminarObjetivo(int id)
        {

            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE OBJETIVOS SET BORRADO=@BORRADO WHERE ID_OBJETIVO=@ID";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@BORRADO", 1);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static bool RegistrarObjetivo(int id, string nombre_corto, string nombre_largo)
        {

            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO OBJETIVOS VALUES(@ID,@NOMBRE_CORTO,@NOMBRE_LARGO,@BORRADO)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@NOMBRE_CORTO", nombre_corto);
                cmd.Parameters.AddWithValue("@NOMBRE_LARGO", nombre_largo);
                cmd.Parameters.AddWithValue("@BORRADO", 0);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }

        public static Objetivo RecuperarObjetivo(int id)
        {
            Objetivo o = new Objetivo();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT ID_OBJETIVO,NOMBRE_CORTO,NOMBRE_LARGO FROM OBJETIVOS WHERE ID_OBJETIVO=@ID";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read() && dr != null)
                {
                    o.Id_objetivo  = int.Parse(dr["ID_OBJETIVO"].ToString());
                    o.Nombre_corto  = dr["nombre_corto"].ToString();
                    o.Nombre_largo  = dr["nombre_largo"].ToString();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return o;
        }
        public static bool ModificarObjetivo(int id, string nombre_corto, string nombre_largo)
        {

            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE OBJETIVOS SET NOMBRE_CORTO=@NOMBRE_CORTO, NOMBRE_LARGO=@NOMBRE_LARGO WHERE ID_OBJETIVO=@ID";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@NOMBRE_CORTO", nombre_corto);
                cmd.Parameters.AddWithValue("@NOMBRE_LARGO", nombre_largo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
    }
}
