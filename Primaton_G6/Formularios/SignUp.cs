﻿using System;
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
    public partial class SignUp : Form
    {
       
        Clases.Usuario usuario = new Clases.Usuario();

        Clases.Persistencia_Usuarios listu = new Clases.Persistencia_Usuarios();

        int img = 0;

        public SignUp()
        {
            InitializeComponent();

            listu.LeeUsuarios();

            lblFoto2.ImageIndex = img;
        }

        private void LimpiarCampos() // Llena con string vacio los texbox
        {
            txtNombre.Text = "Nombre de usuario";
            txtIngresos.Text = "Ingresos mensuales en $";
            txtDNI.Text = "Numero de documento";
            txtPass.Text = "Password";
        }

        private void BtnRegistrarme_Click(object sender, EventArgs e)
        {
            if (listu.TablaUsuarios.Columns.Count == 5)
            {
                listu.AltaUsuarios(txtDNI.Text, txtNombre.Text, txtPass.Text, Convert.ToInt32(txtIngresos.Text), img);
            }
            else
            {
                listu.ConfigInicial();
                listu.AltaUsuarios(txtDNI.Text, txtNombre.Text, txtPass.Text, Convert.ToInt32(txtIngresos.Text), img);
            }
            this.Close();

            //LimpiarCampos();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region imagenes
        private void ImgBlanco_Click(object sender, EventArgs e)
        {
            img = 0;
            lblFoto2.ImageIndex = img;
        }

        private void ImgChanchito_Click(object sender, EventArgs e)
        {
            img = 1;
            lblFoto2.ImageIndex = img;
        }

        private void ImgPez_Click(object sender, EventArgs e)
        {
            img = 2;
            lblFoto2.ImageIndex = img;
        }

        private void ImgJirafa_Click(object sender, EventArgs e)
        {
            img = 3;
            lblFoto2.ImageIndex = img;
        }

        private void ImgCaballo_Click(object sender, EventArgs e)
        {
            img = 4;
            lblFoto2.ImageIndex = img;
        }

        private void ImgCiervo_Click(object sender, EventArgs e)
        {
            img = 5;
            lblFoto2.ImageIndex = img;
        }

        private void ImgPanda_Click(object sender, EventArgs e)
        {
            img = 6;
            lblFoto2.ImageIndex = img;
        }

        private void ImgAguila_Click(object sender, EventArgs e)
        {
            img = 7;
            lblFoto2.ImageIndex = img;
        }

        private void ImgPerro_Click(object sender, EventArgs e)
        {
            img = 8;
            lblFoto2.ImageIndex = img;
        }

        private void ImgGato_Click(object sender, EventArgs e)
        {
            img = 9;
            lblFoto2.ImageIndex = img;
        }

        private void ImgLeon_Click(object sender, EventArgs e)
        {
            img = 10;
            lblFoto2.ImageIndex = img;
        }

        private void ImgArdilla_Click(object sender, EventArgs e)
        {
            img = 11;
            lblFoto2.ImageIndex = img;
        }
        #endregion

        #region Efectos botones

        private void btnRegistrarme_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrarme.ForeColor = Color.Black;
        }

        private void btnRegistrarme_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarme.ForeColor = Color.White;
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.ForeColor = Color.Black;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.ForeColor = Color.White;
        }

        private void btnRegistrarme_MouseDown(object sender, MouseEventArgs e)
        {
            btnRegistrarme.BackgroundImage = (Primaton_G6.Properties.Resources.botonMaderaApretado);
        }

        private void btnRegistrarme_MouseUp(object sender, MouseEventArgs e)
        {
            btnRegistrarme.BackgroundImage = (Primaton_G6.Properties.Resources.botonMadera);
        }

        private void btnBack_MouseDown(object sender, MouseEventArgs e)
        {
            btnBack.BackgroundImage = (Primaton_G6.Properties.Resources.botonMaderaApretado);
        }

        private void btnBack_MouseUp(object sender, MouseEventArgs e)
        {
            btnBack.BackgroundImage = (Primaton_G6.Properties.Resources.botonMadera);
        }
        #endregion

        #region VALIDACION DE DNI E INGRESOS

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                    lblDni.Visible = false;
                    panelDni.BackColor = Color.Transparent;

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    lblDni.Visible = false;
                    panelDni.BackColor = Color.Transparent;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {

                    e.Handled = false;
                    lblDni.Visible = false;
                    panelDni.BackColor = Color.Transparent;
                }
                else
                {
                    e.Handled = true;
                    lblDni.Visible = true;
                    panelDni.BackColor = Color.Red;
                }
        }

        private void txtIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                LblIngresos.Visible = false;
                panelIngresos.BackColor = Color.Transparent;

            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                LblIngresos.Visible = false;
                panelIngresos.BackColor = Color.Transparent;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
                LblIngresos.Visible = false;
                panelIngresos.BackColor = Color.Transparent;
            }
            else
            {
                e.Handled = true;
                LblIngresos.Visible = true;
                panelIngresos.BackColor = Color.Red;
            }

        }
        #endregion


        #region EFECTOS DE TEXTBOX (ENTER Y LEAVE)
        private void txtDNI_Enter(object sender, EventArgs e)
        {
            if (txtDNI.Text == "Numero de documento")
            {
                txtDNI.ForeColor = Color.Black;
                txtDNI.Text = "";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.ForeColor = Color.Black;
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre de usuario")
            {
                txtNombre.ForeColor = Color.Black;
                txtNombre.Text = "";
                //txtNombre.CharacterCasing = CharacterCasing.Lower;
            }
        }

        private void txtIngresos_Enter(object sender, EventArgs e)
        {
            if (txtIngresos.Text == "Ingresos mensuales en $")
            {
                txtIngresos.ForeColor = Color.Black;
                txtIngresos.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.CharacterCasing = CharacterCasing.Normal;
                txtNombre.Text = "Nombre de usuario";
                txtNombre.ForeColor = Color.Silver;
            }
         
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Silver;
            }
        
        }

        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
            {
                txtDNI.Text = "Numero de documento";
                txtDNI.ForeColor = Color.Silver;
            }
           
        }

        private void txtIngresos_Leave(object sender, EventArgs e)
        {
            if (txtIngresos.Text == "")
            {
                txtIngresos.Text = "Ingresos mensuales en $";
                txtIngresos.ForeColor = Color.Silver;
            }
           
        }
        #endregion

        #region Habilitacion del boton registrar
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNombre.Text == "Nombre de usuario"|| txtPass.Text == "" 
                || txtPass.Text == "Password" || txtDNI.Text == "" || txtDNI.Text == "Numero de documento"
                || txtIngresos.Text == "" || txtIngresos.Text == "Ingresos mensuales en $"||panelDni.BackColor==Color.Red||panelIngresos.BackColor==Color.Red)
            {
                btnRegistrarme.Enabled = false;
            }
            else          
            {
                btnRegistrarme.Enabled = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNombre.Text == "Nombre de usuario" || txtPass.Text == ""
                || txtPass.Text == "Password" || txtDNI.Text == "" || txtDNI.Text == "Numero de documento"
                || txtIngresos.Text == "" || txtIngresos.Text == "Ingresos mensuales en $" || panelDni.BackColor == Color.Red || panelIngresos.BackColor == Color.Red)
            {
                btnRegistrarme.Enabled = false;
            }
            else
            {
                btnRegistrarme.Enabled = true;
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNombre.Text == "Nombre de usuario" || txtPass.Text == ""
                || txtPass.Text == "Password" || txtDNI.Text == "" || txtDNI.Text == "Numero de documento"
                || txtIngresos.Text == "" || txtIngresos.Text == "Ingresos mensuales en $" || panelDni.BackColor == Color.Red || panelIngresos.BackColor == Color.Red)
            {
                btnRegistrarme.Enabled = false;
            }
            else
            {
                btnRegistrarme.Enabled = true;
            }
        }

        private void txtIngresos_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNombre.Text == "Nombre de usuario" || txtPass.Text == ""
                || txtPass.Text == "Password" || txtDNI.Text == "" || txtDNI.Text == "Numero de documento"
                || txtIngresos.Text == "" || txtIngresos.Text == "Ingresos mensuales en $" || panelDni.BackColor == Color.Red || panelIngresos.BackColor == Color.Red)
            {
                btnRegistrarme.Enabled = false;
            }
            else
            {
                btnRegistrarme.Enabled = true;
            }
        }
        #endregion

       
    }

}

