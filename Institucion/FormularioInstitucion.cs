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

    }
}
