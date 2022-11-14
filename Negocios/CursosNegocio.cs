using CapaDeDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class CursosNegocio
    {
        AdministrarCursos cursos;

        public DataTable MateriasPorAlumno(int idAlumno)
        {
            cursos = new AdministrarCursos();
            DataTable dt = new DataTable();

            dt = cursos.MateriasPorAlumno(idAlumno);
            return dt;
        }

        public DataTable AlumnosPorMateria(int idMateria)
        {
            cursos = new AdministrarCursos();
            DataTable dt = new DataTable();

            dt = cursos.AlumnosPorMateria(idMateria);
            return dt;
        }

        public bool eliminarCursada(int idAlumno, int idMateria)
        {
            cursos = new AdministrarCursos();
            
            return cursos.EliminarCursada(idAlumno,idMateria);
        }

        public bool CrearCursada(int idAlumno, int idMateria, bool aprobado)
        {
            
            
            cursos = new AdministrarCursos();

            Cursos nuevaCursada = new Cursos();

            nuevaCursada.Id_Materia = idMateria;
            nuevaCursada.IdAlumno = idAlumno;
            nuevaCursada.Aprobada  = aprobado;

            bool resp = cursos.CrearCursada(nuevaCursada);

            return resp;
        }

    }
}
