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

        public DataSet Listar_Alumnos(string dni = "0")
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

            DataSet dataSet = new DataSet();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            try
            {
                AbrirConn();
                cmd.ExecuteNonQuery();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dataSet);

                return dataSet;
            }
            catch (Exception)
            {

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
            DataSet resp = Listar_Alumnos(alumno.Dni);
            Alumno alumnoMod = new Alumno(); //ver

            if (resp == null) 
                return false;

            string query = $"UPDATE"; //FALTA
            int rows;

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
    }
}
