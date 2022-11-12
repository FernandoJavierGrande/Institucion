using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        // para la bbdd materia y turno tendrian que ser uq para que no pueda haber dos "lengua" en turno tarde

        private int idMateria;
        private string nombre;
        private string turno;
        public Materia()
        {

        }

        public Materia(int id, string nombre, string turno)
        {
            IdMateria = id;
            Nombre = nombre;
            Turno = turno;
        }

        public int IdMateria { get => idMateria; set => idMateria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Turno { get => turno; set => turno = value; }
    }
}
