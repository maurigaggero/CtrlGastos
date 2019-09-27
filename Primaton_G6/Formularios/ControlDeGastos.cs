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
        Clases.Persistencia_Gastos g = new Clases.Persistencia_Gastos();

        Clases.Persistencia_Usuarios listu = new Clases.Persistencia_Usuarios();

        int fila = 0;

        public ControlDeGastos()
        {
            InitializeComponent();

            //elimina la posibilidad de ingresar datos en el datagridview
            tablaGastos.AllowUserToAddRows = false;
            // elimina el encabezado de las filas
            tablaGastos.RowHeadersVisible = false;
           
            g.ConfigInicial();

            tablaGastos.DataSource = g.TablaGastos;

            g.LeeGastos();

            //int ingresos = Convert.ToInt32(listu.DevuelveIngresos(comboUsuarios.Text));
            //int img = Convert.ToInt32(listu.DevuelveFoto(comboUsuarios.Text));
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Clases.Gastos g1 = new Clases.Gastos();

            string usuario = g1.Usuario;

            g.NuevoGasto(usuario ,txtRubro.Text, txtFecha.Value, txtDescripcion.Text, Convert.ToDouble(txtImporte.Text));
        }

        private void DataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //le digo a la variable fila en que celda estoy parado
            fila = e.RowIndex;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //le digo al boton que si fila es distinto a -1 borre todo el rengon con removeAt y el indice
            if(fila != -1)
            {
                g.TablaGastos.Rows.RemoveAt(fila);

                string NombreArchivo = @"gastos.xml";

                Clases.Persistencia_Gastos t = new Clases.Persistencia_Gastos();
                
                t.TablaGastos.WriteXml(NombreArchivo);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}