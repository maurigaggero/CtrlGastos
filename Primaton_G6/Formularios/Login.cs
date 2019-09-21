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

namespace Primaton_G6.Formularios
{
    public partial class Login : Form
    {
        Clases.Usuario usuario = new Clases.Usuario();

        Clases.Persistencia_Usuarios listu = new Clases.Persistencia_Usuarios();

        public Login()
        {
            InitializeComponent();

            listu.ConfigInicial();

            ComboTabla();

            lblMensaje.Text = "";
        }

        private void ComboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFoto.ImageIndex = Convert.ToInt32(listu.DevuelveFoto(comboUsuarios.Text));

            lblMensaje.Text = "Hola " + comboUsuarios.Text + ", " + "\r\n";
            lblMensaje.Text += "Tus ingresos mensuales registrados son: $" + listu.DevuelveIngresos(comboUsuarios.Text);
        }

        public void ComboTabla()
        {
            listu.LeeUsuarios();

            comboUsuarios.DataSource = listu.TablaUsuarios;
            comboUsuarios.DisplayMember = "Nombre";
            comboUsuarios.ValueMember = "Nombre";
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

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            SignUp sdi = new SignUp();
            sdi.ShowDialog();

            ComboTabla();
        }
    }
}