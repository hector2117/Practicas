using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooApps2m1.Depreciacion
{
    class DigitoADecremental : IDepreciacion
    {
        public decimal[] Calcular(decimal valor, decimal valorR, int vidaUtil)
        {
            int factor = vidaUtil * (vidaUtil + 1) / 2;

            decimal[] depreciacion = new decimal[vidaUtil];

            for (int i = 0; i < vidaUtil; i++)
            {
                depreciacion[i] = (valor - valorR) * ((vidaUtil - i) / factor);
            }

            return depreciacion;
        }
    }
}
