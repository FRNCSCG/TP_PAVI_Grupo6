using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Data.OleDb;

using System.Data.SqlClient;


namespace ProyectoBugs.Clases
{
    class Datos
    {
        private SqlConnection conexion = new SqlConnection();
        private SqlCommand comando = new SqlCommand();

        //private OleDbConnection conexion = new OleDbConnection();
        //private OleDbCommand comando = new OleDbCommand();
        //private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Oscar\UTN\PAVI\2020\3k1\Practico\Clase2\Errores.mdb";
        //private string cadenaConexion = @"Provider=SQLNCLI11;Data Source=190.30.40.40,1433;User ID=pav1;Initial Catalog=PAV1_3K1;password=pav12020";
        private string cadenaConexion = @"Data Source=DESKTOP-NC84MH6\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

        //public string CadenaConexion
        //{
        //    get { return cadenaConexion; }
        //    set { cadenaConexion = value; }
        //}

        public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }

        private void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        private void desconectar()
        {
            conexion.Close();
        }
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            this.conectar();
            this.comando.CommandText = consultaSQL;
            tabla.Load(this.comando.ExecuteReader());
            this.desconectar();
            return tabla;
        }
        public DataTable consultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            this.conectar();
            this.comando.CommandText = "Select * from " + nombreTabla + " WHERE borrado=0";
            tabla.Load(this.comando.ExecuteReader());
            this.desconectar();
            return tabla;
        }
        public void actualizar(string consultaSQL)
        {
            this.conectar();
            this.comando.CommandText = consultaSQL;
            this.comando.ExecuteNonQuery();
            this.desconectar();
        }
    }
}
