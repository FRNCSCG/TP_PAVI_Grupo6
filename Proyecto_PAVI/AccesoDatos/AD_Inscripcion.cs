﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_PAVI.Entidades;

namespace Proyecto_PAVI.AccesoDatos
{
    class AD_Inscripcion
    {
        public static DataTable obtenerListado()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT ID_USUARIO,ID_CURSO,FECHA_INICIO,FECHA_FIN,PUNTUACION,OBSERVACIONES FROM USUARIOSCURSO";

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

        public static EstudiantesCurso RecuperarInscripcion(int id_curso, int id_usuario)
        {
            EstudiantesCurso est = new EstudiantesCurso();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT ID_USUARIO,ID_CURSO,FECHA_INICIO,FECHA_FIN,PUNTUACION,OBSERVACIONES FROM USUARIOSCURSO WHERE ID_CURSO=@ID_CURSO AND ID_USUARIO=@ID_USUARIO";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_CURSO", id_curso);
                cmd.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read() && dr != null)
                {
                    est.Id_curso = int.Parse(dr["id_curso"].ToString());
                    est.Id_usuario = int.Parse(dr["id_usuario"].ToString());
                    est.Observaciones = dr["observaciones"].ToString();
                    est.Fecha_inicio = DateTime.Parse(dr["fecha_inicio"].ToString());

                    est.Fecha_inicio = DateTime.Parse(dr["fecha_inicio"].ToString());

                    est.Puntuacion = int.Parse(dr["puntuacion"].ToString());
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
            return est;
        }



        public static bool RegistrarInscripcion(int id_usuario, int id_curso, DateTime fecha_inicio, DateTime fecha_fin, int puntuacion, string observaciones, SqlCommand cmd)
        {
            bool resultado = false;

            try
            {
                string consulta = "INSERT INTO USUARIOSCURSO(ID_USUARIO,ID_CURSO,FECHA_INICIO,FECHA_FIN,PUNTUACION,OBSERVACIONES) VALUES(@ID_USUARIO,@ID_CURSO,@FECHA_INICIO,@FECHA_FIN,@PUNTUACION,@OBSERVACION)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
                cmd.Parameters.AddWithValue("@ID_CURSO", id_curso);
                cmd.Parameters.AddWithValue("@FECHA_INICIO", fecha_inicio);
                cmd.Parameters.AddWithValue("@FECHA_FIN", fecha_fin);
                cmd.Parameters.AddWithValue("@PUNTUACION", puntuacion);
                cmd.Parameters.AddWithValue("@OBSERVACION", observaciones);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                cmd.ExecuteNonQuery();

                resultado = true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Inscripcion existente");
            }



            return resultado;
        }






        public static bool EliminarInscripcion(int id_curso, int id_usuario)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM USUARIOSCURSO WHERE ID_CURSO=@ID_CURSO AND ID_USUARIO=@ID_USUARIO";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
                cmd.Parameters.AddWithValue("@ID_CURSO", id_curso);
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

        public static bool ModificarInscripcion(int id_curso, int id_usuario, int puntuacion, string observaciones) { 

            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE USUARIOSCURSO SET  PUNTUACION=@PUNTUACION, OBSERVACIONES=@OBSERVACIONES WHERE ID_CURSO=@ID_CURSO AND ID_USUARIO=@ID_USUARIO ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_USUARIO", id_usuario );
                cmd.Parameters.AddWithValue("@ID_CURSO", id_curso );
                cmd.Parameters.AddWithValue("@PUNTUACION", puntuacion );
                cmd.Parameters.AddWithValue("@OBSERVACIONES", observaciones);
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

        public static bool RegistrarTransaccion(int id_usuario, int id_curso, DateTime fecha_inicio, DateTime fecha_fin, int puntuacion, string observaciones)
        {
            bool ins = false;
            bool curAvanc = false;
            bool resultado = false;
            
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            
            SqlCommand cmd = cn.CreateCommand();
            
            //comenzar una transaccion
            SqlTransaction transaction;
            transaction = cn.BeginTransaction();

            //se asigna objeto de transaccion y conexion al Objeto comando
            cmd.Connection = cn;
            cmd.Transaction = transaction;

            try
            {
                //insert inscripcion (tabla UsuariosCurso)
                ins = RegistrarInscripcion(id_usuario, id_curso, fecha_inicio, fecha_fin, puntuacion, observaciones, cmd);

                //insert avance (tabla UsuariosCursoavance)
                curAvanc = AD_AvanceCurso.RegistrarAvance(id_usuario, id_curso, fecha_inicio, fecha_fin, cmd);

                //si ambos se realizaron exitosamente, se hace commit 
                if (ins == true && curAvanc == true)
                {
                    transaction.Commit();
                    resultado = true;
                }

            }
            catch
            {
                transaction.Rollback();
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