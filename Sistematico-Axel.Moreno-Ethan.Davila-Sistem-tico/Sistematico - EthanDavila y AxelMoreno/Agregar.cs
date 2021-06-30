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
    public partial class Agregar : Form
    {
        private int RowIndex = -1;
        public bool editable = false;
        public DataGridView dgv;
        //public TelefonoModel TModel { get; set; }
        public List<Telefono> Telefonos { get; set; }
        public Agregar()
        {
            InitializeComponent();
            LoadComponents();
        }
        private void LoadComponents()
        {
            dgv = new DataGridView();
            CmbMarca.Items.AddRange(Enum.GetValues(typeof(Marcas)).Cast<Object>().ToArray());
            CmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbMarca.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();
                int Id = r.Next(0, 100);
                string Nombre = TxtNombre.Text;
                int NoExistencias = Int32.Parse(TxtNoExistencias.Text);
                int index = CmbMarca.SelectedIndex;
                Marcas Marca = (Marcas)Enum.GetValues(typeof(Marcas)).GetValue(index);
                string Modelo = TxtModelo.Text;
                decimal.TryParse(TxtPrecio.Text, out decimal Precio);
                string Descripcion = TxtDescripcion.Text;
                string Imagen = TxtImagen.Text;
                ValidateTelefono(Nombre, NoExistencias, out Precio, Modelo);

                Telefono T = new Telefono()
                {
                    ID = Id,
                    Nombre = Nombre,
                    NoExistencias = NoExistencias,
                    Marca = Marca,
                    Modelo = Modelo,
                    Precio = Precio,
                    Descripción = Descripcion,
                    Imagen = Imagen,
                };
                if (editable && RowIndex != -1)
                {
                    Telefono pr = Telefonos.ElementAt(RowIndex);
                    pr.Nombre = Nombre;
                    pr.NoExistencias = NoExistencias;
                    pr.Marca = Marca;
                    pr.Modelo = Modelo;
                    pr.Precio = Precio;
                    pr.Descripción = Descripcion;
                    pr.Imagen = Imagen;
                    RowIndex = -1;

                    ValidateTelefono(Nombre, NoExistencias, out Precio, Modelo);

                    MessageBox.Show("Producto actualizado satisfactoriamente");
                }
                else
                {
                    Telefonos.Add(T);
                    MessageBox.Show("El Teléfono ha sido agregado exitosamente!!");
                }

                dgv.DataSource = null;
                dgv.DataSource = Telefonos;
                dgv.Refresh();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateTelefono(string Nombre, int NoExistencias, out decimal Precio, string Modelo)
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                throw new ArgumentException("El nombres es requerido!!");
            }
            if (!int.TryParse(TxtNoExistencias.Text, out int No))
            {
                throw new ArgumentException("El No. de productos es inválido!!");
            }
            NoExistencias = No;
            if (!decimal.TryParse(TxtPrecio.Text, out decimal PrecioT))
            {
                throw new ArgumentException($"El salario '{TxtPrecio.Text}' es inválido");
            }
            Precio = PrecioT;
            if (string.IsNullOrWhiteSpace(Modelo))
            {
                throw new ArgumentException("El modelo es requerido!!");
            }
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog Imagen = new OpenFileDialog();
            if (Imagen.ShowDialog() == DialogResult.OK)
            {
                TxtImagen.Text = Imagen.FileName;
            }
        }
        public void LoadTelefono(int i)
        {
            Telefono p = Telefonos.ElementAt(i);
            TxtNombre.Text = p.Nombre;
            TxtNoExistencias.Text = p.NoExistencias + "";
            //cmbMarca.SelectedIndex = 0;
            TxtModelo.Text = p.Modelo + "";
            TxtPrecio.Text = p.Precio + "";
            TxtDescripcion.Text = p.Descripción;
            TxtImagen.Text = p.Imagen;
            RowIndex = i;
        }

        public void CargarCamposProducto(int id)
        {
            Telefono telefono = Telefonos.pro;
        }
    }
}
