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
        
        #region FUNCIONALIDAD

        public ControlDeGastos(string nombre)
        {
            InitializeComponent();

            //elimina la posibilidad de ingresar datos en el datagridview
            tablaGastos.AllowUserToAddRows = false;
            // elimina el encabezado de las filas
            tablaGastos.RowHeadersVisible = false;

            listu.LeeUsuarios();

            g.LeeGastos();

            g.ConfigInicial();

            tablaGastos.DataSource = g.TablaGastos;

            ug.Usuario = nombre;

            g.TablaGastos.DefaultView.RowFilter = $"Usuario LIKE '{ug.Usuario}%'";

            lblIngresos.Text = Convert.ToString(listu.DevuelveIngresos(ug.Usuario));

            MuestraInfo();
            MuestraPorcentajes();
        }

        public void MuestraInfo()
        {
            lblGastado.Text = "";
            lblGastado.Text = Convert.ToString(g.SumaIngresos(ug.Usuario));

            if ((Convert.ToDouble(lblIngresos.Text) - Convert.ToDouble(lblGastado.Text)) <= 1000)
            {
                lblDisponible.ForeColor = Color.White;
                lblDisponible.BackColor = Color.Red;
                lblDisponible.Text = "SUPERASTE EL LÍMITE DE GASTOS";
            }
            else
            {
                lblDisponible.ForeColor = Color.White;
                lblDisponible.BackColor = Color.Transparent;
                lblDisponible.Text = "";
                lblDisponible.Text = Convert.ToString(Convert.ToDouble(lblIngresos.Text) - Convert.ToDouble(lblGastado.Text));
            }

        }

        public void MuestraPorcentajes()
        {
            lblImportante.Text = Convert.ToString((g.ContadorPrioritarios(ug.Usuario) + "%"));
            lblRedundante.Text = Convert.ToString((g.ContadorNoPrioritarios(ug.Usuario) + "%"));
        }

        private void TablaGastos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in tablaGastos.Rows)
            {
                if (this.tablaGastos.Rows[e.RowIndex].Cells["Prioridad"].Value.ToString() == "A")
                {
                    tablaGastos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    tablaGastos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.SelectionForeColor = Color.Yellow;
                    e.CellStyle.SelectionBackColor = Color.Green;
                }
                else
                {
                    tablaGastos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    tablaGastos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkBlue;
                    e.CellStyle.SelectionForeColor = Color.White;
                    e.CellStyle.SelectionBackColor = Color.Blue;
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
            MuestraPorcentajes();
        }
        #endregion

        
        #region BOTONES Y VISUALES

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            {
                if (tablaGastos.CurrentRow != null)
                {
                    tablaGastos.Rows.RemoveAt(tablaGastos.CurrentRow.Index);

                    string NombreArchivo = @"gastos.xml";

                    g.TablaGastos.WriteXml(NombreArchivo, XmlWriteMode.WriteSchema);

                    MuestraInfo();
                    MuestraPorcentajes();
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar) == '.')
            {
                e.Handled = true;
                MessageBox.Show("Utilize la coma para céntimos");
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Debe ingresar números");
            }
        }

        private void btnAgregar_MouseDown(object sender, MouseEventArgs e)
        {
            btnAgregar.BackgroundImage = (Primaton_G6.Properties.Resources.botonMaderaApretado);
        }

        private void btnAgregar_MouseUp(object sender, MouseEventArgs e)
        {
            btnAgregar.BackgroundImage = (Primaton_G6.Properties.Resources.botonMadera);
        }

        private void btnBorrar_MouseUp(object sender, MouseEventArgs e)
        {
            btnBorrar.BackgroundImage = (Primaton_G6.Properties.Resources.botonMadera);
        }

        private void btnBorrar_MouseDown(object sender, MouseEventArgs e)
        {
            btnBorrar.BackgroundImage = (Primaton_G6.Properties.Resources.botonMaderaApretado);
        }

        private void btnVolver_MouseDown(object sender, MouseEventArgs e)
        {
            btnVolver.BackgroundImage = (Primaton_G6.Properties.Resources.botonMaderaApretado);
        }

        private void btnVolver_MouseUp(object sender, MouseEventArgs e)
        {
            btnBorrar.BackgroundImage = (Primaton_G6.Properties.Resources.botonMadera);
        }
        #endregion
    }
}