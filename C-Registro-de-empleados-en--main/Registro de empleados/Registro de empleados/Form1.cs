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
    public partial class Form1 : Form
    {
        private FrmEmpleados frmEmpleados;
        public Form1()
        {
            InitializeComponent();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados = new FrmEmpleados();
            frmEmpleados.MdiParent = this;
            frmEmpleados.Show();
        }
    }
}
