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

        public DataSet MateriasPorAlumno(int dni)
        {
            string query = $"SELECT a.Id_Materia, b.Nombre, b.Turno, a.Aprobada FROM Cursos AS a INNER JOIN Materias AS b ON A.Id_Materia=b.Id WHERE a.Dni='{dni}'";

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
