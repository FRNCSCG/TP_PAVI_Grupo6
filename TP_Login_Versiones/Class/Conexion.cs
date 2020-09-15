using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TP_Login_Versiones.Class
{
    class Conexion
    {
        private SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["CadenaDB"]);
        private SqlCommand comando = new SqlCommand();
        

        

        public void CONECTAR()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;

                }
            }
            catch
            {
                MessageBox.Show("Error al establecer conexion");
            }

        }

        public void DESCONECTAR()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();

                }


            }
            catch
            {
                MessageBox.Show("Error al finalizar conexion");
            }

        }

        public DataTable consultar(string consultaSQL)
        {


            DataTable tabla = new DataTable();
            this.CONECTAR();
            this.comando.CommandText = consultaSQL;
            tabla.Load(this.comando.ExecuteReader());
            this.DESCONECTAR();
            return tabla;
        }
        public DataTable consultarTabla(string nombreTabla)
        {

            DataTable tabla = new DataTable();
            this.CONECTAR();
            this.comando.CommandText = "Select * from " + nombreTabla + " WHERE borrado=0";
            tabla.Load(this.comando.ExecuteReader());
            this.DESCONECTAR();
            return tabla;

        }
        public void actualizar(string consultaSQL)
        {
            this.CONECTAR();
            this.comando.CommandText = consultaSQL;
            this.comando.ExecuteNonQuery();
            this.DESCONECTAR();
        }


               
        public bool VALIDAR_USUARIO(string usuario, string password)
        {
           
            comando.CommandText = "SELECT * FROM USUARIOS WHERE USUARIO='" + usuario + "' AND PASSWORD='" + password + "'";

            CONECTAR();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(table);

            DESCONECTAR();

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Inicio de sesion correcto");
                return true;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto");
                return false;
            }
        }

        public void CARGAR_CURSO(int Id,string Nombre,string Descripcion,DateTime Vigencia,int Categoria,int Borrado)
        {
            try
            {
                string consulta = "Insert into cursos values(@ID,@NOMBRE,@DESCRIPCION,@VIGENCIA,@CATEGORIA,@BORRADO)";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ID", Id);
                comando.Parameters.AddWithValue("@NOMBRE", Nombre );
                comando.Parameters.AddWithValue("@DESCRIPCION", Descripcion  );
                comando.Parameters.AddWithValue("@VIGENCIA", Vigencia );
                comando.Parameters.AddWithValue("@CATEGORIA", Categoria );
                comando.Parameters.AddWithValue("@BORRADO", Borrado );
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;

                CONECTAR();
                comando.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Error al registrar curso");

            }
            finally
            {
                DESCONECTAR();
            }

        }

        public void ACTUALIZAR_CURSO(int Id, string Nombre, string Descripcion, DateTime Vigencia, int Categoria)
        {
            try
            {
                string consulta = "update cursos set nombre=@NOMBRE, descripcion=@DESCRIPCION, fecha_vigencia=@VIGENCIA, id_categoria=@CATEGORIA where id_curso=@ID";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ID", Id);
                comando.Parameters.AddWithValue("@NOMBRE", Nombre);
                comando.Parameters.AddWithValue("@DESCRIPCION", Descripcion );
                comando.Parameters.AddWithValue("@VIGENCIA", Vigencia);
                comando.Parameters.AddWithValue("@CATEGORIA", Categoria);
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;

                CONECTAR();
                comando.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Error al actualizar curso");

            }
            finally
            {
                DESCONECTAR();
            }

        }

        public void ELIMINAR_CURSO(int Id)
        {
            try
            {
                string consulta = "DELETE FROM cursos where id_curso=@ID";

                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ID", Id);
                comando.CommandType = CommandType.Text;
                comando.CommandText = consulta;

                CONECTAR();
                comando.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Error al eliminar curso");

            }
            finally
            {
                DESCONECTAR();
            }

        }
    }
}
