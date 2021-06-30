using PooApps2m1.Depreciacion;
using PooApps2m1.enums;
using PooApps2m1.model;
using PooApps2m1.poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooApps2m1
{
    public partial class FrmDepreciacion : Form
    {
        public ActivoFijoModel ActivoFijoModel { get; set; }
        public FrmDepreciacion()
        {
            InitializeComponent();
        }

        private void FrmDepreciacion_Load(object sender, EventArgs e)
        {
            cmbMetodos.Items.AddRange(Enum.GetValues(typeof(MetodoDepreciacion))
                                          .Cast<object>().ToArray());
            cmbMetodos.SelectedIndex = 0;
            cmbMetodos.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadDepreciacion();
        }

        private void LoadDepreciacion()
        {
            if(ActivoFijoModel.GetAll() == null)
            {
                return;
            }

            int columns = ActivoFijoModel.GetGreaterVidaUtil();
            for(int j = 0; j <= columns; j++)
            {
                if (j == 0)
                {
                    dgvDepreciacion.Columns.Add($"Column{j}","Nombre Activo");
                    continue;
                }
                dgvDepreciacion.Columns.Add($"Column{j}", $"{j}");

            }

            int index = cmbMetodos.SelectedIndex;

            IDepreciacion depreciacion = new DepreciacionFactory()
                .CreateInstance((MetodoDepreciacion)Enum.GetValues(typeof(MetodoDepreciacion))
                                                        .GetValue(index));
            dgvDepreciacion.Rows.Clear();
            int k = 0;
            foreach(ActivoFijo af in ActivoFijoModel.GetAll())
            {
                decimal[] deps = depreciacion.Calcular(af.Valor, af.ValorResidual,
                                                        (int)af.TipoActivo);
                dgvDepreciacion.Rows.Add();
                for(int i = 0; i <= deps.Length; i++)
                {
                    if(i == 0)
                    {
                        dgvDepreciacion.Rows[k].Cells[i].Value = af.Nombre;
                        continue;
                    }
                    dgvDepreciacion.Rows[k].Cells[i].Value = deps[i - 1];
                }
                k++;
            }
        }
    }
}
