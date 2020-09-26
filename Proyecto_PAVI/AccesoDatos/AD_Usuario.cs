using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_PAVI.AccesoBD
{
    public class AD_Usuario
    {

        public static bool validar_usuario(string usuario,string password)
        {
            bool resultado;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion );
            try
            {
                
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT* FROM USUARIOS WHERE USUARIO=@USUARIO AND PASSWORD=@PASSWORD ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@USUARIO",usuario );
                cmd.Parameters.AddWithValue("@PASSWORD", password );
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd );

                da.Fill(table);

                if (table.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                

                return resultado;

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
