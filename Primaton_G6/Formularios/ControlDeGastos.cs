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
    public  partial class ControlDeGastos : Form
    {
        Clases.Persistencia_Gastos g = new Clases.Persistencia_Gastos();

        Clases.Persistencia_Usuarios listu = new Clases.Persistencia_Usuarios();

        Clases.Gastos ug = new Clases.Gastos();

        Formularios.Login lo = new Formularios.Login();

        public string prioridad = "";
        
        

        #region FUNCIONALIDAD

     

        public ControlDeGastos(string nombre, int idioma)
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

            lo.idioma = idioma;


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
                if (lo.idioma == 1)
                {
                    lblDisponible.Text = "SUPERASTE EL LÍMITE DE GASTOS";
                }
                if (lo.idioma == 2)
                {
                    lblDisponible.Text = "YOU EXCEED THE EXPENSE LIMIT";
                }
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
                if (lo.idioma == 1)
                {
                    MessageBox.Show("Hay campos vacíos, por favor revise");
                }
                else
                {
                        MessageBox.Show("There are empty fields, please check");
                }
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
                if (lo.idioma == 1)
                {
                    MessageBox.Show("Utilize la coma para céntimos");
                }
                else
                {
                    MessageBox.Show("Use the comma for cents");
                }
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
                if (lo.idioma == 1)
                {
                    MessageBox.Show("Debe ingresar números");
                }
                else
                {
                    MessageBox.Show("You must enter numbers");
                }
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

        #region INGLES/ESPAÑOL
        public void cambioIdioma()
        {
            if (lo.idioma == 2)
            {
                lblRubro.Text = "Item";
                lblFecha.Text = "Date";
                lblDescripcion.Text = "Description";
                lblImporte.Text = "Amount";
                chk_prioritario.Text = "Priority";
                btnAgregar.Text = "Add";
                btnBorrar.Text = "Delete";
                GrupoIngresos.Text = "Income";
                label6.Text = "What you have spent:";
                label7.Text = "Available to spend:";
                label9.Text = "% Redundant:";
                label8.Text = "% Important:";
                btnVolver.Text = "Go back";
            }
            else
            {
                lblRubro.Text = "Rubro";
                lblFecha.Text = "Fecha";
                lblDescripcion.Text = "Descripcion";
                lblImporte.Text = "Importe";
                chk_prioritario.Text = "Prioritario";
                btnAgregar.Text = "Agregar";
                btnBorrar.Text = "Borrar";
                GrupoIngresos.Text = "Ingresos";
                label6.Text = "Lo que llevas gastado:";
                label7.Text = "Disponible para gastar";
                label9.Text = "% Redundantes:";
                label8.Text = "% Importantes:";
                btnVolver.Text = "Volver atrás";
            }
        }
        #endregion

        private void ControlDeGastos_Load(object sender, EventArgs e)
        {
            cambioIdioma();
        }
    }
}
