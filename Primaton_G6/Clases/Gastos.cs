using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton_G6.Clases
{
    public class Gastos
    {
        public string Id { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public int Prioridad { get; set; }
        public string Rubro { get; set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }
    }
}