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
    public partial class Agua : Form
    {
        public int contagua;
        public Agua()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seleccion VentanaSelección = new Seleccion();
            VentanaSelección.contagua = contagua;
            VentanaSelección.Show();
        }
    }
}
