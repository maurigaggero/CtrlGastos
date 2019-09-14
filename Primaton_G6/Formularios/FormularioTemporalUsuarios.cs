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
    public partial class FormularioTemporalUsuarios : Form
    {


        public FormularioTemporalUsuarios()
        {
            InitializeComponent();

            DataTable TablaUsuarios = new DataTable();
            foreach (DataRow dat in TablaUsuarios.Rows)
            {
                comboUsuarios.Items.Add(dat[0]);
            }

            

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Clases.ListaUsuarios.AltaUsuario(nombre.Text, Convert.ToInt32(Ingresos.Text));
        }
    }
}
