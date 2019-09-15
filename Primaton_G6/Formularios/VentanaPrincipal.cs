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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            ControlDeGastos control = new ControlDeGastos();
            control.Show();
            this.Hide();
        }
    }
}
