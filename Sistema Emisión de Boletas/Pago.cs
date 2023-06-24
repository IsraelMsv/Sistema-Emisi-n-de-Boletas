using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Emisión_de_Boletas
{
    public partial class Pago : Form
    {
        String salida = " ";
        int hh = 0;
        int mm;
        int ss;
        int dia;
        int mes;
        int anno;
        public Pago()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seleccion VentanaSelección = new Seleccion();
            VentanaSelección.Show();
        }

        private void Pago_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            anno = DateTime.Now.Year;
            mes = DateTime.Now.Month;
            dia = DateTime.Now.Day;
            salida = "Fecha de emisión: " + dia + "/" + mes + "/" + anno;

            hh = DateTime.Now.Hour; mm = mm = DateTime.Now.Minute; ss = DateTime.Now.Second;

            salida += "   Hora :  " + hh + ":" + mm + ":" + ss;

            txtResultadoF.Text = salida;
        }
    }
}
