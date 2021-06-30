using Registro_de_empleados.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_empleados.ActivoFijoModel
{
    public class activoFijoModel
    {
        private Empleado[] empleados;

        public activoFijoModel()
        {
        }

        public void Add(Empleado e)
        {
            if (e == null)
            {
                return;
            }

            if (empleados == null)
            {
                empleados = new Empleado[1];
                empleados[0] = e;
                return;
            }

            empleados = Temp(e);
        }

        public Empleado[] Temp(Empleado e)
        {
            Empleado[] temp = new Empleado[empleados.Length+1];
            Array.Copy(empleados,temp,empleados.Length);
            temp[temp.Length - 1] = e;

            return temp;
        }

        public Empleado[] FindAll()
        {
            return empleados;
        }


    }
}
