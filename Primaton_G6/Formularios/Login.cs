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
using Primaton_G6.Formularios;

namespace Primaton_G6.Formularios
{

    public partial class Login : Form
    {
        Clases.Persistencia_Usuarios listu = new Clases.Persistencia_Usuarios();

        Clases.Persistencia_Gastos pgasto = new Clases.Persistencia_Gastos();

        Clases.Gastos g = new Clases.Gastos();
      
        public Login()
        {
            InitializeComponent();

            lblMensaje.Text = "";

            lblFoto.Visible = false;

            btnAddgasto.Visible = false;

            lblEliminar.Visible = false;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            listu.LeeUsuarios();

            string contraseña = listu.DevuelvePass(txtNombre.Text);

            string existe = listu.DevuelveNombre(txtNombre.Text);
           
                if (txtNombre.Text == existe)
                {
                    if (contraseña == txtPass.Text)
                    {
                        g.Usuario = txtNombre.Text;

                        lblFoto.Visible = true;

                        btnAddgasto.Visible = true;

                        lblEliminar.Visible = true;

                        lblFoto.ImageIndex = Convert.ToInt32(listu.DevuelveFoto(txtNombre.Text));

                        lblMensaje.Visible = true;

                        lblMensaje.Text = "Hola " + txtNombre.Text + ", " + "\r\n" + "tus ingresos mensuales registrados son: $" + listu.DevuelveIngresos(txtNombre.Text);

//-------------limpio campos, desaparezco el boton ingresar, aparece "otro usuario"----------------------
                        btnCompras.Visible = true;
                        txtNombre.Visible = false;
                        txtPass.Visible = false;
                        btnIngresar.Visible = false;
                        lblUsuario.Visible = false;
                        lblPass.Visible = false;
                        lblNoEstas.Visible = false;
                        lblRegistrar.Visible = false;
                        lblCambio.Visible = true;
                        lblPassInco.Visible = false;
                        lblAvisoUsuario.Visible = false;
                }
                    else
                    {
                         lblPassInco.Visible = true;
                         lblAvisoUsuario.Visible = false;
                         txtPass.Text = "";
                    }
                }
                else
                {
                    lblAvisoUsuario.Visible = true;
                    lblPassInco.Visible = false;
                    lblMensaje.Text = "";
                    lblFoto.Visible = false;
                    btnAddgasto.Visible = false;
                    lblEliminar.Visible = false;
                    txtNombre.Text = "";
                }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            // igual metodo que btn_ingresar pero con la tecla enter para un acceso más rápido
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                listu.LeeUsuarios();

                string contraseña = listu.DevuelvePass(txtNombre.Text);

                string existe = listu.DevuelveNombre(txtNombre.Text);
               
                    if (txtNombre.Text == existe)
                    {
                        if (contraseña == txtPass.Text)
                        {
                            g.Usuario = txtNombre.Text;

                            lblFoto.Visible = true;

                            btnAddgasto.Visible = true;

                            lblEliminar.Visible = true;

                            lblFoto.ImageIndex = Convert.ToInt32(listu.DevuelveFoto(txtNombre.Text));

                            lblMensaje.Visible = true;

                            lblMensaje.Text = "Hola " + txtNombre.Text + ", " + "\r\n" + "tus ingresos mensuales registrados son: $" + listu.DevuelveIngresos(txtNombre.Text);
                         
                        //-------------limpio campos, desaparezco el boton ingresar, aparece "otro usuario"----------------------
                            btnCompras.Visible = true;
                            txtNombre.Visible = false;
                            txtPass.Visible = false;
                            btnIngresar.Visible = false;
                            lblUsuario.Visible = false;
                            lblPass.Visible = false;
                            lblNoEstas.Visible = false;
                            lblRegistrar.Visible = false;
                            lblCambio.Visible = true;
                            lblPassInco.Visible = false;
                            lblAvisoUsuario.Visible = false;
                    }
                        else
                        {
                        lblPassInco.Visible = true;
                        lblAvisoUsuario.Visible = false;
                        txtPass.Text = "";

                    }
                   
                    }
                    else
                    {
                        lblAvisoUsuario.Visible = true;
                        lblPassInco.Visible = false;

                        lblMensaje.Text = "";

                        lblFoto.Visible = false;

                        btnAddgasto.Visible = false;

                        lblEliminar.Visible = false;

                        txtNombre.Text = "";
                    }
                }
        }

        private void lblCambio_MouseClick(object sender, MouseEventArgs e)
        {
            btnCompras.Visible = false;
            txtNombre.Visible = true;
            txtPass.Visible = true;
            btnIngresar.Visible = true;
            lblUsuario.Visible = true;
            lblPass.Visible = true;
            lblNoEstas.Visible = true;
            lblRegistrar.Visible = true;
            lblCambio.Visible = false;
            lblFoto.Visible = false;
            lblMensaje.Visible = false;
            btnAddgasto.Visible = false;
            lblEliminar.Visible = false;
            txtNombre.Text = "";
            txtPass.Text = "";
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            compras compra = new compras();
            compra.Show();
        }

        private void lblEliminar_MouseClick(object sender, MouseEventArgs e)
        {
                DialogResult pregunta;
                pregunta = MessageBox.Show("¿Seguro desea eliminar su usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (pregunta == DialogResult.Yes)
                {
                    listu.LeeUsuarios();

                    pgasto.LeeGastos();

                    listu.EliminaUsuario(txtNombre.Text);

                    pgasto.EliminaGastosUsuario(txtNombre.Text);

                    lblFoto.Visible = false;

                    btnAddgasto.Visible = false;

                    lblEliminar.Visible = false;

                    lblFoto.ImageIndex = 0;

                    lblMensaje.Text = "";

                    btnCompras.Visible = false;
                    txtNombre.Visible = true;
                    txtPass.Visible = true;
                    btnIngresar.Visible = true;
                    lblUsuario.Visible = true;
                    lblPass.Visible = true;
                    lblNoEstas.Visible = true;
                    lblRegistrar.Visible = true;
                    lblCambio.Visible = false;
                    lblFoto.Visible = false;
                    lblMensaje.Visible = false;
                    btnAddgasto.Visible = false;
                    lblEliminar.Visible = false;
                    txtNombre.Text = "";
                    txtPass.Text = "";

                    MessageBox.Show("Usuario eliminado!", "Aviso");
                }
        }

        #region CUESTIONES GRAFICAS

        private void BtnAddgasto_Click(object sender, EventArgs e)
        {
            ControlDeGastos tdi = new ControlDeGastos(g.Usuario);
            tdi.ShowDialog();
        }

        private void lblRegistrar_MouseEnter(object sender, EventArgs e)
        {
            lblRegistrar.ForeColor = Color.Black;
        }

        private void lblRegistrar_MouseLeave(object sender, EventArgs e)
        {
            lblRegistrar.ForeColor = Color.Aquamarine;
        }

        private void lblRegistrar_MouseClick(object sender, MouseEventArgs e)
        {
            SignUp sdi = new SignUp();
            sdi.ShowDialog();

        }

        private void lblEliminar_MouseEnter(object sender, EventArgs e)
        {
            lblEliminar.ForeColor = Color.Black;
        }

        private void lblEliminar_MouseLeave(object sender, EventArgs e)
        {
            lblEliminar.ForeColor = Color.Aquamarine;
        }

       

        private void btnAddgasto_MouseEnter(object sender, EventArgs e)
        {
            btnAddgasto.ForeColor = Color.Black;
        }

        private void btnAddgasto_MouseLeave(object sender, EventArgs e)
        {
            btnAddgasto.ForeColor = Color.White;
        }

        private void btnCompras_MouseEnter(object sender, EventArgs e)
        {
            btnCompras.ForeColor = Color.Black;
        }

        private void btnCompras_MouseLeave(object sender, EventArgs e)
        {
            btnCompras.ForeColor = Color.White;
        }

        private void btnCompras_MouseDown(object sender, MouseEventArgs e)
        {
            btnCompras.BackgroundImage = (Primaton_G6.Properties.Resources.botonMaderaApretado);
            btnCompras.ForeColor = Color.Red;
        }

        private void btnCompras_MouseUp(object sender, MouseEventArgs e)
        {
            btnCompras.BackgroundImage = (Primaton_G6.Properties.Resources.botonMadera);
        }

        private void btnAddgasto_MouseDown(object sender, MouseEventArgs e)
        {
            btnAddgasto.BackgroundImage = (Primaton_G6.Properties.Resources.botonMaderaApretado);
            btnAddgasto.ForeColor = Color.Red;
        }

        private void btnAddgasto_MouseUp(object sender, MouseEventArgs e)
        {
            btnAddgasto.BackgroundImage = (Primaton_G6.Properties.Resources.botonMadera);

        }

        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.ForeColor = Color.Black;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.ForeColor = Color.White;
        }

        private void btnIngresar_MouseDown(object sender, MouseEventArgs e)
        {
            btnIngresar.BackgroundImage = (Primaton_G6.Properties.Resources.botonMaderaApretado);
            btnIngresar.ForeColor = Color.Red;
        }

        private void btnIngresar_MouseUp(object sender, MouseEventArgs e)
        {
            btnIngresar.BackgroundImage = (Primaton_G6.Properties.Resources.botonMadera);
        }

        private void lblCambio_MouseEnter(object sender, EventArgs e)
        {
            lblCambio.ForeColor = Color.Black;
        }

        private void lblCambio_MouseLeave(object sender, EventArgs e)
        {
            lblCambio.ForeColor = Color.Aquamarine;
        }


        #endregion
    }
}


//public void ComboTabla()
//{
//    listu.LeeUsuarios();

//    comboUsuarios.DataSource = listu.TablaUsuarios;
//    comboUsuarios.DisplayMember = "Nombre";
//    comboUsuarios.ValueMember = "Nombre";
//}