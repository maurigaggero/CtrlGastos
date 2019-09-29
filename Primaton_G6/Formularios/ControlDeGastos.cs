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

        public string prioridad = "";

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

            g.TablaGastos.DefaultView.RowFilter = $"Usuario LIKE '{ug.Usuario}%'";

            lblIngresos.Text = Convert.ToString(listu.DevuelveIngresos(ug.Usuario));

            MuestraInfo();

            //int img = Convert.ToInt32(listu.DevuelveFoto(comboUsuarios.Text));
        }

        public void MuestraInfo()
        {
            lblGastado.Text = "";
            lblGastado.Text = Convert.ToString(g.SumaIngresos(ug.Usuario));

            if ((Convert.ToDouble(lblIngresos.Text) - Convert.ToDouble(lblGastado.Text)) <= 1000)
            {
                lblDisponible.ForeColor = Color.Red;
                lblDisponible.Text = "SUPERASTE EL LÍMITE DE GASTOS";
            }
            else
            {
                lblDisponible.ForeColor = Color.White;
                lblDisponible.Text = "";
                lblDisponible.Text = Convert.ToString(Convert.ToDouble(lblIngresos.Text) - Convert.ToDouble(lblGastado.Text));
            }

        }

        private void TablaGastos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in tablaGastos.Rows)
            {
                if (this.tablaGastos.Rows[e.RowIndex].Cells["Prioridad"].Value.ToString() == "A")
                {
                    tablaGastos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                    tablaGastos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Orange;
                    e.CellStyle.SelectionForeColor = Color.Yellow;
                    e.CellStyle.SelectionBackColor = Color.Orange;
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (chk_prioritario.Checked)
            {
                prioridad = "A";
            }
            else
            {
                prioridad = "";
            }

            if (txtRubro.Text == "" || txtDescripcion.Text == "" || txtImporte.Text == "")
            {
                MessageBox.Show("Hay campos vacíos, por favor revise");
            }
            else
            {
                g.NuevoGasto(ug.Usuario, txtRubro.Text, prioridad, txtFecha.Value, txtDescripcion.Text, Convert.ToDouble(txtImporte.Text));
            }

            txtRubro.Text = "";
            txtFecha.Text = "";
            txtDescripcion.Text = "";
            txtImporte.Text = "";

            MuestraInfo();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            {
                if (tablaGastos.CurrentRow != null)
                {
                    tablaGastos.Rows.RemoveAt(tablaGastos.CurrentRow.Index);

                    string NombreArchivo = @"gastos.xml";

                    g.TablaGastos.WriteXml(NombreArchivo);

                    MuestraInfo();
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}