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
            this.Pag = new System.Windows.Forms.TabControl();
            this.Pagina_Inscribir = new System.Windows.Forms.TabPage();
            this.Pagina_Alumno = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_NombreAlumno = new System.Windows.Forms.TextBox();
            this.Txt_ApellidoAlumno = new System.Windows.Forms.TextBox();
            this.Txt_DniAlumno = new System.Windows.Forms.TextBox();
            this.Txt_EdadAlumno = new System.Windows.Forms.TextBox();
            this.Txt_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_GuardarAlumno = new System.Windows.Forms.Button();
            this.Btn_EditarAlumno = new System.Windows.Forms.Button();
            this.Btn_EliminarAlumno = new System.Windows.Forms.Button();
            this.Btn_BuscarAlumno = new System.Windows.Forms.Button();
            this.PaginaMateria = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_NombreMateria = new System.Windows.Forms.TextBox();
            this.ComboBox_SeleccionarMateria = new System.Windows.Forms.ComboBox();
            this.ComboBox_TurnoMateria = new System.Windows.Forms.ComboBox();
            this.Btn_GuardarMateria = new System.Windows.Forms.Button();
            this.Btn_EditarMateria = new System.Windows.Forms.Button();
            this.Btn_EliminarMateria = new System.Windows.Forms.Button();
            this.Btn_BuscarMateria = new System.Windows.Forms.Button();
            this.ComboBox_SeleccionarTurno = new System.Windows.Forms.ComboBox();
            this.Rb_SiAprobo = new System.Windows.Forms.RadioButton();
            this.Rb_NoAprobo = new System.Windows.Forms.RadioButton();
            this.Btn_AgregarCursada = new System.Windows.Forms.Button();
            this.Dgv_Listado = new System.Windows.Forms.DataGridView();
            this.Btn_CursosMateria = new System.Windows.Forms.Button();
            this.Btn_CursosAlumno = new System.Windows.Forms.Button();
            this.ComboBox_SeleccionarMateria1 = new System.Windows.Forms.ComboBox();
            this.Txt_CursoAlumno = new System.Windows.Forms.TextBox();
            this.Pag.SuspendLayout();
            this.Pagina_Inscribir.SuspendLayout();
            this.Pagina_Alumno.SuspendLayout();
            this.PaginaMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).BeginInit();
            this.SuspendLayout();
            // 
            // Pag
            // 
            this.Pag.Controls.Add(this.Pagina_Inscribir);
            this.Pag.Controls.Add(this.Pagina_Alumno);
            this.Pag.Controls.Add(this.PaginaMateria);
            this.Pag.Location = new System.Drawing.Point(26, 41);
            this.Pag.Name = "Pag";
            this.Pag.SelectedIndex = 0;
            this.Pag.Size = new System.Drawing.Size(335, 290);
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
            this.Pagina_Inscribir.Location = new System.Drawing.Point(4, 22);
            this.Pagina_Inscribir.Name = "Pagina_Inscribir";
            this.Pagina_Inscribir.Padding = new System.Windows.Forms.Padding(3);
            this.Pagina_Inscribir.Size = new System.Drawing.Size(327, 264);
            this.Pagina_Inscribir.TabIndex = 0;
            this.Pagina_Inscribir.Text = "Inscribir";
            this.Pagina_Inscribir.UseVisualStyleBackColor = true;
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
            this.Pagina_Alumno.Location = new System.Drawing.Point(4, 22);
            this.Pagina_Alumno.Name = "Pagina_Alumno";
            this.Pagina_Alumno.Padding = new System.Windows.Forms.Padding(3);
            this.Pagina_Alumno.Size = new System.Drawing.Size(327, 264);
            this.Pagina_Alumno.TabIndex = 1;
            this.Pagina_Alumno.Text = "Nuevo Alumno";
            this.Pagina_Alumno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccionar Materia";
            // 
            // Txt
            // 
            this.Txt.AutoSize = true;
            this.Txt.Location = new System.Drawing.Point(22, 66);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(94, 13);
            this.Txt.TabIndex = 5;
            this.Txt.Text = "Seleccionar Turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aprobado/a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "D.N.I";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Edad";
            // 
            // Txt_NombreAlumno
            // 
            this.Txt_NombreAlumno.Location = new System.Drawing.Point(94, 47);
            this.Txt_NombreAlumno.Name = "Txt_NombreAlumno";
            this.Txt_NombreAlumno.Size = new System.Drawing.Size(100, 20);
            this.Txt_NombreAlumno.TabIndex = 4;
            // 
            // Txt_ApellidoAlumno
            // 
            this.Txt_ApellidoAlumno.Location = new System.Drawing.Point(94, 73);
            this.Txt_ApellidoAlumno.Name = "Txt_ApellidoAlumno";
            this.Txt_ApellidoAlumno.Size = new System.Drawing.Size(100, 20);
            this.Txt_ApellidoAlumno.TabIndex = 5;
            // 
            // Txt_DniAlumno
            // 
            this.Txt_DniAlumno.Location = new System.Drawing.Point(94, 99);
            this.Txt_DniAlumno.Name = "Txt_DniAlumno";
            this.Txt_DniAlumno.Size = new System.Drawing.Size(100, 20);
            this.Txt_DniAlumno.TabIndex = 6;
            // 
            // Txt_EdadAlumno
            // 
            this.Txt_EdadAlumno.Location = new System.Drawing.Point(94, 125);
            this.Txt_EdadAlumno.Name = "Txt_EdadAlumno";
            this.Txt_EdadAlumno.Size = new System.Drawing.Size(100, 20);
            this.Txt_EdadAlumno.TabIndex = 7;
            // 
            // Txt_FechaInicio
            // 
            this.Txt_FechaInicio.Location = new System.Drawing.Point(102, 154);
            this.Txt_FechaInicio.Name = "Txt_FechaInicio";
            this.Txt_FechaInicio.Size = new System.Drawing.Size(200, 20);
            this.Txt_FechaInicio.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fecha Inicio";
            // 
            // Btn_GuardarAlumno
            // 
            this.Btn_GuardarAlumno.Location = new System.Drawing.Point(34, 192);
            this.Btn_GuardarAlumno.Name = "Btn_GuardarAlumno";
            this.Btn_GuardarAlumno.Size = new System.Drawing.Size(75, 23);
            this.Btn_GuardarAlumno.TabIndex = 10;
            this.Btn_GuardarAlumno.Text = "Guardar";
            this.Btn_GuardarAlumno.UseVisualStyleBackColor = true;
            // 
            // Btn_EditarAlumno
            // 
            this.Btn_EditarAlumno.Location = new System.Drawing.Point(34, 221);
            this.Btn_EditarAlumno.Name = "Btn_EditarAlumno";
            this.Btn_EditarAlumno.Size = new System.Drawing.Size(75, 23);
            this.Btn_EditarAlumno.TabIndex = 11;
            this.Btn_EditarAlumno.Text = "Editar";
            this.Btn_EditarAlumno.UseVisualStyleBackColor = true;
            // 
            // Btn_EliminarAlumno
            // 
            this.Btn_EliminarAlumno.Location = new System.Drawing.Point(119, 192);
            this.Btn_EliminarAlumno.Name = "Btn_EliminarAlumno";
            this.Btn_EliminarAlumno.Size = new System.Drawing.Size(75, 23);
            this.Btn_EliminarAlumno.TabIndex = 12;
            this.Btn_EliminarAlumno.Text = "Eliminar";
            this.Btn_EliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarAlumno
            // 
            this.Btn_BuscarAlumno.Location = new System.Drawing.Point(119, 221);
            this.Btn_BuscarAlumno.Name = "Btn_BuscarAlumno";
            this.Btn_BuscarAlumno.Size = new System.Drawing.Size(75, 23);
            this.Btn_BuscarAlumno.TabIndex = 13;
            this.Btn_BuscarAlumno.Text = "Buscar";
            this.Btn_BuscarAlumno.UseVisualStyleBackColor = true;
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
            this.PaginaMateria.Location = new System.Drawing.Point(4, 22);
            this.PaginaMateria.Name = "PaginaMateria";
            this.PaginaMateria.Padding = new System.Windows.Forms.Padding(3);
            this.PaginaMateria.Size = new System.Drawing.Size(327, 264);
            this.PaginaMateria.TabIndex = 2;
            this.PaginaMateria.Text = "Nueva Materia";
            this.PaginaMateria.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre Materia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Turno ";
            // 
            // Txt_NombreMateria
            // 
            this.Txt_NombreMateria.Location = new System.Drawing.Point(135, 39);
            this.Txt_NombreMateria.Name = "Txt_NombreMateria";
            this.Txt_NombreMateria.Size = new System.Drawing.Size(100, 20);
            this.Txt_NombreMateria.TabIndex = 3;
            // 
            // ComboBox_SeleccionarMateria
            // 
            this.ComboBox_SeleccionarMateria.FormattingEnabled = true;
            this.ComboBox_SeleccionarMateria.Location = new System.Drawing.Point(129, 34);
            this.ComboBox_SeleccionarMateria.Name = "ComboBox_SeleccionarMateria";
            this.ComboBox_SeleccionarMateria.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_SeleccionarMateria.TabIndex = 8;
            // 
            // ComboBox_TurnoMateria
            // 
            this.ComboBox_TurnoMateria.FormattingEnabled = true;
            this.ComboBox_TurnoMateria.Location = new System.Drawing.Point(135, 69);
            this.ComboBox_TurnoMateria.Name = "ComboBox_TurnoMateria";
            this.ComboBox_TurnoMateria.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_TurnoMateria.TabIndex = 9;
            // 
            // Btn_GuardarMateria
            // 
            this.Btn_GuardarMateria.Location = new System.Drawing.Point(39, 114);
            this.Btn_GuardarMateria.Name = "Btn_GuardarMateria";
            this.Btn_GuardarMateria.Size = new System.Drawing.Size(75, 23);
            this.Btn_GuardarMateria.TabIndex = 10;
            this.Btn_GuardarMateria.Text = "Guardar";
            this.Btn_GuardarMateria.UseVisualStyleBackColor = true;
            // 
            // Btn_EditarMateria
            // 
            this.Btn_EditarMateria.Location = new System.Drawing.Point(39, 154);
            this.Btn_EditarMateria.Name = "Btn_EditarMateria";
            this.Btn_EditarMateria.Size = new System.Drawing.Size(75, 23);
            this.Btn_EditarMateria.TabIndex = 11;
            this.Btn_EditarMateria.Text = "Editar";
            this.Btn_EditarMateria.UseVisualStyleBackColor = true;
            // 
            // Btn_EliminarMateria
            // 
            this.Btn_EliminarMateria.Location = new System.Drawing.Point(135, 114);
            this.Btn_EliminarMateria.Name = "Btn_EliminarMateria";
            this.Btn_EliminarMateria.Size = new System.Drawing.Size(75, 23);
            this.Btn_EliminarMateria.TabIndex = 12;
            this.Btn_EliminarMateria.Text = "Eliminar";
            this.Btn_EliminarMateria.UseVisualStyleBackColor = true;
            // 
            // Btn_BuscarMateria
            // 
            this.Btn_BuscarMateria.Location = new System.Drawing.Point(135, 154);
            this.Btn_BuscarMateria.Name = "Btn_BuscarMateria";
            this.Btn_BuscarMateria.Size = new System.Drawing.Size(75, 23);
            this.Btn_BuscarMateria.TabIndex = 13;
            this.Btn_BuscarMateria.Text = "Buscar";
            this.Btn_BuscarMateria.UseVisualStyleBackColor = true;
            // 
            // ComboBox_SeleccionarTurno
            // 
            this.ComboBox_SeleccionarTurno.FormattingEnabled = true;
            this.ComboBox_SeleccionarTurno.Location = new System.Drawing.Point(129, 66);
            this.ComboBox_SeleccionarTurno.Name = "ComboBox_SeleccionarTurno";
            this.ComboBox_SeleccionarTurno.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_SeleccionarTurno.TabIndex = 9;
            // 
            // Rb_SiAprobo
            // 
            this.Rb_SiAprobo.AutoSize = true;
            this.Rb_SiAprobo.Location = new System.Drawing.Point(129, 112);
            this.Rb_SiAprobo.Name = "Rb_SiAprobo";
            this.Rb_SiAprobo.Size = new System.Drawing.Size(34, 17);
            this.Rb_SiAprobo.TabIndex = 10;
            this.Rb_SiAprobo.TabStop = true;
            this.Rb_SiAprobo.Text = "Si";
            this.Rb_SiAprobo.UseVisualStyleBackColor = true;
            // 
            // Rb_NoAprobo
            // 
            this.Rb_NoAprobo.AutoSize = true;
            this.Rb_NoAprobo.Location = new System.Drawing.Point(129, 135);
            this.Rb_NoAprobo.Name = "Rb_NoAprobo";
            this.Rb_NoAprobo.Size = new System.Drawing.Size(39, 17);
            this.Rb_NoAprobo.TabIndex = 11;
            this.Rb_NoAprobo.TabStop = true;
            this.Rb_NoAprobo.Text = "No";
            this.Rb_NoAprobo.UseVisualStyleBackColor = true;
            // 
            // Btn_AgregarCursada
            // 
            this.Btn_AgregarCursada.Location = new System.Drawing.Point(25, 168);
            this.Btn_AgregarCursada.Name = "Btn_AgregarCursada";
            this.Btn_AgregarCursada.Size = new System.Drawing.Size(75, 23);
            this.Btn_AgregarCursada.TabIndex = 12;
            this.Btn_AgregarCursada.Text = "Agregar Cursada";
            this.Btn_AgregarCursada.UseVisualStyleBackColor = true;
            // 
            // Dgv_Listado
            // 
            this.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Listado.Location = new System.Drawing.Point(367, 65);
            this.Dgv_Listado.Name = "Dgv_Listado";
            this.Dgv_Listado.Size = new System.Drawing.Size(571, 338);
            this.Dgv_Listado.TabIndex = 1;
            // 
            // Btn_CursosMateria
            // 
            this.Btn_CursosMateria.Location = new System.Drawing.Point(367, 26);
            this.Btn_CursosMateria.Name = "Btn_CursosMateria";
            this.Btn_CursosMateria.Size = new System.Drawing.Size(111, 23);
            this.Btn_CursosMateria.TabIndex = 2;
            this.Btn_CursosMateria.Text = "Buscar Por Materia";
            this.Btn_CursosMateria.UseVisualStyleBackColor = true;
            // 
            // Btn_CursosAlumno
            // 
            this.Btn_CursosAlumno.Location = new System.Drawing.Point(694, 26);
            this.Btn_CursosAlumno.Name = "Btn_CursosAlumno";
            this.Btn_CursosAlumno.Size = new System.Drawing.Size(75, 23);
            this.Btn_CursosAlumno.TabIndex = 3;
            this.Btn_CursosAlumno.Text = "Buscar por Alumno";
            this.Btn_CursosAlumno.UseVisualStyleBackColor = true;
            // 
            // ComboBox_SeleccionarMateria1
            // 
            this.ComboBox_SeleccionarMateria1.FormattingEnabled = true;
            this.ComboBox_SeleccionarMateria1.Location = new System.Drawing.Point(506, 27);
            this.ComboBox_SeleccionarMateria1.Name = "ComboBox_SeleccionarMateria1";
            this.ComboBox_SeleccionarMateria1.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_SeleccionarMateria1.TabIndex = 4;
            // 
            // Txt_CursoAlumno
            // 
            this.Txt_CursoAlumno.Location = new System.Drawing.Point(795, 27);
            this.Txt_CursoAlumno.Name = "Txt_CursoAlumno";
            this.Txt_CursoAlumno.Size = new System.Drawing.Size(100, 20);
            this.Txt_CursoAlumno.TabIndex = 5;
            // 
            // FormularioInstitucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.Txt_CursoAlumno);
            this.Controls.Add(this.ComboBox_SeleccionarMateria1);
            this.Controls.Add(this.Btn_CursosAlumno);
            this.Controls.Add(this.Btn_CursosMateria);
            this.Controls.Add(this.Dgv_Listado);
            this.Controls.Add(this.Pag);
            this.Name = "FormularioInstitucion";
            this.Text = "FormularioInstitucion";
            this.Pag.ResumeLayout(false);
            this.Pagina_Inscribir.ResumeLayout(false);
            this.Pagina_Inscribir.PerformLayout();
            this.Pagina_Alumno.ResumeLayout(false);
            this.Pagina_Alumno.PerformLayout();
            this.PaginaMateria.ResumeLayout(false);
            this.PaginaMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).EndInit();
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
    }
}