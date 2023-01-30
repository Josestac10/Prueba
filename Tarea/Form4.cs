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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnIdentificar_Click(object sender, EventArgs e)
        {
            int lado1 = Convert.ToInt32(this.txtLado1.Text);
            int lado2 = Convert.ToInt32(this.txtLado2.Text);
            int lado3 = Convert.ToInt32(this.txtLado3.Text);

            if ((lado1 == lado2) & (lado2 == lado3))
            {
                MessageBox.Show("Es un triángulo equilátero. Todos los lados son iguales");
            }
            else
            {
                if ((lado1 != lado2) & (lado1 != lado3) & (lado2 != lado3))
                {
                    MessageBox.Show("Es un triángulo escaleno. Ninguno igual");
                }
                else
                {
                    MessageBox.Show("Es un triángulo isósceles. Dos iguales");
                }
            }
        }
    }
}
