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
            string query = $"INSERT INTO Materias VALUES ('{materia.Id}','{materia.Nombre}','{materia.Turno}')";
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
        public DataSet Listar_Materias()
        {
            string query = $"SELECT * FROM Materias ORDER BY Nombre ASC";

            SqlCommand cmd = new SqlCommand(query, conexion);

            DataSet dataSet = new DataSet();

            SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd);

            try
            {
                AbrirConn();
                cmd.ExecuteNonQuery();
                DataAdapter.SelectCommand = cmd;
                DataAdapter.Fill(dataSet);

                return dataSet;
            }
            catch (Exception) {throw new Exception("No se pudo realizar la busqueda");}
            finally
            {
                CerrarConn();
                cmd.Dispose();
            }
        }
        //confirmar si modificamos las materias
    }
}
