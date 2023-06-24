using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Emisión_de_Boletas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "URP2023" && txtPassword.Text == "2023")
            {// MessageBox.Show("Se ha iniciado sesión...");
                this.Hide();
                Seleccion nVentana = new Seleccion();
                nVentana.Show();
            }
            else
            {
                MessageBox.Show("Error!!!!  Datos incorrectos, intente de nuevo...");
                txtID.Clear(); txtPassword.Clear(); txtID.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
