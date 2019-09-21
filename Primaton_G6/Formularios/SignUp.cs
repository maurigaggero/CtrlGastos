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
    public partial class SignUp : Form
    {

        Clases.Usuario usuario = new Clases.Usuario();

        Clases.Persistencia_Usuarios listu = new Clases.Persistencia_Usuarios();

        int img = 0;

        public SignUp()
        {
            InitializeComponent();

            listu.ConfigInicial();

            listu.LeeUsuarios();

            lblFoto2.ImageIndex = img;
        }

        private void LimpiarCampos() // Llena con string vacio los texbox
        {
            txtNombre.Text = "";
            txtIngresos.Text = "";
        }

        private void BtnRegistrarme_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "" || txtIngresos.Text == "")
            {
                MessageBox.Show("Campo obligatorio vacío");
            }
            else
            {
                listu.AltaUsuarios(txtNombre.Text, Convert.ToInt32(txtIngresos.Text), img);
            }

            LimpiarCampos();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
    }
}

//public void Imagenes()
//{
//    listaImg.View = View.SmallIcon;
//    listaImg.SmallImageList = imageList;

//    for (int j = 0; j < this.imageList.Images.Count; j++)
//    {
//        ListViewItem item = new ListViewItem();
//        item.ImageIndex = j;
//        this.listaImg.Items.Add(item);
//    }
//}