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
   public class AdministrarCursos: DatosConexion
    {
        SqlCommand cmd;

        public DataTable MateriasPorAlumno(int IdAlumno)
        {

            string query = $"SELECT a.IdMateria, b.Nombre, b.Turno, a.Aprobado FROM Cursos AS a INNER JOIN Materias AS b ON A.IdMateria=b.IdMateria WHERE a.IdAlumno={IdAlumno}";

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
            catch (Exception) { throw new Exception("Error intente nuevamente"); }
            finally
            {
                CerrarConn();
                cmd.Dispose();
            }
        }

        public DataTable AlumnosPorMateria(int id)
        {

            string query = $"SELECT  a.IdAlumno, b.Nombre, b.Apellido, b.Dni, a.Aprobado FROM CURSOS AS a INNER JOIN Alumnos AS b ON a.IdAlumno = b.IdAlumno WHERE a.IdMateria = {id}";

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
            catch (Exception) { throw new Exception("Error intente nuevamente"); }
            finally
            {
                CerrarConn();
                cmd.Dispose();
            }
        }
        public bool EliminarCursada(int idAlumno, int idMateria)
        {
            string query = $"DELETE FROM Cursos WHERE IdAlumno = {idAlumno} AND IdMateria={idMateria}";
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
        public bool CrearCursada(int idmateria, bool aprobado, string dni)
        {
            AdministrarAlumnos alumn = new AdministrarAlumnos();
            DataTable dt = new DataTable();
            
            dt = alumn.Listar_Alumnos(dni);
            int id = int.Parse(dt.Rows[0][0].ToString());
            Console.WriteLine($"valor de id = {id}");
            string query = $"INSERT INTO Cursos VALUES ({id},{idmateria},'{aprobado}')";

            int rows;

            try
            {
                AbrirConn();

                cmd = new SqlCommand(query, conexion);

                rows = cmd.ExecuteNonQuery();

                if (rows < 1) throw new Exception($"No se pudo crear");

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
        public bool aprobado(Cursos curso)
        {
            string query = $"UPDATE Cursos SET Aprobado ='{curso.Aprobada}' WHERE IdAlumno = {curso.IdAlumno} AND IdMateria ={curso.Id_Materia}";
            int rows;
            try
            {
                AbrirConn();

                cmd = new SqlCommand(query, conexion);

                rows = cmd.ExecuteNonQuery();

                if (rows < 1) throw new Exception($"No se pudo actualizar");

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(query);
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
