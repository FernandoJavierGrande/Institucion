using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;


namespace Institucion
{
    public partial class FormularioInstitucion : Form
    {
        MateriasNegocio materias = new MateriasNegocio();
        AlumnosNegocio alumnos = new AlumnosNegocio();
        public FormularioInstitucion()
        {
            InitializeComponent();
        }

        private void FormularioInstitucion_Load(object sender, EventArgs e)
        { 
            DataTable ListaMateria = new DataTable();

            ListaMateria = materias.LlenarComboMaterias();

            ComboBox_SeleccionarMateria.DataSource = ListaMateria;
            ComboBox_SeleccionarMateria.DisplayMember = "Nombre";
            ComboBox_SeleccionarMateria.ValueMember = "IdMateria";

            ComboBox_SeleccionarMateria1.DataSource = ListaMateria;
            ComboBox_SeleccionarMateria1.DisplayMember = "Nombre";
            ComboBox_SeleccionarMateria1.ValueMember = "IdMateria";
        }

        


        private bool validarTxt(TextBox txt, string tipo= "void")
        {
            if (txt.Text == string.Empty)
            {
                error.SetError(txt, $"Campo obligatorio");
                return false;
            }
            
            if (tipo.Equals("number"))
            {
                int salida;
                if (Int32.TryParse(txt.Text, out salida ))
                {
                    return true;
                }
                else
                {
                    error.SetError(txt, "Debe ser un numero");
                    return false;
                }
                
            }else if (tipo.Equals("dni"))
            {
                for (int i = 0; i < txt.Text.Length; i++)
                {
                    char letra = txt.Text[i];
                    if (char.IsDigit(letra) == false)
                    {
                        error.SetError(txt, "Solo numeros. No puede contener puntos o guiones");

                        return false;
                    }                }
                return true; 
            }
            else
            {
                return false;
            }
        }
        private void Limpiar()
        {

        }

        private void Btn_GuardarAlumno_Click(object sender, EventArgs e)
        {
            error.Clear();

            bool nombreVal, apellidoVal, dniVal, edadVal;
            nombreVal = validarTxt(Txt_NombreAlumno);
            apellidoVal = validarTxt(Txt_ApellidoAlumno);

            dniVal = validarTxt(Txt_DniAlumno,"dni");
            edadVal = validarTxt(Txt_EdadAlumno,"number");

            string nombre = Txt_NombreAlumno.Text;
            string apellido = Txt_ApellidoAlumno.Text;
            string dni = Txt_DniAlumno.Text;
            int edad = int.Parse(Txt_EdadAlumno.Text);
            DateTime fecha = Txt_FechaInicio.Value;

            if (!nombreVal || !apellidoVal || !dniVal || !edadVal)
            {
                string mensaje = "Se guardo correctamente";
                bool guardado = alumnos.crearAlumno(nombre,apellido,dni,edad,fecha);

                if (!guardado)
                {
                    mensaje = "no se pudo guardar\n Intente nuevamente";
                }
                MessageBox.Show(mensaje);
            }
        }
    }
}
