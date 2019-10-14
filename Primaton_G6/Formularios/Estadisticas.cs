using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            lblUsuario.Text = "Usuario: " + nombre + "\r\n" + "Ingresos: $" + ingresos;
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < pgasto.rubro.Length; i++)
            {
                Series serie = grafico.Series.Add(pgasto.titulo[i]);
                serie.Points.Add(Convert.ToDouble(pgasto.rubro[i]));
            }
        }
    }
}
