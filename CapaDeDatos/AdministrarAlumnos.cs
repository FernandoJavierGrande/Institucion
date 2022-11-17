using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class AdministrarAlumnos : DatosConexion
    {
        SqlCommand cmd;

        public bool CrearAlumno(Alumno alumno)
        {
            string query = $"INSERT INTO Alumnos VALUES ('{alumno.Dni}','{alumno.Nombre}','{alumno.Apellido}','{alumno.Edad}','{alumno.FechaIngreso}')";
            int rows;

            try
            {
                AbrirConn();

                cmd = new SqlCommand(query, conexion);

                rows = cmd.ExecuteNonQuery();

                if (rows < 1) throw new Exception($"No se pudo crear el alumno {alumno.Dni}");

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                CerrarConn();
                cmd.Dispose();
            }
        }

        public DataTable Listar_Alumnos(string dni = "0")
        {
            string query;

            if (dni == "0")
            {
                query = "SELECT * FROM Alumnos";
            }
            else
            {
                query = $"SELECT * FROM Alumnos WHERE Dni='{dni}'";
            }

            SqlCommand cmd = new SqlCommand(query, conexion);

            DataTable dt = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            try
            {
                AbrirConn();
                cmd.ExecuteNonQuery();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);

                return dt;
            }
            catch (Exception)
            {

                return dt = null;
                throw new Exception("No se pudo realizar la busqueda");
            }
            finally
            {
                CerrarConn();
                cmd.Dispose();
            }
        }

        public bool Mod_Alumno(Alumno alumno)
        {
            #region eliminar
            //DataSet resp = Listar_Alumnos(alumno.Dni);
            //Alumno alumnoMod = new Alumno(); //ver

            //if (resp.Tables.Count < 1) 
            //    return false;

            //alumnoMod.IdAlumno = int.Parse( resp.Tables[0].Rows[0]["IdAlumno"].ToString());
            #endregion
            //$"UPDATE Alumnos SET Dni = '{alumno.Dni}', Nombre = '{alumno.Nombre}', Apellido = '{alumno.Apellido}', Edad = {alumno.Edad}, FechaInicio ='{alumno.FechaIngreso}' FROM (SELECT a.IdAlumno FROM Alumnos AS a WHERE a.Dni ='{dni}') AS id WHERE Alumnos.IdAlumno = id.IdAlumno";


            string query = $"UPDATE Alumnos SET Dni = '{alumno.Dni}', Nombre = '{alumno.Nombre}', Apellido = '{alumno.Apellido}', Edad = {alumno.Edad}, FechaInicio ='{alumno.FechaIngreso}' WHERE IdAlumno = {alumno.IdAlumno}";
            int rows;
            Console.WriteLine(alumno.Dni);
            try
            {
                AbrirConn();
                cmd = new SqlCommand(query, conexion);
                
                rows = cmd.ExecuteNonQuery();

                if (rows < 1) throw new Exception("No se pudo modificar");

                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                CerrarConn();
                cmd.Dispose();
            }
        }

        public bool EliminarAlumno(string dni)
        {
            string query = $"DELETE FROM Alumnos WHERE Dni='{dni}'";
            int rows;
            try
            {
                AbrirConn();
                cmd = new SqlCommand(query, conexion);

                rows = cmd.ExecuteNonQuery();

                if (rows < 1) throw new Exception("No se pudo Eliminar");

                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                CerrarConn();
                cmd.Dispose();
            }

        }
    }
}
