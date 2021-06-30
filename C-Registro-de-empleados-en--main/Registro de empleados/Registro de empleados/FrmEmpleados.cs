using Registro_de_empleados.ActivoFijoModel;
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
    public partial class FrmEmpleados : Form
    {
        private FrmDatosEmpleado frmDatosEmpleado;
        private activoFijoModel activoFijoModel;
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmDatosEmpleado = new FrmDatosEmpleado();
            frmDatosEmpleado.ShowDialog();
        }
    }
}
