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
    class AD_HistorialInscripcion
    {

        public static DataTable obtenerListado()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT ID_HISTORIAL,DESCRIPCION,RESPONSABLE,FECHA,ID_INSCRIPTO,ID_CURSO FROM HISTORIALINSCRIPCIONES";

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


        public static void RegistrarHistorial(string responsable, int id_inscripto, int id_curso, SqlCommand cmd, int modo)
        {


            try
            {
                string consulta = "INSERT INTO HISTORIALINSCRIPCIONES (DESCRIPCION,RESPONSABLE,FECHA,ID_INSCRIPTO,ID_CURSO) VALUES(@DESCRIPCION,@RESPONSABLE,@FECHA,@ID_INSCRIPTO,@ID_CURSO)";

                cmd.Parameters.Clear();

                switch (modo)
                {
                    case 1:
                        cmd.Parameters.AddWithValue("@DESCRIPCION", "Nueva inscripcion");
                        break;
                    case 2:
                        cmd.Parameters.AddWithValue("@DESCRIPCION", "Modificacion de inscripcion");
                        break;
                    case 3:
                        cmd.Parameters.AddWithValue("@DESCRIPCION", "Eliminacion de inscripcion");
                        break;
                }
                cmd.Parameters.AddWithValue("@RESPONSABLE", responsable);
                cmd.Parameters.AddWithValue("@FECHA", DateTime.Now);
                cmd.Parameters.AddWithValue("@ID_INSCRIPTO", id_inscripto);
                cmd.Parameters.AddWithValue("@ID_CURSO", id_curso);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Error al registrar Historial");
                throw;
            }



        }

        public static DataTable obtenerListadoReporte(DateTime fechaInicio, DateTime fechaFin,int curso, int inscripto, int responsable)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "EXEC ReporteInscripciones @fecha_inicio,@fecha_fin,@curso ,@inscripto,@responsable ";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fecha_inicio", fechaInicio );
                cmd.Parameters.AddWithValue("@fecha_fin", fechaFin);
                cmd.Parameters.AddWithValue("@curso", curso );
                cmd.Parameters.AddWithValue("@inscripto", inscripto );
                cmd.Parameters.AddWithValue("@responsable", responsable);
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


    }
}
