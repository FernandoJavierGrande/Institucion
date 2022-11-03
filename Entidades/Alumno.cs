using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private int dni;
        private string nombre;
        private string apellido;
        private int edad;

        public Alumno()
        {

        }

        public Alumno(int dni, string nombre, string apellido, int edad, DateTime fechaIngreso)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            FechaIngreso = fechaIngreso;
        }

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public DateTime FechaIngreso { get; set; }

    }
}
