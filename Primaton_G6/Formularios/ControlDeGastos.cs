using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Primaton_G6.Clases;

namespace Primaton_G6
{
    public partial class ControlDeGastos : Form
    {
        Clases.Persistencia_Gastos g = new Clases.Persistencia_Gastos();

        Clases.Persistencia_Usuarios listu = new Clases.Persistencia_Usuarios();

        Clases.Gastos ug = new Clases.Gastos();

        int fila = 0;

        public ControlDeGastos(string nombre)
        {
            InitializeComponent();

            //elimina la posibilidad de ingresar datos en el datagridview
            tablaGastos.AllowUserToAddRows = false;
            // elimina el encabezado de las filas
            tablaGastos.RowHeadersVisible = false;

            listu.ConfigInicial();

            listu.LeeUsuarios();

            g.ConfigInicial();

            tablaGastos.DataSource = g.TablaGastos;

            g.LeeGastos();

            ug.Usuario = nombre;

            lblIngresos.Text = Convert.ToString(listu.DevuelveIngresos(ug.Usuario));

            lblGastado.Text = "";
            lblGastado.Text = Convert.ToString(g.SumaIngresos(ug.Usuario));

            lblDisponible.Text = "";
            lblDisponible.Text = Convert.ToString(Convert.ToDouble(lblIngresos.Text) - Convert.ToDouble(lblGastado.Text));

            //int img = Convert.ToInt32(listu.DevuelveFoto(comboUsuarios.Text));
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            g.NuevoGasto(ug.Usuario, txtRubro.Text, txtFecha.Value, txtDescripcion.Text, Convert.ToDouble(txtImporte.Text));

            lblGastado.Text = "";
            lblGastado.Text = Convert.ToString(g.SumaIngresos(lblNombre.Text));

            lblDisponible.Text = "";
            lblDisponible.Text = Convert.ToString(Convert.ToDouble(lblIngresos.Text) - Convert.ToDouble(lblGastado.Text));
        }

        private void DataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //le digo a la variable fila en que celda estoy parado
            fila = e.RowIndex;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //si fila es distinto a -1 borre todo el rengon con removeAt y el indice
            if(fila != -1)
            {
                g.TablaGastos.Rows.RemoveAt(fila);

                string NombreArchivo = @"gastos.xml";

                g.TablaGastos.WriteXml(NombreArchivo);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}