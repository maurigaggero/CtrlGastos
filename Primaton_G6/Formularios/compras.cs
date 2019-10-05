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
    public partial class compras : Form
    {
        Clases.Persistencia_Compras c = new Clases.Persistencia_Compras();
        public compras()
        {
            InitializeComponent();
            c.ConfigInicial();
            grilla.DataSource = c.TablaCompras;
            c.LeeCompras();

        }
        DataTable tabla;

        private void compras_Load(object sender, EventArgs e)
        {
            tabla = new DataTable();
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Producto");


            grilla.Columns[0].Width = 70;
            grilla.Columns[1].Width = 402;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtCantidad.Text == "" || txtCantidad.Text == "Cantidad" || txtProducto.Text == "" || txtProducto.Text == "Producto")
            {
                MessageBox.Show("Debes ingresar cantidad y producto valido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                c.NuevaCompra(txtCantidad.Text, txtProducto.Text);
                txtProducto.Text = "Producto";
                txtCantidad.Text = "Cantidad";
            }
        }
       
        #region DETALLES GRAFICOS
        private void txtProducto_Enter(object sender, EventArgs e)
        {
            if (txtProducto.Text == "Producto")
            {
                txtProducto.Text = "";
                txtProducto.ForeColor = Color.Black;
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "Cantidad")
            {
                txtCantidad.Text = "";
                txtCantidad.ForeColor = Color.Black;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Debes ingresar números");
            }
            if (e.KeyChar == 13)
            {
                txtProducto.Focus();
            }
        }
        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtCantidad.Text == "" || txtCantidad.Text == "Cantidad" || txtProducto.Text == "" || txtProducto.Text == "Producto")
                {
                    MessageBox.Show("Debes ingresar cantidad y producto valido", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    c.NuevaCompra(txtCantidad.Text, txtProducto.Text);
                    txtProducto.Text = "Producto";
                    txtCantidad.Text = "Cantidad";
                }
            }
        }
        #endregion


    }
}
