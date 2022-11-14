using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cursos
    {
        private int idAlumno;
        private int id_Materia;
        private bool aprobada;
        public Cursos()
        {

        }

        public Cursos(int idAlumno, int id_Materia, bool aprobada)
        {
            IdAlumno = idAlumno;
            Id_Materia = id_Materia;
            Aprobada = aprobada;
        }

        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public int Id_Materia { get => id_Materia; set => id_Materia = value; }
        public bool Aprobada { get => aprobada; set => aprobada = value; }
    }
}
