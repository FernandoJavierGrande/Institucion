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

        DataTable dt = new DataTable();
        Materia materiaEnMemoria = new Materia();

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

            Btn_EditarMateria.Enabled = false;
            Btn_EliminarMateria.Enabled = false;
        }

        


        private bool validarTxt(TextBox txt, string tipo= "text")
        {
            if (txt.Text == string.Empty)
            {
                error.SetError(txt, $"Campo obligatorio");
                return false;
            }
            else if (txt.Text != string.Empty && tipo== "text") 
            {
                //si esta vacio y es tipo text va true xq es la unica validacion nec
                return true;
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
            //completar
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

        private void Btn_GuardarMateria_Click(object sender, EventArgs e)
        {
            bool validNombre = validarTxt(Txt_NombreMateria);
            string mensaje;

            if (ComboBox_TurnoMateria.SelectedIndex == -1)
            {
                error.SetError(ComboBox_TurnoMateria, "seleccione un turno");
            }


            if (!validNombre && ComboBox_TurnoMateria.SelectedIndex != -1)
            {
                string item = ComboBox_TurnoMateria.SelectedItem.ToString();
                
                materias = new MateriasNegocio();

                bool guardado = materias.crearMateria(Txt_NombreMateria.Text, item);
                
                if (guardado)
                {
                    mensaje = "Se guardó correctamente";
                    Limpiar();
                }
                else
                {
                    mensaje = "No se guardó";
                }
                MessageBox.Show(mensaje);
            }
            
            
        }

        private void Btn_EliminarMateria_Click(object sender, EventArgs e)
        {
            string mensaje = $"¿Desea Eliminar la materia Id:{materiaEnMemoria.IdMateria} \n{materiaEnMemoria.Nombre}";

            DialogResult result = MessageBox.Show(mensaje,"Eliminar materia", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                materias = new MateriasNegocio();

                bool resp = materias.EliminarMateria(materiaEnMemoria.IdMateria);

                if (!resp)
                {
                    MessageBox.Show("No se pudo eliminar");
                }
                else
                {
                    Limpiar();
                }
            }      

        }

        private void Btn_BuscarMateria_Click(object sender, EventArgs e)
        {
            error.Clear();

            bool validado = validarTxt(Txt_NombreMateria);
            Console.WriteLine(validado);    
            materias = new MateriasNegocio();

            dt = new DataTable();

            if (validado)
            {
                dt = materias.buscarMateria(Txt_NombreMateria.Text);
                if (dt.Rows.Count>0)
                {
                    materiaEnMemoria.IdMateria = int.Parse(dt.Rows[0][0].ToString());
                    materiaEnMemoria.Nombre = dt.Rows[0][1].ToString();
                    materiaEnMemoria.Turno = dt.Rows[0][2].ToString();

                    Txt_NombreMateria.Text = materiaEnMemoria.Nombre;
                    ComboBox_TurnoMateria.Text = materiaEnMemoria.Turno;

                    Btn_EliminarMateria.Enabled = true;
                    Btn_EditarMateria.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No encontrado, intente nuevamente");
                } 
            }

            
        }
    }
}
