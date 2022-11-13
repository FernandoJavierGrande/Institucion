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

        public bool crearAlumno(string nombre, string apellido, string dni, int edad, DateTime fechaIng)
        {
            alumnos = new AdministrarAlumnos();

            Alumno nuevoAlumno = new Alumno();

            nuevoAlumno.IdAlumno = 0;
            nuevoAlumno.Nombre = nombre;
            nuevoAlumno.Apellido = apellido;
            nuevoAlumno.Dni = dni;
            nuevoAlumno.Edad = edad;

            nuevoAlumno.FechaIngreso = fechaIng.Date;

            bool resp = alumnos.CrearAlumno(nuevoAlumno);

            return resp;
        }
        public bool EliminarAlumno(string dni)
        {
            alumnos = new AdministrarAlumnos();

            return alumnos.EliminarAlumno(dni); 
        }
        public bool ModificarAlumno(int id, string dni, string nombre, string apellido, int edad, DateTime fechaIngreso)
        {
            alumnos = new AdministrarAlumnos();

            Alumno AlumnoMod = new Alumno();

            AlumnoMod.IdAlumno = id;
            AlumnoMod.Dni = dni;
            AlumnoMod.Nombre = nombre;
            AlumnoMod.Apellido = apellido;
            AlumnoMod.Edad = edad;
            AlumnoMod.FechaIngreso = fechaIngreso;

            return alumnos.Mod_Alumno(AlumnoMod);
        }
        public DataTable buscarAlumno(string dni)
        {
            alumnos = new AdministrarAlumnos();
            DataTable dt = new DataTable();

            dt = alumnos.Listar_Alumnos(dni);

            return dt;
        }
    }
    
}
