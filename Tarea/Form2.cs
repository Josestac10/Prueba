using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            string palabras = txtPalabras.Text.Trim();
            MessageBox.Show("Numero de palabras: "+ ContPalabras(palabras));
        }

        private int ContPalabras(string palabras)
        {
            string[] tpalabras = palabras.Split(' ');
            return tpalabras.Length;
        }
    }
}