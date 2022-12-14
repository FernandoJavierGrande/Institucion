using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace Institucion
{
    public partial class FormularioInstitucion : Form
    {
        MateriasNegocio materias = new MateriasNegocio();
        AlumnosNegocio alumnos = new AlumnosNegocio();
        CursosNegocio cursos = new CursosNegocio();

        DataTable dt = new DataTable();
        Materia materiaEnMemoria = new Materia();
        Alumno alumnoEnMemoria = new Alumno();
        List<Materia> ListaMateria = new List<Materia>();
        public FormularioInstitucion()
        {
            InitializeComponent();
        }

        private void FormularioInstitucion_Load(object sender, EventArgs e)
        { 
            CargarCombos();

        }

        #region alumnos

        private void Btn_GuardarAlumno_Click(object sender, EventArgs e)
        {
            error.Clear();

            bool res = validarAlumno();
            if (res)
            {
                string nombre = Txt_NombreAlumno.Text;
                string apellido = Txt_ApellidoAlumno.Text;
                string dni = Txt_DniAlumno.Text;
                int edad = int.Parse(Txt_EdadAlumno.Text);

                DateTime fecha = Txt_FechaInicio.Value.Date;

                string fechas = fecha.ToString("MM-dd-yyyy");

                Console.WriteLine($"{fecha}");
                string mensaje = "Se guardo correctamente";
                bool guardado = alumnos.crearAlumno(nombre, apellido, dni, edad, fechas);

                if (!guardado)
                {
                    mensaje = "no se pudo guardar\n Intente nuevamente";
                }
                MessageBox.Show(mensaje);
            }
        }

        private void Btn_EliminarAlumno_Click(object sender, EventArgs e)
        {
            string mensaje = $"¿Desea Eliminar el alumno DNI:{alumnoEnMemoria.Dni} \n{alumnoEnMemoria.Apellido} {alumnoEnMemoria.Nombre}?";

            DialogResult result = MessageBox.Show(mensaje, "Eliminar Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                materias = new MateriasNegocio();

                bool resp = alumnos.EliminarAlumno(alumnoEnMemoria.Dni);

                if (!resp)
                {
                    MessageBox.Show("No se pudo eliminar");
                }
                else
                {
                    Limpiar();
                    EnableBtn("alumno", true);
                }
            }
        }

        private void Btn_BuscarAlumno_Click(object sender, EventArgs e)
        {
            error.Clear();

            alumnos = new AlumnosNegocio();
            bool valNombre = validarTxt(Txt_DniAlumno,"dni");

            alumnoEnMemoria = new Alumno();

            if (valNombre)
            {
                alumnoEnMemoria= alumnos.buscarAlumno(Txt_DniAlumno.Text);

                if (alumnoEnMemoria != null)
                {
                    Txt_NombreAlumno.Text = alumnoEnMemoria.Nombre;
                    Txt_ApellidoAlumno.Text = alumnoEnMemoria.Apellido;
                    Txt_DniAlumno.Text = alumnoEnMemoria.Dni;
                    Txt_EdadAlumno.Text = alumnoEnMemoria.Edad.ToString();
                    Txt_FechaInicio.Value = Convert.ToDateTime(alumnoEnMemoria.FechaIngreso);

                    EnableBtn("alumno", true);
                }
                else
                {
                    MessageBox.Show("No encontrado");
                }
                
            }
        }

        private void Btn_EditarAlumno_Click(object sender, EventArgs e)
        {
            bool res = validarAlumno();
            alumnos = new AlumnosNegocio();

            if (res)
            {
                int id = alumnoEnMemoria.IdAlumno;
                string nombre = Txt_NombreAlumno.Text;
                string apellido = Txt_ApellidoAlumno.Text;
                string dni = Txt_DniAlumno.Text;
                int edad = int.Parse(Txt_EdadAlumno.Text);

                DateTime fecha = Txt_FechaInicio.Value.Date;

                string fechas = fecha.ToString("MM-dd-yyyy");
                bool guardado = alumnos.ModificarAlumno(id, dni, nombre, apellido, edad, fechas);

                if (!guardado)
                {

                    MessageBox.Show("No se pudo modificar");
                }
                else
                {
                    Limpiar();
                    CargarCombos();
                }
            }
        }

        #endregion

        #region materias

        private void Btn_GuardarMateria_Click(object sender, EventArgs e)
        {
            bool validNombre = validarTxt(Txt_NombreMateria);
            string mensaje;

            if (ComboBox_TurnoMateria.SelectedIndex == -1)
            {
                error.SetError(ComboBox_TurnoMateria, "seleccione un turno");
            }


            if (validNombre && ComboBox_TurnoMateria.SelectedIndex != -1)
            {
                string item = ComboBox_TurnoMateria.SelectedItem.ToString();

                materias = new MateriasNegocio();

                bool guardado = materias.crearMateria(Txt_NombreMateria.Text, item);

                if (guardado)
                {
                    mensaje = "Se guardó correctamente";
                    Limpiar();
                    CargarCombos();
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

            DialogResult result = MessageBox.Show(mensaje, "Eliminar materia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
                    CargarCombos(); 
                }
            }

        }


        private void Btn_BuscarMateria_Click(object sender, EventArgs e)
        {
            ComboBox_ListSubject.Visible = true;
        }

        private void ComboBox_ListSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ComboBox_ListSubject.SelectedIndex != -1)
            {
                materiaEnMemoria = new Materia();

                materiaEnMemoria.IdMateria = int.Parse(ComboBox_ListSubject.SelectedValue.ToString());

                materiaEnMemoria.Nombre = ((Materia)ComboBox_ListSubject.SelectedItem).Nombre;

                materiaEnMemoria.Turno = ((Materia)ComboBox_ListSubject.SelectedItem).Turno;

                Txt_NombreMateria.Text = materiaEnMemoria.Nombre.ToString().Split('\u002D')[0].Trim();

                ComboBox_TurnoMateria.SelectedItem = materiaEnMemoria.Turno;

                EnableBtn("materia", true);
            }
        }

        private void Btn_EditarMateria_Click(object sender, EventArgs e)
        {
            bool resp = validarTxt(Txt_NombreMateria);
            if (ComboBox_TurnoMateria.SelectedIndex == -1)
            {
                error.SetError(ComboBox_TurnoMateria, "Seleccione un turno");
            }


            if (resp)
            {

                materias = new MateriasNegocio();

                materiaEnMemoria.Turno = ComboBox_TurnoMateria.SelectedItem.ToString();
                materiaEnMemoria.Nombre = Txt_NombreMateria.Text;

                bool guardado = materias.ModificarMateria(materiaEnMemoria.IdMateria, materiaEnMemoria.Nombre, materiaEnMemoria.Turno);
                if (!guardado)
                {
                    MessageBox.Show("No se pudo modificar");
                }
                else
                {
                    Limpiar();
                    CargarCombos();
                }
            }
        }

        #endregion

        #region alumnosYmaterias
        private void Btn_AgregarCursada_Click(object sender, EventArgs e)
        {
            bool val = validarTxt(TxtAlumnoQueCursaDni, "dni");

            int idMat = int.Parse(ComboBox_SeleccionarMateria.SelectedValue.ToString());


            if (val && ComboBox_SeleccionarMateria.SelectedIndex != -1)
            {
                bool res = cursos.CrearCursada(TxtAlumnoQueCursaDni.Text, idMat, check_aprobado.Checked);
                if (!res)
                {
                    MessageBox.Show("Ocurrio un error");
                }
                else
                {
                    MessageBox.Show("Agregado correctamente");
                    Limpiar();
                }
            }
        }
        private void Btn_CursosMateria_Click(object sender, EventArgs e)
        {
            ListarAlumDGV();
        }

        private void Btn_CursosAlumno_Click(object sender, EventArgs e)
        {
            bool val = validarTxt(Txt_CursoAlumno, "dni");

            if (val)
            {
                DataTable dt = new DataTable();
                alumnos = new AlumnosNegocio();
                alumnoEnMemoria = new Alumno();

                var RESP = alumnos.buscarAlumno(Txt_CursoAlumno.Text);
                if (RESP != null)
                {
                    alumnoEnMemoria = alumnos.buscarAlumno(Txt_CursoAlumno.Text);

                    dt = cursos.MateriasPorAlumno(alumnoEnMemoria.IdAlumno);
                    if (dt.Rows.Count < 1)
                    {
                        MessageBox.Show("El alumno no esta inscripto en ninguna materia");
                        Limpiar();
                    }
                    else
                    {
                        Limpiar();
                        Dgv_Listado.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show($"El alumno con el dni '{Txt_CursoAlumno.Text}' no existe");
                }
            }
            else
            {
                error.SetError(Txt_CursoAlumno, "Deben ser numeros enteros");
            }
        }

        private void Dgv_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (true)
            {
                Cursos curso = new Cursos();

                curso.IdAlumno = int.Parse(Dgv_Listado.CurrentRow.Cells[0].Value.ToString());
                curso.Id_Materia = int.Parse(ComboBox_SeleccionarMateria1.SelectedValue.ToString());
                curso.Aprobada = bool.Parse(Dgv_Listado.CurrentRow.Cells[4].Value.ToString());

                curso.Aprobada = !curso.Aprobada;
                Console.WriteLine($"{curso.Aprobada}");

                bool resp = cursos.aprobado(curso);
                if (!resp)
                {
                    MessageBox.Show("No se pudo Actualizar");
                }
                else
                {
                    ListarAlumDGV();
                }
            }
        }

        #endregion

        #region metodos
        private bool validarTxt(TextBox txt, string tipo = "text")
        {
            if (txt.Text == string.Empty)
            {
                error.SetError(txt, $"Campo obligatorio");
                return false;
            }
            else if (txt.Text != string.Empty && tipo == "text")
            {
                //si esta vacio y es tipo text va true xq es la unica validacion nec
                return true;
            }



            if (tipo.Equals("number"))
            {
                int salida;
                if (Int32.TryParse(txt.Text, out salida))
                {
                    return true;
                }
                else
                {
                    error.SetError(txt, "Debe ser un numero");
                    return false;
                }

            }
            else if (tipo.Equals("dni"))
            {
                for (int i = 0; i < txt.Text.Length; i++)
                {
                    char letra = txt.Text[i];
                    if (char.IsDigit(letra) == false)
                    {
                        error.SetError(txt, "Solo numeros. No puede contener puntos o guiones");

                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CargarCombos()
        {
            ListaMateria = materias.LlenarComboMaterias();

            ComboBox_SeleccionarMateria.DataSource = ListaMateria;
            ComboBox_SeleccionarMateria.DisplayMember = "Nombre";
            ComboBox_SeleccionarMateria.ValueMember = "IdMateria";

            ComboBox_SeleccionarMateria1.DataSource = ListaMateria;
            ComboBox_SeleccionarMateria1.DisplayMember = "Nombre";
            ComboBox_SeleccionarMateria1.ValueMember = "IdMateria";

            ComboBox_ListSubject.DataSource = ListaMateria;
            ComboBox_ListSubject.DisplayMember = "Nombre";
            ComboBox_ListSubject.ValueMember = "IdMateria";
            ComboBox_ListSubject.Visible = false;

            

            EnableBtn("materia", false);
            EnableBtn("alumno", false);
        }
        private void Limpiar()
        {
            Txt_DniAlumno.Text = "";
            Txt_ApellidoAlumno.Text = "";
            Txt_NombreAlumno.Text = "";
            Txt_EdadAlumno.Text = "";
            Txt_FechaInicio.Text = "";
            Txt_NombreMateria.Text = "";
            TxtAlumnoQueCursaDni.Text = "";
            ComboBox_ListSubject.SelectedIndex = 0;
            ComboBox_TurnoMateria.SelectedIndex = -1;
            ComboBox_SeleccionarMateria.SelectedIndex = 0;
            ComboBox_SeleccionarMateria1.SelectedIndex = 0;
            Txt_CursoAlumno.Text = "";

            materiaEnMemoria = new Materia();
            alumnoEnMemoria = new Alumno();

            EnableBtn("alumno", false);
            EnableBtn("materia", false);
        }
        private void Btn_LimpiarTodo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void EnableBtn(string arg, bool disable)
        {
            if (arg.Equals("alumno"))
            {
                Btn_EditarAlumno.Enabled = disable;
                Btn_EliminarAlumno.Enabled = disable;
                Btn_GuardarAlumno.Enabled = !disable;
            }
            else if (arg.Equals("materia"))
            {
                Btn_EditarMateria.Enabled = disable;
                Btn_EliminarMateria.Enabled = disable;
                Btn_GuardarMateria.Enabled = !disable;
            }
        }
        private bool validarAlumno()
        {
            bool nombreVal, apellidoVal, dniVal, edadVal;
            nombreVal = validarTxt(Txt_NombreAlumno);
            apellidoVal = validarTxt(Txt_ApellidoAlumno);

            dniVal = validarTxt(Txt_DniAlumno, "dni");
            edadVal = validarTxt(Txt_EdadAlumno, "number");

            if (!nombreVal || !apellidoVal || !dniVal || !edadVal)
            {
                return false;
            }
            return true;
        }

        private void ListarAlumDGV()
        {
            if (ComboBox_SeleccionarMateria1.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                int idM = int.Parse(ComboBox_SeleccionarMateria1.SelectedValue.ToString());

                
                dt = cursos.AlumnosPorMateria(idM);
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("No hay alumnos inscriptos");
                    Limpiar();
                }
                else
                {
                    //Limpiar();
                    Dgv_Listado.DataSource = dt;
                    materiaEnMemoria.IdMateria = idM;
                }
            }
            else
            {
                error.SetError(ComboBox_SeleccionarMateria1, "Seleccione una materia");
            }
        }

        #endregion

        
    }
}
