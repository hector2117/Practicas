using Sistematico___EthanDavila_y_AxelMoreno.Enums;
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
    public partial class Catalogo : Form
    {
        public string Busqueda = "";
        //public TelefonoModel TModel { get; set; }
        public List<Telefono> Telefonos { get; set; }
        public Catalogo()
        {
            InitializeComponent();
            LoadComponents();
        }

        private void LoadComponents()
        {
            dgvTelefonos.ReadOnly = true;
            dgvTelefonos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvTelefonos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTelefonos.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            //if (dgvTelefonos == null)
            //{
            //    return;
            //}
            //List<Telefono> filtro = new List<Telefono>();
            //string clave = TxtBusqueda.Text;
            //foreach (Telefono p in Telefonos)
            //{
            //    if ((p.ID + "").ToUpper().Contains(clave) || p.Nombre.ToUpper().Contains(clave) || (p.NoExistencias + "").ToUpper().Contains(clave)
            //            || (p.Precio + "").ToUpper().Contains(clave) || p.Descripción.ToUpper().Contains(clave) || p.Imagen.ToUpper().Contains(clave))
            //    {
            //        filtro.Add(p);
            //    }
            //    if (filtro.Count > 0)
            //    {
            //        dgvTelefonos.DataSource = null;
            //        dgvTelefonos.DataSource = filtro;
            //    }
            //}
            Buscador(Busqueda);
        }

        public void Buscador(string Buscador)
        {
            Buscador = TxtBusqueda.Text;
            try
            {
                foreach (DataGridViewRow Row in dgvTelefonos.Rows)
                {
                    foreach (DataGridViewCell Cell in Row.Cells)
                    {
                        if (Cell.Value.ToString() == Buscador)
                        {
                            dgvTelefonos.CurrentCell = Cell;
                        }
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTelefonos.Rows.Count == 0)
            {
                return;
            }
            int index = dgvTelefonos.CurrentCell.RowIndex;
            Telefonos.RemoveAt(index);
            dgvTelefonos.DataSource = null;
            dgvTelefonos.DataSource = Telefonos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Agregar frm = new Agregar();
            frm.Text = "Agregar";
            frm.Telefonos = Telefonos;
            frm.dgv = dgvTelefonos;
            frm.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvTelefonos.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar productos a la tabla");
                return;
            }
            if (dgvTelefonos.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una fila de la tabla");
                return;
            }
            int index = dgvTelefonos.CurrentCell.RowIndex;
            Agregar frm = new Agregar();
            frm.Text = "Actualizar";
            frm.Telefonos = Telefonos;
            frm.dgv = dgvTelefonos;
            frm.LoadTelefono(index);
            frm.editable = true;
            _ = frm.ShowDialog();
        }

        private void dgvTelefonos_Click(object sender, EventArgs e)
        {
            dgvTelefonos.DataSource = null;
            dgvTelefonos.DataSource = Telefonos;
        }
    }
}