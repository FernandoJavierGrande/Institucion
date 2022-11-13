namespace Institucion
{
    partial class FormularioInstitucion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Pag = new System.Windows.Forms.TabControl();
            this.Pagina_Inscribir = new System.Windows.Forms.TabPage();
            this.Btn_AgregarCursada = new System.Windows.Forms.Button();
            this.Rb_NoAprobo = new System.Windows.Forms.RadioButton();
            this.Rb_SiAprobo = new System.Windows.Forms.RadioButton();
            this.ComboBox_SeleccionarTurno = new System.Windows.Forms.ComboBox();
            this.ComboBox_SeleccionarMateria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pagina_Alumno = new System.Windows.Forms.TabPage();
            this.Btn_BuscarAlumno = new System.Windows.Forms.Button();
            this.Btn_EliminarAlumno = new System.Windows.Forms.Button();
            this.Btn_EditarAlumno = new System.Windows.Forms.Button();
            this.Btn_GuardarAlumno = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.Txt_EdadAlumno = new System.Windows.Forms.TextBox();
            this.Txt_DniAlumno = new System.Windows.Forms.TextBox();
            this.Txt_ApellidoAlumno = new System.Windows.Forms.TextBox();
            this.Txt_NombreAlumno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PaginaMateria = new System.Windows.Forms.TabPage();
            this.Btn_BuscarMateria = new System.Windows.Forms.Button();
            this.Btn_EliminarMateria = new System.Windows.Forms.Button();
            this.Btn_EditarMateria = new System.Windows.Forms.Button();
            this.Btn_GuardarMateria = new System.Windows.Forms.Button();
            this.ComboBox_TurnoMateria = new System.Windows.Forms.ComboBox();
            this.Txt_NombreMateria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Dgv_Listado = new System.Windows.Forms.DataGridView();
            this.Btn_CursosMateria = new System.Windows.Forms.Button();
            this.Btn_CursosAlumno = new System.Windows.Forms.Button();
            this.ComboBox_SeleccionarMateria1 = new System.Windows.Forms.ComboBox();
            this.Txt_CursoAlumno = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Pag.SuspendLayout();
            this.Pagina_Inscribir.SuspendLayout();
            this.Pagina_Alumno.SuspendLayout();
            this.PaginaMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // Pag
            // 
            this.Pag.Controls.Add(this.Pagina_Inscribir);
            this.Pag.Controls.Add(this.Pagina_Alumno);
            this.Pag.Controls.Add(this.PaginaMateria);
            this.Pag.Location = new System.Drawing.Point(35, 50);
            this.Pag.Margin = new System.Windows.Forms.Padding(4);
            this.Pag.Name = "Pag";
            this.Pag.SelectedIndex = 0;
            this.Pag.Size = new System.Drawing.Size(447, 357);
            this.Pag.TabIndex = 0;
            // 
            // Pagina_Inscribir
            // 
            this.Pagina_Inscribir.Controls.Add(this.Btn_AgregarCursada);
            this.Pagina_Inscribir.Controls.Add(this.Rb_NoAprobo);
            this.Pagina_Inscribir.Controls.Add(this.Rb_SiAprobo);
            this.Pagina_Inscribir.Controls.Add(this.ComboBox_SeleccionarTurno);
            this.Pagina_Inscribir.Controls.Add(this.ComboBox_SeleccionarMateria);
            this.Pagina_Inscribir.Controls.Add(this.label3);
            this.Pagina_Inscribir.Controls.Add(this.Txt);
            this.Pagina_Inscribir.Controls.Add(this.label1);
            this.Pagina_Inscribir.Location = new System.Drawing.Point(4, 25);
            this.Pagina_Inscribir.Margin = new System.Windows.Forms.Padding(4);
            this.Pagina_Inscribir.Name = "Pagina_Inscribir";
            this.Pagina_Inscribir.Padding = new System.Windows.Forms.Padding(4);
            this.Pagina_Inscribir.Size = new System.Drawing.Size(439, 328);
            this.Pagina_Inscribir.TabIndex = 0;
            this.Pagina_Inscribir.Text = "Inscribir";
            this.Pagina_Inscribir.UseVisualStyleBackColor = true;
            // 
            // Btn_AgregarCursada
            // 
            this.Btn_AgregarCursada.Location = new System.Drawing.Point(33, 207);
            this.Btn_AgregarCursada.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AgregarCursada.Name = "Btn_AgregarCursada";
            this.Btn_AgregarCursada.Size = new System.Drawing.Size(100, 28);
            this.Btn_AgregarCursada.TabIndex = 12;
            this.Btn_AgregarCursada.Text = "Agregar Cursada";
            this.Btn_AgregarCursada.UseVisualStyleBackColor = true;
            // 
            // Rb_NoAprobo
            // 
            this.Rb_NoAprobo.AutoSize = true;
            this.Rb_NoAprobo.Location = new System.Drawing.Point(172, 166);
            this.Rb_NoAprobo.Margin = new System.Windows.Forms.Padding(4);
            this.Rb_NoAprobo.Name = "Rb_NoAprobo";
            this.Rb_NoAprobo.Size = new System.Drawing.Size(46, 20);
            this.Rb_NoAprobo.TabIndex = 11;
            this.Rb_NoAprobo.TabStop = true;
            this.Rb_NoAprobo.Text = "No";
            this.Rb_NoAprobo.UseVisualStyleBackColor = true;
            // 
            // Rb_SiAprobo
            // 
            this.Rb_SiAprobo.AutoSize = true;
            this.Rb_SiAprobo.Location = new System.Drawing.Point(172, 138);
            this.Rb_SiAprobo.Margin = new System.Windows.Forms.Padding(4);
            this.Rb_SiAprobo.Name = "Rb_SiAprobo";
            this.Rb_SiAprobo.Size = new System.Drawing.Size(40, 20);
            this.Rb_SiAprobo.TabIndex = 10;
            this.Rb_SiAprobo.TabStop = true;
            this.Rb_SiAprobo.Text = "Si";
            this.Rb_SiAprobo.UseVisualStyleBackColor = true;
            // 
            // ComboBox_SeleccionarTurno
            // 
            this.ComboBox_SeleccionarTurno.FormattingEnabled = true;
            this.ComboBox_SeleccionarTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.ComboBox_SeleccionarTurno.Location = new System.Drawing.Point(172, 81);
            this.ComboBox_SeleccionarTurno.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_SeleccionarTurno.Name = "ComboBox_SeleccionarTurno";
            this.ComboBox_SeleccionarTurno.Size = new System.Drawing.Size(160, 24);
            this.ComboBox_SeleccionarTurno.TabIndex = 9;
            // 
            // ComboBox_SeleccionarMateria
            // 
            this.ComboBox_SeleccionarMateria.FormattingEnabled = true;
            this.ComboBox_SeleccionarMateria.Location = new System.Drawing.Point(172, 42);
            this.ComboBox_SeleccionarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_SeleccionarMateria.Name = "ComboBox_SeleccionarMateria";
            this.ComboBox_SeleccionarMateria.Size = new System.Drawing.Size(160, 24);
            this.ComboBox_SeleccionarMateria.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aprobado/a";
            // 
            // Txt
            // 
            this.Txt.AutoSize = true;
            this.Txt.Location = new System.Drawing.Point(29, 81);
            this.Txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(117, 16);
            this.Txt.TabIndex = 5;
            this.Txt.Text = "Seleccionar Turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccionar Materia";
            // 
            // Pagina_Alumno
            // 
            this.Pagina_Alumno.Controls.Add(this.Btn_BuscarAlumno);
            this.Pagina_Alumno.Controls.Add(this.Btn_EliminarAlumno);
            this.Pagina_Alumno.Controls.Add(this.Btn_EditarAlumno);
            this.Pagina_Alumno.Controls.Add(this.Btn_GuardarAlumno);
            this.Pagina_Alumno.Controls.Add(this.label9);
            this.Pagina_Alumno.Controls.Add(this.Txt_FechaInicio);
            this.Pagina_Alumno.Controls.Add(this.Txt_EdadAlumno);
            this.Pagina_Alumno.Controls.Add(this.Txt_DniAlumno);
            this.Pagina_Alumno.Controls.Add(this.Txt_ApellidoAlumno);
            this.Pagina_Alumno.Controls.Add(this.Txt_NombreAlumno);
            this.Pagina_Alumno.Controls.Add(this.label8);
            this.Pagina_Alumno.Controls.Add(this.label7);
            this.Pagina_Alumno.Controls.Add(this.label6);
            this.Pagina_Alumno.Controls.Add(this.label5);
            this.Pagina_Alumno.Location = new System.Drawing.Point(4, 25);
            this.Pagina_Alumno.Margin = new System.Windows.Forms.Padding(4);
            this.Pagina_Alumno.Name = "Pagina_Alumno";
            this.Pagina_Alumno.Padding = new System.Windows.Forms.Padding(4);
            this.Pagina_Alumno.Size = new System.Drawing.Size(439, 328);
            this.Pagina_Alumno.TabIndex = 1;
            this.Pagina_Alumno.Text = "Nuevo Alumno";
            this.Pagina_Alumno.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarAlumno
            // 
            this.Btn_BuscarAlumno.Location = new System.Drawing.Point(159, 272);
            this.Btn_BuscarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BuscarAlumno.Name = "Btn_BuscarAlumno";
            this.Btn_BuscarAlumno.Size = new System.Drawing.Size(100, 28);
            this.Btn_BuscarAlumno.TabIndex = 13;
            this.Btn_BuscarAlumno.Text = "Buscar";
            this.Btn_BuscarAlumno.UseVisualStyleBackColor = true;
            // 
            // Btn_EliminarAlumno
            // 
            this.Btn_EliminarAlumno.Location = new System.Drawing.Point(159, 236);
            this.Btn_EliminarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_EliminarAlumno.Name = "Btn_EliminarAlumno";
            this.Btn_EliminarAlumno.Size = new System.Drawing.Size(100, 28);
            this.Btn_EliminarAlumno.TabIndex = 12;
            this.Btn_EliminarAlumno.Text = "Eliminar";
            this.Btn_EliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // Btn_EditarAlumno
            // 
            this.Btn_EditarAlumno.Location = new System.Drawing.Point(45, 272);
            this.Btn_EditarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_EditarAlumno.Name = "Btn_EditarAlumno";
            this.Btn_EditarAlumno.Size = new System.Drawing.Size(100, 28);
            this.Btn_EditarAlumno.TabIndex = 11;
            this.Btn_EditarAlumno.Text = "Editar";
            this.Btn_EditarAlumno.UseVisualStyleBackColor = true;
            // 
            // Btn_GuardarAlumno
            // 
            this.Btn_GuardarAlumno.Location = new System.Drawing.Point(45, 236);
            this.Btn_GuardarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_GuardarAlumno.Name = "Btn_GuardarAlumno";
            this.Btn_GuardarAlumno.Size = new System.Drawing.Size(100, 28);
            this.Btn_GuardarAlumno.TabIndex = 10;
            this.Btn_GuardarAlumno.Text = "Guardar";
            this.Btn_GuardarAlumno.UseVisualStyleBackColor = true;
            this.Btn_GuardarAlumno.Click += new System.EventHandler(this.Btn_GuardarAlumno_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fecha Inicio";
            // 
            // Txt_FechaInicio
            // 
            this.Txt_FechaInicio.Location = new System.Drawing.Point(136, 190);
            this.Txt_FechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_FechaInicio.Name = "Txt_FechaInicio";
            this.Txt_FechaInicio.Size = new System.Drawing.Size(265, 22);
            this.Txt_FechaInicio.TabIndex = 8;
            // 
            // Txt_EdadAlumno
            // 
            this.Txt_EdadAlumno.Location = new System.Drawing.Point(125, 154);
            this.Txt_EdadAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_EdadAlumno.Name = "Txt_EdadAlumno";
            this.Txt_EdadAlumno.Size = new System.Drawing.Size(132, 22);
            this.Txt_EdadAlumno.TabIndex = 7;
            // 
            // Txt_DniAlumno
            // 
            this.Txt_DniAlumno.Location = new System.Drawing.Point(125, 122);
            this.Txt_DniAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_DniAlumno.Name = "Txt_DniAlumno";
            this.Txt_DniAlumno.Size = new System.Drawing.Size(132, 22);
            this.Txt_DniAlumno.TabIndex = 6;
            // 
            // Txt_ApellidoAlumno
            // 
            this.Txt_ApellidoAlumno.Location = new System.Drawing.Point(125, 90);
            this.Txt_ApellidoAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_ApellidoAlumno.Name = "Txt_ApellidoAlumno";
            this.Txt_ApellidoAlumno.Size = new System.Drawing.Size(132, 22);
            this.Txt_ApellidoAlumno.TabIndex = 5;
            // 
            // Txt_NombreAlumno
            // 
            this.Txt_NombreAlumno.Location = new System.Drawing.Point(125, 58);
            this.Txt_NombreAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_NombreAlumno.Name = "Txt_NombreAlumno";
            this.Txt_NombreAlumno.Size = new System.Drawing.Size(132, 22);
            this.Txt_NombreAlumno.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Edad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "D.N.I";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // PaginaMateria
            // 
            this.PaginaMateria.Controls.Add(this.Btn_BuscarMateria);
            this.PaginaMateria.Controls.Add(this.Btn_EliminarMateria);
            this.PaginaMateria.Controls.Add(this.Btn_EditarMateria);
            this.PaginaMateria.Controls.Add(this.Btn_GuardarMateria);
            this.PaginaMateria.Controls.Add(this.ComboBox_TurnoMateria);
            this.PaginaMateria.Controls.Add(this.Txt_NombreMateria);
            this.PaginaMateria.Controls.Add(this.label11);
            this.PaginaMateria.Controls.Add(this.label10);
            this.PaginaMateria.Location = new System.Drawing.Point(4, 25);
            this.PaginaMateria.Margin = new System.Windows.Forms.Padding(4);
            this.PaginaMateria.Name = "PaginaMateria";
            this.PaginaMateria.Padding = new System.Windows.Forms.Padding(4);
            this.PaginaMateria.Size = new System.Drawing.Size(439, 328);
            this.PaginaMateria.TabIndex = 2;
            this.PaginaMateria.Text = "Nueva Materia";
            this.PaginaMateria.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarMateria
            // 
            this.Btn_BuscarMateria.Location = new System.Drawing.Point(180, 190);
            this.Btn_BuscarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_BuscarMateria.Name = "Btn_BuscarMateria";
            this.Btn_BuscarMateria.Size = new System.Drawing.Size(100, 28);
            this.Btn_BuscarMateria.TabIndex = 13;
            this.Btn_BuscarMateria.Text = "Buscar";
            this.Btn_BuscarMateria.UseVisualStyleBackColor = true;
            this.Btn_BuscarMateria.Click += new System.EventHandler(this.Btn_BuscarMateria_Click);
            // 
            // Btn_EliminarMateria
            // 
            this.Btn_EliminarMateria.Location = new System.Drawing.Point(180, 140);
            this.Btn_EliminarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_EliminarMateria.Name = "Btn_EliminarMateria";
            this.Btn_EliminarMateria.Size = new System.Drawing.Size(100, 28);
            this.Btn_EliminarMateria.TabIndex = 12;
            this.Btn_EliminarMateria.Text = "Eliminar";
            this.Btn_EliminarMateria.UseVisualStyleBackColor = true;
            this.Btn_EliminarMateria.Click += new System.EventHandler(this.Btn_EliminarMateria_Click);
            // 
            // Btn_EditarMateria
            // 
            this.Btn_EditarMateria.Location = new System.Drawing.Point(52, 190);
            this.Btn_EditarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_EditarMateria.Name = "Btn_EditarMateria";
            this.Btn_EditarMateria.Size = new System.Drawing.Size(100, 28);
            this.Btn_EditarMateria.TabIndex = 11;
            this.Btn_EditarMateria.Text = "Editar";
            this.Btn_EditarMateria.UseVisualStyleBackColor = true;
            // 
            // Btn_GuardarMateria
            // 
            this.Btn_GuardarMateria.Location = new System.Drawing.Point(52, 140);
            this.Btn_GuardarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_GuardarMateria.Name = "Btn_GuardarMateria";
            this.Btn_GuardarMateria.Size = new System.Drawing.Size(100, 28);
            this.Btn_GuardarMateria.TabIndex = 10;
            this.Btn_GuardarMateria.Text = "Guardar";
            this.Btn_GuardarMateria.UseVisualStyleBackColor = true;
            this.Btn_GuardarMateria.Click += new System.EventHandler(this.Btn_GuardarMateria_Click);
            // 
            // ComboBox_TurnoMateria
            // 
            this.ComboBox_TurnoMateria.FormattingEnabled = true;
            this.ComboBox_TurnoMateria.Items.AddRange(new object[] {
            "Mañana ",
            "Tarde",
            "Noche"});
            this.ComboBox_TurnoMateria.Location = new System.Drawing.Point(180, 85);
            this.ComboBox_TurnoMateria.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_TurnoMateria.Name = "ComboBox_TurnoMateria";
            this.ComboBox_TurnoMateria.Size = new System.Drawing.Size(160, 24);
            this.ComboBox_TurnoMateria.TabIndex = 9;
            // 
            // Txt_NombreMateria
            // 
            this.Txt_NombreMateria.Location = new System.Drawing.Point(180, 48);
            this.Txt_NombreMateria.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_NombreMateria.Name = "Txt_NombreMateria";
            this.Txt_NombreMateria.Size = new System.Drawing.Size(132, 22);
            this.Txt_NombreMateria.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Turno ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre Materia";
            // 
            // Dgv_Listado
            // 
            this.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Listado.Location = new System.Drawing.Point(489, 80);
            this.Dgv_Listado.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Listado.Name = "Dgv_Listado";
            this.Dgv_Listado.RowHeadersWidth = 51;
            this.Dgv_Listado.Size = new System.Drawing.Size(761, 416);
            this.Dgv_Listado.TabIndex = 1;
            // 
            // Btn_CursosMateria
            // 
            this.Btn_CursosMateria.Location = new System.Drawing.Point(489, 32);
            this.Btn_CursosMateria.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_CursosMateria.Name = "Btn_CursosMateria";
            this.Btn_CursosMateria.Size = new System.Drawing.Size(148, 28);
            this.Btn_CursosMateria.TabIndex = 2;
            this.Btn_CursosMateria.Text = "Buscar Por Materia";
            this.Btn_CursosMateria.UseVisualStyleBackColor = true;
            // 
            // Btn_CursosAlumno
            // 
            this.Btn_CursosAlumno.Location = new System.Drawing.Point(925, 32);
            this.Btn_CursosAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_CursosAlumno.Name = "Btn_CursosAlumno";
            this.Btn_CursosAlumno.Size = new System.Drawing.Size(100, 28);
            this.Btn_CursosAlumno.TabIndex = 3;
            this.Btn_CursosAlumno.Text = "Buscar por Alumno";
            this.Btn_CursosAlumno.UseVisualStyleBackColor = true;
            // 
            // ComboBox_SeleccionarMateria1
            // 
            this.ComboBox_SeleccionarMateria1.FormattingEnabled = true;
            this.ComboBox_SeleccionarMateria1.Location = new System.Drawing.Point(675, 33);
            this.ComboBox_SeleccionarMateria1.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_SeleccionarMateria1.Name = "ComboBox_SeleccionarMateria1";
            this.ComboBox_SeleccionarMateria1.Size = new System.Drawing.Size(160, 24);
            this.ComboBox_SeleccionarMateria1.TabIndex = 4;
            // 
            // Txt_CursoAlumno
            // 
            this.Txt_CursoAlumno.Location = new System.Drawing.Point(1060, 33);
            this.Txt_CursoAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_CursoAlumno.Name = "Txt_CursoAlumno";
            this.Txt_CursoAlumno.Size = new System.Drawing.Size(132, 22);
            this.Txt_CursoAlumno.TabIndex = 5;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // FormularioInstitucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 554);
            this.Controls.Add(this.Txt_CursoAlumno);
            this.Controls.Add(this.ComboBox_SeleccionarMateria1);
            this.Controls.Add(this.Btn_CursosAlumno);
            this.Controls.Add(this.Btn_CursosMateria);
            this.Controls.Add(this.Dgv_Listado);
            this.Controls.Add(this.Pag);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioInstitucion";
            this.Text = "FormularioInstitucion";
            this.Load += new System.EventHandler(this.FormularioInstitucion_Load);
            this.Pag.ResumeLayout(false);
            this.Pagina_Inscribir.ResumeLayout(false);
            this.Pagina_Inscribir.PerformLayout();
            this.Pagina_Alumno.ResumeLayout(false);
            this.Pagina_Alumno.PerformLayout();
            this.PaginaMateria.ResumeLayout(false);
            this.PaginaMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Pag;
        private System.Windows.Forms.TabPage Pagina_Inscribir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Pagina_Alumno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Txt_FechaInicio;
        private System.Windows.Forms.TextBox Txt_EdadAlumno;
        private System.Windows.Forms.TextBox Txt_DniAlumno;
        private System.Windows.Forms.TextBox Txt_ApellidoAlumno;
        private System.Windows.Forms.TextBox Txt_NombreAlumno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_EliminarAlumno;
        private System.Windows.Forms.Button Btn_EditarAlumno;
        private System.Windows.Forms.Button Btn_GuardarAlumno;
        private System.Windows.Forms.Button Btn_BuscarAlumno;
        private System.Windows.Forms.TabPage PaginaMateria;
        private System.Windows.Forms.TextBox Txt_NombreMateria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ComboBox_SeleccionarMateria;
        private System.Windows.Forms.Button Btn_BuscarMateria;
        private System.Windows.Forms.Button Btn_EliminarMateria;
        private System.Windows.Forms.Button Btn_EditarMateria;
        private System.Windows.Forms.Button Btn_GuardarMateria;
        private System.Windows.Forms.ComboBox ComboBox_TurnoMateria;
        private System.Windows.Forms.ComboBox ComboBox_SeleccionarTurno;
        private System.Windows.Forms.RadioButton Rb_NoAprobo;
        private System.Windows.Forms.RadioButton Rb_SiAprobo;
        private System.Windows.Forms.Button Btn_AgregarCursada;
        private System.Windows.Forms.DataGridView Dgv_Listado;
        private System.Windows.Forms.Button Btn_CursosMateria;
        private System.Windows.Forms.Button Btn_CursosAlumno;
        private System.Windows.Forms.ComboBox ComboBox_SeleccionarMateria1;
        private System.Windows.Forms.TextBox Txt_CursoAlumno;
        private System.Windows.Forms.ErrorProvider error;
    }
}