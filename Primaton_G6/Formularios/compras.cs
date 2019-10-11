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
using System.Drawing.Printing;

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

        #region BOTON AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtCantidad.Text == "" || txtCantidad.Text == "Cantidad" || txtProducto.Text == "" || txtProducto.Text == "Producto")
            {
                lblAviso.Visible = true;
                return;
            }
            else
            {
                lblAviso.Visible = false;
                c.NuevaCompra(txtCantidad.Text, txtProducto.Text);
                txtProducto.Text = "Producto";
                txtCantidad.Text = "Cantidad";
                txtProducto.ForeColor = Color.Silver;
                txtCantidad.ForeColor = Color.Silver;
            }
        }
        #endregion

        #region TXT CANTIDAD
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

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "Cantidad";
                txtCantidad.ForeColor = Color.Silver;
            }
        }

        #endregion

        #region TXT PRODUCTO
        private void txtProducto_Enter(object sender, EventArgs e)
        {
            if (txtProducto.Text == "Producto")
            {
                txtProducto.Text = "";
                txtProducto.ForeColor = Color.Black;
            }
        }
        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtCantidad.Text == "" || txtCantidad.Text == "Cantidad" || txtProducto.Text == "" || txtProducto.Text == "Producto")
                {
                    lblAviso.Visible = true;
                    return;
                }
                else
                {
                    lblAviso.Visible = false;
                    c.NuevaCompra(txtCantidad.Text, txtProducto.Text);
                    txtProducto.Text = "Producto";
                    txtCantidad.Text = "Cantidad";
                    txtProducto.ForeColor = Color.Silver;
                    txtCantidad.ForeColor = Color.Silver;
                }
            }
        }
        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (txtProducto.Text == "")
            {
                txtProducto.Text = "Producto";
                txtProducto.ForeColor = Color.Silver;
            }
        }
        #endregion

        #region BOTON BORRAR

        private void btnBorrar_MouseEnter(object sender, EventArgs e)
        {
            btnBorrar.ForeColor = Color.Black;
        }
        private void btnBorrar_MouseLeave(object sender, EventArgs e)
        {
            btnBorrar.ForeColor = Color.White;
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            

            if (grilla.CurrentRow != null)
                {
                    grilla.Rows.RemoveAt(grilla.CurrentRow.Index);
                    string NombreArchivo = @"compras.xml";
                    c.TablaCompras.WriteXml(NombreArchivo, XmlWriteMode.WriteSchema);
                }
        }

        private void btnBorrar_MouseDown(object sender, MouseEventArgs e)
        {
            btnBorrar.BackgroundImage = (Primaton_G6.Properties.Resources.botonMaderaApretado);
        }

        private void btnBorrar_MouseUp(object sender, MouseEventArgs e)
        {
            btnBorrar.BackgroundImage = (Primaton_G6.Properties.Resources.botonMadera);
        }




        #endregion

        #region IMPRESION
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.grilla.Width, this.grilla.Height);
            grilla.DrawToBitmap(objBmp, new Rectangle(0, 0, this.grilla.Width, this.grilla.Height));

            e.Graphics.DrawImage(objBmp, 160, 100);
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        #endregion
    }
}
