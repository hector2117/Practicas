using Sistematico___EthanDavila_y_AxelMoreno.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistematico___EthanDavila_y_AxelMoreno.Model
{
    public class TelefonoModel
    {
        private Telefono[] Telefonos;
        public TelefonoModel() { }

        public void Add(Telefono Emp)
        {
            if (Telefonos == null)
            {
                Telefonos = new Telefono[1];
                Telefonos[0] = Emp;
                return;
            }
            Telefono[] tmp = new Telefono[Telefonos.Length + 1];
            Array.Copy(Telefonos, tmp, Telefonos.Length);
            tmp[tmp.Length - 1] = Emp;

            Telefonos = tmp;
        }

        public Telefono[] getAll()
        {
            return Telefonos;
        }

        public void Remove(int index)
        {
            if (index < 0)
            {
                return;
            }
            if (Telefonos == null)
            {
                return;
            }
            if (index >= Telefonos.Length)
            {
                throw new IndexOutOfRangeException($"El index {index} esta fuera del rango");
            }
            if (index == 0 && Telefonos.Length == 1)
            {
                Telefonos = null;
                return;
            }
            Telefono[] tmp = new Telefono[Telefonos.Length - 1];
            if (index == 0)
            {
                Array.Copy(Telefonos, index + 1, tmp, 0, tmp.Length);
                Telefonos = tmp;
                return;
            }
            if (index == Telefonos.Length - 1)
            {
                Array.Copy(Telefonos, 0, tmp, 0, tmp.Length);
                Telefonos = tmp;
                return;
            }

            Array.Copy(Telefonos, 0, tmp, 0, index);
            Array.Copy(Telefonos, index + 1, tmp, index, (tmp.Length - index - 1));
        }
    }
}