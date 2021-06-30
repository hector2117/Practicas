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

namespace Sistematico___EthanDavila_y_AxelMoreno.User_Controls
{
    public partial class ucTelefono : UserControl
    {
        private Agregar Actualizar;
        public List<Telefono> Telefonos { get; set; }
        public DataGridView dgv;
        public bool editable = false;
        public Telefono Telefono { get; set; }
        public ucTelefono()
        {
            InitializeComponent();
        }

        private void ucTelefono_Load(object sender, EventArgs e)
        {
            PBImage.Image = Image.FromFile(Telefono.Imagen);
            LkLblNombre.Text = $"{Telefono.ID} . {Telefono.Nombre}";
            LblMarcaModelo.Text = Telefono.Marca + ", " + Telefono.Modelo;
            LblNoExistencias.Text = LblNoExistencias.Text + " " + Telefono.NoExistencias;
            label2.Text = Telefono.Descripción;
        }

        private void LkLblNombre_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Actualizar = new Agregar();
            Actualizar.Telefonos = Telefonos;
            Actualizar.dgv = dgv;
            Actualizar.LoadTelefono(Telefono.ID);
            Actualizar.editable = false;
            Actualizar.Show();
        }
    }
}
