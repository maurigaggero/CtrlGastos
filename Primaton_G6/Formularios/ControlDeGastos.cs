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
        int c = 0;
        public ControlDeGastos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbTipoGasto.Text == "Tipo de gasto" || txtcantidad.Text == "" || txtDetalle.Text == "" || txtDetalle.Text == "")
            {
                MessageBox.Show("Debes rellenar todos los casilleros");
            }
            else
            {
                //Incremento de celda
                int n = DataView.Rows.Add();

                //Relleno de informacion de la tabla
                DataView.Rows[n].Cells[0].Value = cbTipoGasto.Text;
                DataView.Rows[n].Cells[2].Value = txtcantidad.Text;
                DataView.Rows[n].Cells[1].Value = txtDetalle.Text;
                DataView.Rows[n].Cells[3].Value = txtmonto.Text;

                //Limpiar los textbox
                cbTipoGasto.Text = "Tipo de gasto";
                txtcantidad.Text = "";
                txtDetalle.Text = "";
                txtmonto.Text = "";
            }
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
                DataView.Rows.RemoveAt(c);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
