using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class Venta
    {
        public int Id_v { get; set; }
        public string codigo { get; set; }
        public string nombreP { get; set; }
        public int Cantidad { get; set; }
        public string Op { get; set; }
    }
}
