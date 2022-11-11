using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
   public class ConsultarCursos: DatosConexion
    {
        SqlCommand cmd;

        public DataSet MateriasPorAlumno(int IdAlumno)
        {

            string query = $"SELECT a.IdAlumno, a.IdMateria, b.Nombre, b.Turno, a.Aprobado FROM Cursos AS a INNER JOIN Materias AS b ON A.IdMateria=b.IdMateria WHERE a.IdAlumno={IdAlumno}";

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
            catch (Exception) { throw new Exception("Error intente nuevamente"); }
            finally
            {
                CerrarConn();
                cmd.Dispose();
            }
        }

        public DataSet AlumnosPorMateria(int id)
        {

            string query = $"SELECT  a.IdAlumno, b.Nombre, b.Apellido, b.Dni, a.Aprobado FROM CURSOS AS a INNER JOIN Alumnos AS b ON a.IdAlumno = b.IdAlumno WHERE a.IdMateria = {id}";

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
    }
}
