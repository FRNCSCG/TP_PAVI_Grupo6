using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI.AccesoDatos
{
    class AD_AvanceCurso
    {
        

        public static void RegistrarAvance(int id_usuario, int id_curso, DateTime fecha_inicio, DateTime fecha_fin, SqlCommand cmd)
        {

            try
            {
 
                string consulta = "INSERT INTO USUARIOSCURSOAVANCE(ID_USUARIO,ID_CURSO,INICIO,FIN,PORC_AVANCE) VALUES(@ID_USUARIO,@ID_CURSO,@FECHA_INICIO,@FECHA_FIN,@PORC_AVANCE)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
                cmd.Parameters.AddWithValue("@ID_CURSO", id_curso);
                cmd.Parameters.AddWithValue("@FECHA_INICIO", fecha_inicio);
                cmd.Parameters.AddWithValue("@FECHA_FIN", fecha_fin);
                cmd.Parameters.AddWithValue("@PORC_AVANCE", 1);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.ExecuteNonQuery();

            }
            catch
            {
                throw;
            }


        }


        public static bool EliminarAvance(int id_curso, int id_usuario, DateTime fecha_inicio)
        {        
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM USUARIOSCURSOAVANCE WHERE ID_CURSO=@ID_CURSO AND ID_USUARIO=@ID_USUARIO AND INICIO=@FECHA_INICIO";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
                cmd.Parameters.AddWithValue("@ID_CURSO", id_curso);
                cmd.Parameters.AddWithValue("@FECHA_INICIO", fecha_inicio); ;
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
