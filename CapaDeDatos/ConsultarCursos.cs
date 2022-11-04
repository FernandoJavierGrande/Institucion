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

        public DataSet MateriasPorAlumno(string dni)
        {

            string query = $"SELECT a.IdAlumno, a.IdMateria, b.Nombre, b.Turno, a.Aprobado FROM Cursos AS a INNER JOIN Materias AS b ON A.IdMateria=b.IdMateria WHERE a.IdAlumno={dni}";

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
    }
}
