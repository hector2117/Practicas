using Sistematico___EthanDavila_y_AxelMoreno.Model;
using Sistematico___EthanDavila_y_AxelMoreno.Poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico___EthanDavila_y_AxelMoreno
{
    public partial class Main : Form
    {
        private List<Telefono> Telefonos;
        private TelefonoModel TModel;
        public Main()
        {
            InitializeComponent();
            TModel = new TelefonoModel();
            Telefonos = new List<Telefono>();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogo frm = new Catalogo();
            frm.Telefonos = Telefonos;
            frm.MdiParent = this;
            frm.Show();
        }

        private void tablaProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View frm = new View();
            frm.Telefonos = Telefonos;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
