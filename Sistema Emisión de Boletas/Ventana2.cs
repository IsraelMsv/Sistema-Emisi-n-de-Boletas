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
    public partial class Seleccion : Form
    {
        public int contagua;
        public Seleccion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login VentanaLogin = new Login();
            VentanaLogin.Show();
        }

        private void nComprar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string seleccion = " ";

            if (CEBGaseosas.Checked == true) { cont++; }
            if (CEBAgua.Checked == true) {


                
                
                
                cont++; }
            if (CEBInfusión.Checked == true) { cont++; }
            if (CEBCAFE.Checked == true) { cont++; }

           

           // MessageBox.Show("Se ha seleccionado : " + cont +
           //     "  cursos y el método de pago es : " + seleccion);




            this.Hide();
            Pago VentanaPago = new Pago();
            VentanaPago.Show();

        }
        
        private void Ventana2_Load(object sender, EventArgs e)
        {

        }
    }
    }
 
