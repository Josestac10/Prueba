using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form5 : Form
    {

        Random ran = new Random();

        int numero = 0;
        int contador = 0;

        public Form5()
        {
            InitializeComponent();

            cargaPregunta();
        }

        private void btnAdivinar_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtNumero.Text);

            contador += 1;

            lblAd.Text = "Adivinaste al intento numero " + contador;

            if (i == numero)
            {
                MessageBox.Show("¡Adivinaste!");
                cargaPregunta();
                txtNumero.Text = "";
                contador = 0;
            }
            else if (i < numero)
            {
                MessageBox.Show("Mas grande");
            }
            else 
            {
                MessageBox.Show("Mas pequeño");
            }    
        }

        private void cargaPregunta()
        {
            numero = ran.Next(1, 11);

            lblPregunta.Text = "Estoy pensando en un numero del 1 al 10";
        }

    }
}
