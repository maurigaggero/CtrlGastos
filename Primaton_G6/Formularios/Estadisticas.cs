using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton_G6.Formularios
{
    public partial class Estadisticas : Form
    {
        Clases.Persistencia_Gastos pgasto = new Clases.Persistencia_Gastos();

        public Estadisticas(string nombre, int ingresos)
        {
            InitializeComponent();

            pgasto.LeeGastos();

            pgasto.Porcentaje(nombre);

            lblPorcentajes.Text = pgasto.CalculaPorcentajes(ingresos);
        }
    }
}
