using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //alumnoMod.IdAlumno = int.Parse(resp.Tables[0].Rows[0]["IdAlumno"].ToString()
    }
}
