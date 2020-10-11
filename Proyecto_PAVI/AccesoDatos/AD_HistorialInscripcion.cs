using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string consulta = "SELECT ID_HISTORIAL,DESCRIPCION,ID_RESPONSABLE,FECHA,ID_INSCRIPTO,ID_CURSO FROM HISTORIALINSCRIPCIONES";

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


        public static void RegistrarHistorial(int id_responsable, int id_inscripto, int id_curso, SqlCommand cmd, int modo)
        {


            try
            {
                string consulta = "INSERT INTO HISTORIALINSCRIPCIONES (DESCRIPCION,ID_RESPONSABLE,FECHA,ID_INSCRIPTO,ID_CURSO) VALUES(@DESCRIPCION,@ID_RESPONSABLE,@FECHA,@ID_INSCRIPTO,@ID_CURSO)";

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
                cmd.Parameters.AddWithValue("@ID_RESPONSABLE", id_responsable);
                cmd.Parameters.AddWithValue("@FECHA", DateTime.Now);
                cmd.Parameters.AddWithValue("@ID_INSCRIPTO", id_inscripto);
                cmd.Parameters.AddWithValue("@ID_CURSO", id_curso);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.ExecuteNonQuery();

            }
            catch
            {
                throw;
            }



        }




    }
}
