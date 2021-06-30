using Registro_de_empleados.ActivoFijoModel;
using Registro_de_empleados.enums;
using Registro_de_empleados.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_empleados
{
    public partial class FrmDatosEmpleado : Form
    {
        private activoFijoModel activoFijoModel;
        public FrmDatosEmpleado()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string cedula = txtCedula.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;

            int indexP = cmbProfesion.SelectedIndex;
            Profesion profesion = (Profesion)Enum.GetValues(typeof(Profesion)).GetValue(indexP);

            int indexC = cmbCargo.SelectedIndex;
            Cargo cargo = (Cargo)Enum.GetValues(typeof(Cargo)).GetValue(indexC);

            decimal salario = Convert.ToDecimal(txtSalario.Text);

            Empleado empleado = new Empleado()
            {
                Id = id, Nombres = nombres, Apellidos = apellidos,
                Cedula = cedula, Telefono = telefono, Correo = correo,
                ProfesionP = profesion, CargoP = cargo, Salario = salario
            };

            activoFijoModel.Add(empleado);
        }

        private void FrmDatosEmpleado_Load(object sender, EventArgs e)
        {
            cmbCargo.Items.AddRange(Enum.GetValues(typeof(Cargo)).Cast<Object>().ToArray());
            cmbCargo.SelectedIndex = 0;
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbProfesion.Items.AddRange(Enum.GetValues(typeof(Profesion)).Cast<Object>().ToArray());
            cmbProfesion.SelectedIndex = 0;
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
