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

        Clases.Persistencia_Gastos pgasto = new Clases.Persistencia_Gastos();

        public Login()
        {
            InitializeComponent();

            listu.ConfigInicial();

            ComboTabla();

            lblMensaje.Text = "";

            lblFoto.Visible = false;

            btnIngreso.Visible = false;

            btnEliminar.Visible = false;
        }

        private void BtnSelecc_Click(object sender, EventArgs e)
        {
            lblFoto.Visible = true;

            btnIngreso.Visible = true;

            btnEliminar.Visible = true;

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

            if (comboUsuarios.Text != "")
            {
                string nombre = comboUsuarios.Text;
                int ingresos = Convert.ToInt32(listu.DevuelveIngresos(comboUsuarios.Text));
                int img = Convert.ToInt32(listu.DevuelveFoto(comboUsuarios.Text));

                pgasto.ArmaTabla(nombre, ingresos, img);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            listu.EliminaUsuario(comboUsuarios.Text);
            //listu.EliminaUsuario(comboUsuarios.SelectedIndex);
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            SignUp sdi = new SignUp();
            sdi.ShowDialog();
        }
    }
}