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
   public class AD_Curso
    {
        public static DataTable obtenerListado()
        {
           
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT ID_CURSO,NOMBRE,ID_CATEGORIA,FECHA_VIGENCIA FROM CURSOS WHERE BORRADO=@BORRADO";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@BORRADO", 0);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();

                da.Fill(table );
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

        public static DataTable obtenerCursos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM CURSOS WHERE BORRADO=0";

                cmd.Parameters.Clear();

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

       
        public static Curso RecuperarCurso(int id)
        {
            Curso c = new Curso();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT ID_CURSO,NOMBRE,ID_CATEGORIA,FECHA_VIGENCIA,DESCRIPCION FROM CURSOS WHERE ID_CURSO=@ID";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID",id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read() && dr != null )
                {
                    c.Id_curso = int.Parse(dr["id_curso"].ToString());
                    c.Nombre = dr["nombre"].ToString();
                    c.Descripcion = dr["descripcion"].ToString();
                    c.Fecha_vigencia = DateTime.Parse(dr["fecha_vigencia"].ToString ());
                    c.Id_categoria = int.Parse(dr["id_categoria"].ToString ());            
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
            return c;
        }

        public static bool RegistrarCurso(int id,string nombre,int id_categoria,string descripcion,DateTime fecha)
        {

            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO CURSOS VALUES(@ID,@NOMBRE,@DESCRIPCION,@FECHA,@ID_CATEGORIA,@BORRADO)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@NOMBRE", nombre );
                cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion );
                cmd.Parameters.AddWithValue("@FECHA", fecha );
                cmd.Parameters.AddWithValue("@ID_CATEGORIA", id_categoria );
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

        public static bool EliminarCurso(int id)
        {

            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE CURSOS SET BORRADO=@BORRADO WHERE ID_CURSO=@ID";

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

        public static bool ModificarCurso(int id, string nombre, int id_categoria, string descripcion, DateTime fecha)
        {

            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE CURSOS SET NOMBRE=@NOMBRE, DESCRIPCION=@DESCRIPCION, FECHA_VIGENCIA=@FECHA, ID_CATEGORIA=@ID_CATEGORIA WHERE ID_CURSO=@ID";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@NOMBRE", nombre);
                cmd.Parameters.AddWithValue("@DESCRIPCION", descripcion);
                cmd.Parameters.AddWithValue("@FECHA", fecha);
                cmd.Parameters.AddWithValue("@ID_CATEGORIA", id_categoria);
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
