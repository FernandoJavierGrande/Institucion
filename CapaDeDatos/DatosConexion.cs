using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class DatosConexion
    {
        protected SqlConnection conexion;
        protected string stringConn = "Data Source = DESKTOP-4UUDNRF\\SQLEXPRESS; Initial Catalog = InstitucionAlumno ; Integrated Security = true";
        /*"Server = DESKTOP-4UUDNRF; Database=InstitucionAlumno; Trusted_Connection=true;";*/ 
        public DatosConexion()
        {
            conexion = new SqlConnection(stringConn);
        }


        #region Metodos
        
        public void AbrirConn()
        {

            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed) conexion.Open();
            }
            catch (Exception e) {throw new Exception("Error al abrir la conexion" + e);}
        }


        public void CerrarConn()
        {
            try
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();

            }
            catch (Exception) {throw new Exception("Error al cerrar la conexion");}
        }


        #endregion
    }
}
