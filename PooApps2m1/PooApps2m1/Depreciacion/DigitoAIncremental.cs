using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooApps2m1.Depreciacion
{
    public class DigitoAIncremental : IDepreciacion
    {
        public decimal[] Calcular(decimal valor, decimal valorR, int vidaUtil)
        {
            int factor = vidaUtil * (vidaUtil + 1) / 2;

            decimal[] depreciacion = new decimal[vidaUtil];

            for (int i = 0; i < depreciacion.Length; i++)
            {
                depreciacion[i] = (valor - valorR) * ((i + 1) / factor);
            }

            return depreciacion;
        }
    }
}
