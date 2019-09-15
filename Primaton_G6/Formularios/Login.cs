using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Primaton_G6
{
    public partial class Login : Form
    {
        Clases.Usuario usuario = new Clases.Usuario();

        Clases.ListaUsuarios listu = new Clases.ListaUsuarios();

        public Login()
        {
            InitializeComponent();

            listu.ConfigInicial();

            listu.LeeUsuarios();

            comboUsuarios.DataSource = listu.TablaUsuarios;
            comboUsuarios.DisplayMember = "Nombre";
            comboUsuarios.ValueMember = "Nombre";

            lblClave.Text = "";

        }

        private void ComboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblClave.Text = "Hola " + comboUsuarios.Text + ", tus ingresos registrados son:";
        }

        private void BtnRegistro_CheckedChanged(object sender, EventArgs e)
        {
            panel.Visible = true;
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {

            listu.TablaUsuarios.Rows.Add();

            listu.AltaUsuarios(txtNombre.Text, Convert.ToInt32(txtIngresos.Text));

            LimpiarCampos();
        }

        private void LimpiarCampos() // Llena con string vacio los texbox
        {
            txtNombre.Text = "";
            txtIngresos.Text = "";
        }

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            ControlDeGastos pdi = new ControlDeGastos();
            pdi.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            listu.EliminaUsuario(comboUsuarios.Text);
        }
    }
}
