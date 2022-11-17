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

        public bool crearAlumno(string nombre, string apellido, string dni, int edad, string fechaIng)
        {
            alumnos = new AdministrarAlumnos();

            Alumno nuevoAlumno = new Alumno();

            nuevoAlumno.IdAlumno = 0;
            nuevoAlumno.Nombre = nombre;
            nuevoAlumno.Apellido = apellido;
            nuevoAlumno.Dni = dni;
            nuevoAlumno.Edad = edad;

            nuevoAlumno.FechaIngreso = fechaIng;

            bool resp = alumnos.CrearAlumno(nuevoAlumno);

            return resp;
        }
        public bool EliminarAlumno(string dni)
        {
            alumnos = new AdministrarAlumnos();

            return alumnos.EliminarAlumno(dni); 
        }
        public bool ModificarAlumno(int id, string dni, string nombre, string apellido, int edad, string fechaIngreso)
        {
            alumnos = new AdministrarAlumnos();

            Alumno AlumnoMod = new Alumno();

            AlumnoMod.IdAlumno = id;
            AlumnoMod.Dni = dni;
            AlumnoMod.Nombre = nombre;
            AlumnoMod.Apellido = apellido;
            AlumnoMod.Edad = edad;
            AlumnoMod.FechaIngreso = fechaIngreso;

            return alumnos.Mod_Alumno(AlumnoMod );
        }
        public Alumno buscarAlumno(string dni)
        {
            alumnos = new AdministrarAlumnos();
            DataTable dt = new DataTable();
            Alumno alumno = new Alumno();

            dt = alumnos.Listar_Alumnos(dni);
            if (dt.Rows.Count<1)
            {
                return null;
            }
            else
            {
                
                alumno.Dni = dt.Rows[0][1].ToString();
                alumno.IdAlumno = int.Parse(dt.Rows[0][0].ToString());
                alumno.Nombre = dt.Rows[0][2].ToString();
                alumno.Apellido = dt.Rows[0][3].ToString();
                alumno.Edad = int.Parse(dt.Rows[0][4].ToString());
                alumno.FechaIngreso =dt.Rows[0][5].ToString();
            }
            

            return alumno;
        }
    }
    
}
