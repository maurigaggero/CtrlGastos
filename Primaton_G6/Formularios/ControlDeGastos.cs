using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaton_G6
{
    public partial class ControlDeGastos : Form
    {
        DataTable tabla;

        int c = 0;


        public ControlDeGastos()
        {
            InitializeComponent();
        }

        private void ControlDeGastos_Load(object sender, EventArgs e)
        {

//--------------------CREO LA TABLA-----------------------------
            tabla = new DataTable();

            tabla.Columns.Add("Tipo de gasto");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("Detalle");
            tabla.Columns.Add("Monto");

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
//------------------------Valido que el usuario rellene todos los campos------------------------
            if (cbTipoGasto.Text == "Tipo de gasto")
            {
                MessageBox.Show("Debes Seleccionar una opcion");
                return;
            }

            if (txtDetalle.Text == "Cantidad")
            {
                MessageBox.Show("Debes ingresar una cantidad valida");
                return;
            }

            if (txtCantidad.Text == "Detalle")
            {
                MessageBox.Show("Debes ingresar un detalle valido");
                return;
            }

            if (txtmonto.Text == "Monto")
            {
                MessageBox.Show("Debes ingresar un monto valido");
                return;
            }

            //------------------------Creo las variables para de depositar los txt y comboBox--------------------

            String tipo = "";
            String cantidad = "";
            String detalle = "";
            String monto = "";

            //----------------------------------------Relleno las variables-------------------------------------

            tipo = cbTipoGasto.Text;
            cantidad = txtCantidad.Text;
            detalle = txtDetalle.Text;
            monto = txtmonto.Text;


            //----------------------------------------Limpiar los textbox----------------------------------------
                cbTipoGasto.Text = "Tipo de gasto";
                txtCantidad.Text = "Cantidad";
                txtDetalle.Text = "Detalle";
                txtmonto.Text = "Monto";

            //------------------------Creo las filas de la tabla--------------------

            DataRow fila = tabla.NewRow();
            fila[0] = tipo;
            fila[1] = cantidad;
            fila[2] = detalle;
            fila[3] = monto;

            tabla.Rows.Add(fila);
            grilla.DataSource = tabla;

            //------------------------Cambio el tamaño de las columnas--------------------

            grilla.Columns[0].Width = 150;
            grilla.Columns[1].Width = 70;
            grilla.Columns[2].Width = 250;
            grilla.Columns[3].Width = 70;
        }

        private void DataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //le digo a la variable c  en que celda estoy parado
            c = e.RowIndex;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //le digo al boton que si c es distinto a -1 borre todo el rengon con removeAt y el indice
            if(c != -1)
            {
                grilla.Rows.RemoveAt(c);

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VentanaPrincipal principal = new VentanaPrincipal();
            principal.Show();
            this.Dispose();
        }
        //---------------------------cambia de color cuando el mouse pasa por la X de cerrar---------------------
        private void lblCerrar_MouseEnter(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.Black;
        }

        private void lblCerrar_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.White;
        }

        private void lblCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
            
        }


//------------------------------------deja en blanco los textbox cuando hay que escribir---------------------
        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
        }

        private void txtDetalle_Enter(object sender, EventArgs e)
        {
            txtDetalle.Text = "";
        }

        private void txtmonto_Enter(object sender, EventArgs e)
        {
            txtmonto.Text = "";
        }

    
    }
}
