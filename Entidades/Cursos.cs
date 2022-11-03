using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cursos
    {
        private int dni;
        private int id_Materia;
        private bool aprobada;
        public Cursos()
        {

        }

        public Cursos(int dni, int id_Materia, bool aprobada)
        {
            Dni = dni;
            Id_Materia = id_Materia;
            Aprobada = aprobada;
        }

        public int Dni { get => dni; set => dni = value; }
        public int Id_Materia { get => id_Materia; set => id_Materia = value; }
        public bool Aprobada { get => aprobada; set => aprobada = value; }
    }
}
