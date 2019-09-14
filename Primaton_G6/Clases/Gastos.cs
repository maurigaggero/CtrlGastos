using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton_G6.Clases
{
    class Gastos
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int TipoGasto { get; set; }
        public double Importe { get; set; }
        public int Prioridad { get; set; }
        public Usuario quienFue { get; set; }
    }
}

//        public string AgregaGasto(string text)
//        {
//            try
//            {
//                if (ingresos[j] == null)
//                {
//                    ingresos[j] = text;

//                    j++;

//                    return ingresos[j];

//                }
//                else
//                {
//                    return "h";
//                }

//            }
//            catch (IndexOutOfRangeException)
//            {
//                MessageBox.Show("No se pueden cargar más ingresos");
//                return "h";
//            }
//        }
//    }
//}
