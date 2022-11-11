using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private int idAlumno;
        private string dni;
        private string nombre;
        private string apellido;
        private int edad;


        public Alumno()
        {

        }

        public Alumno(int idAlumno, string dni, string nombre, string apellido, int edad, DateTime fechaIngreso)
        {   
            IdAlumno = idAlumno;
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            FechaIngreso = fechaIngreso;
        }
        
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public DateTime FechaIngreso { get; set; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
    }
}
