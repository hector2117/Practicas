using Sistematico___EthanDavila_y_AxelMoreno.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistematico___EthanDavila_y_AxelMoreno.Poco
{
    public class Telefono
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int NoExistencias { get; set; }
        public Marcas Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public string Descripción { get; set; }
        public string Imagen { get; set; }
    }
}
