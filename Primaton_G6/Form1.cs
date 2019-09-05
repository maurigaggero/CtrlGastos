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
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }


        //---------------------BOTON 1-------------------------------
        private void btn1_Click(object sender, EventArgs e)
        {
       
            btn1.Visible = false;
            pb1.Visible = true;
            btn2.Visible = true;

            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF(*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pb1.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //---------------------BOTON 2-------------------------------
        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Visible = false;
            pb2.Visible = true;
            btn3.Visible = true;

            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF(*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pb2.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------BOTON 3-------------------------------
        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ULTIMO USUARIO PERMITIDO PARA ESTA VERSION DEMO");
            btn3.Visible = false;
            pb3.Visible = true;
            

            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF(*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pb3.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //---------------------CAMBIO DE FORMULARIO USUARIO 1-------------------------------
        private void pb1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal vp = new VentanaPrincipal();
            vp.Show();
            this.Hide();
        }
        
        //---------------------CAMBIO DE FORMULARIO USUARIO 2-------------------------------
        private void pb2_Click(object sender, EventArgs e)
        {
            VentanaPrincipal vp = new VentanaPrincipal();
            vp.Show();
            this.Hide();
        }

        //---------------------CAMBIO DE FORMULARIO USUARIO 3-------------------------------
        private void pb3_Click(object sender, EventArgs e)
        {
            VentanaPrincipal vp = new VentanaPrincipal();
            vp.Show();
            this.Hide();
        }
    }
}
