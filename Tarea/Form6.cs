using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string cad, aux;
            int cont;

            cad = txtFrase.Text;
            aux = "";
            cont = cad.Length - 1;

            while (cont >= 0)
            {
                aux = aux + cad[cont];
                cont = cont - 1;
            }
            MessageBox.Show(aux);
        }
    }
}
