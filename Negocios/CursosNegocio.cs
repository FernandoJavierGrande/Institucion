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
        CursosNegocio cursos;

        public DataTable MateriasPorAlumno(int idAlumno)
        {
            cursos = new CursosNegocio();
            DataTable dt = new DataTable();

            dt = cursos.MateriasPorAlumno(idAlumno);
            return dt;
        }

        public DataTable AlumnosPorMateria(int idMateria)
        {
            cursos = new CursosNegocio();
            DataTable dt = new DataTable();

            dt = cursos.AlumnosPorMateria(idMateria);
            return dt;
        }

        public bool eliminarCursada(int idAlumno, int idMateria)
        {
            cursos = new CursosNegocio();
            
            return cursos.eliminarCursada(idAlumno,idMateria);
        }

    }
}
