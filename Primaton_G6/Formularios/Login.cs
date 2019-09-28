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
        Clases.Persistencia_Usuarios listu = new Clases.Persistencia_Usuarios();

        Clases.Gastos g = new Clases.Gastos();

        public Login()
        {
            InitializeComponent();

            listu.ConfigInicial();

            listu.LeeUsuarios();

            lblMensaje.Text = "";

            lblFoto.Visible = false;

            btnAddgasto.Visible = false;

            btnEliminar.Visible = false;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //listu.LeeUsuarios();

            string existe = listu.DevuelveNombre(txtNombre.Text);
            if (txtNombre.Text == existe)
            {
                g.Usuario = txtNombre.Text;

                lblFoto.Visible = true;

                btnAddgasto.Visible = true;

                btnEliminar.Visible = true;

                lblFoto.ImageIndex = Convert.ToInt32(listu.DevuelveFoto(txtNombre.Text));

                lblMensaje.Text = "Hola " + txtNombre.Text + ", " + "\r\n";
                lblMensaje.Text += "Tus ingresos mensuales registrados son: $" + listu.DevuelveIngresos(txtNombre.Text);
            }
            else
            {
                MessageBox.Show("El usuario no existe");

                lblMensaje.Text = "";

                lblFoto.Visible = false;

                btnAddgasto.Visible = false;

                btnEliminar.Visible = false;
            }
        }

        private void BtnAddgasto_Click(object sender, EventArgs e)
        {
            ControlDeGastos tdi = new ControlDeGastos(g.Usuario);
            tdi.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            listu.LeeUsuarios();

            listu.EliminaUsuario(txtNombre.Text);

            lblFoto.Visible = false;

            btnAddgasto.Visible = false;

            btnEliminar.Visible = false;

            lblFoto.ImageIndex = 0;

            lblMensaje.Text = "";

            //borra por indice
            //listu.EliminaUsuario(comboUsuarios.SelectedIndex);
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            SignUp sdi = new SignUp();
            sdi.ShowDialog();
        }
    }
}

//public void ComboTabla()
//{
//    listu.LeeUsuarios();

//    comboUsuarios.DataSource = listu.TablaUsuarios;
//    comboUsuarios.DisplayMember = "Nombre";
//    comboUsuarios.ValueMember = "Nombre";
//}