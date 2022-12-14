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
    public class AdministrarMaterias : DatosConexion
    {
        SqlCommand cmd;

        public bool AgregarMateria(Materia materia )
        {
           
            string query = $"INSERT INTO Materias VALUES ('{materia.Nombre}','{materia.Turno}')";
            int rows;

            try
            {
                AbrirConn();

                cmd = new SqlCommand(query, conexion);

                rows = cmd.ExecuteNonQuery();

                if (rows < 1) throw new Exception($"No se pudo agregar la materia: {materia.Nombre}");

                return true;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                CerrarConn();
                cmd.Dispose();
            }
        }
        public DataTable Listar_Materias(string nombreMateria = "void")
        {
            string query;
            if (nombreMateria.Equals("void"))
            {
                query = $"SELECT * FROM Materias ORDER BY Nombre ASC";
            }
            else
            {
                query = $"SELECT * FROM Materias WHERE Nombre LIKE '{nombreMateria}' ORDER BY Nombre ASC";
            }

            

            SqlCommand cmd = new SqlCommand(query, conexion);

            DataTable dt = new DataTable();

            SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);

            try
            {
                AbrirConn();
                cmd.ExecuteNonQuery();
                DataAdapter.SelectCommand = cmd;
                DataAdapter.Fill(dt);

                return dt;
            }
            catch (Exception e) {throw new Exception("No se pudo realizar la busqueda " +e);}
            finally
            {
                CerrarConn();
                cmd.Dispose();
            }
        }

        public bool Mod_Materia(Materia materia)
        {
            string query = $"UPDATE Materias SET Nombre = '{materia.Nombre}', Turno = '{materia.Turno}' WHERE IdMateria = '{materia.IdMateria}'";
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
        public bool EliminarMateria(int id)
        {
            string query = $"DELETE FROM Materias WHERE IdMateria={id}";
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
