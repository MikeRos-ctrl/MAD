using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Cajero
    {
        public string clave { get; set; }
        public string registered_by { get; set; }
        public string nombre { get; set; }
        public string curp { get; set; }
        public string fecha_nacimiento { get; set; }
        public string nomina { get; set; }
        public bool status { get; set; }
        public string correo { get; set; }
        public string contra { get; set; }
        public string Op { get; set; }
    }
}
