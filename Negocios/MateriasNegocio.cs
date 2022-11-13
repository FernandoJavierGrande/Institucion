using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocios
{
    public class MateriasNegocio
    {
        AdministrarMaterias materias = new AdministrarMaterias();


        public DataTable MateriasListar()
        {
            return materias.Listar_Materias();
        }

        public DataTable LlenarComboMaterias() // duelve un dt adaptado al cmb
        {
            List<string> list = new List<string>();

            DataTable dt = new DataTable();

            dt = materias.Listar_Materias();

           
            int cantidad = dt.Rows.Count;

            for (int i = 0; i < cantidad; i++)
            {
                dt.Rows[i]["Nombre"] = $"{dt.Rows[i]["Nombre"]} - {dt.Rows[i]["Turno"]}";

            }

            return dt;
        }
        public bool crearMateria(string nombre, string turno)
        {
            materias = new AdministrarMaterias();

            Materia nuevaMateria = new Materia();

            nuevaMateria.IdMateria = 0;
            nuevaMateria.Nombre = nombre;
            nuevaMateria.Turno= turno;

            bool resp = materias.AgregarMateria(nuevaMateria);

            return resp;
        }
        public bool EliminarMateria(int idMateria)
        {
            materias = new AdministrarMaterias();

            return materias.EliminarMateria(idMateria);
        }
        public bool ModificarMateria(int id,string nombre, string turno)
        {
            materias = new AdministrarMaterias();

            Materia MateriaMod = new Materia();

            MateriaMod.IdMateria = id;
            MateriaMod.Nombre = nombre;
            MateriaMod.Turno = turno;

            return materias.Mod_Materia(MateriaMod);
        }

        public DataTable buscarMateria(string nombreMateria)
        {
            materias = new AdministrarMaterias();
            DataTable dt = new DataTable();

            dt = materias.Listar_Materias(nombreMateria);

            return dt;
        }
    }
}
