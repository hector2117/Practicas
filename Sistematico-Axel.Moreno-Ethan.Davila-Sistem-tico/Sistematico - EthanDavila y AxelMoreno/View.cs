using Sistematico___EthanDavila_y_AxelMoreno.Model;
using Sistematico___EthanDavila_y_AxelMoreno.Poco;
using Sistematico___EthanDavila_y_AxelMoreno.User_Controls;
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
    public partial class View : Form
    {
        public List<Telefono> Telefonos { get; set; }
        private ucTelefono UcTelefono;
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            if (Telefonos == null)
            {
                return;
            }
            foreach (Telefono T in Telefonos)
            {
                UcTelefono = new ucTelefono();
                UcTelefono.Telefono = T;
                this.flowLayoutPanel1.Controls.Add(UcTelefono);
            }
        }
    }
}
