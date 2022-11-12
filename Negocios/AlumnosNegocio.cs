using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using Entidades;

namespace Negocios
{
    public class AlumnosNegocio
    {
        AdministrarAlumnos alumnos = new AdministrarAlumnos();

        public DataTable alumnosListar(string dni)
        {
            DataTable dt = new DataTable();
            dt = alumnos.Listar_Alumnos(dni);
            return dt;
        } 

    }
}
