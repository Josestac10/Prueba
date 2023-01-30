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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            decimal v1 = this.nudNum1.Value;
            decimal v2 = this.nudNum2.Value;

            decimal resultado = v1 + v2;

            this.txtResultado.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            decimal v1 = this.nudNum1.Value;
            decimal v2 = this.nudNum2.Value;

            decimal resultado = v1 - v2;

            this.txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            decimal v1 = this.nudNum1.Value;
            decimal v2 = this.nudNum2.Value;

            decimal resultado = v1 * v2;

            this.txtResultado.Text = resultado.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            decimal v1 = this.nudNum1.Value;
            decimal v2 = this.nudNum2.Value;

            if (v2 == 0)
            {
                MessageBox.Show("No puede ser 0");
            }
            else
            {
                decimal resultado = v1 / v2;

                this.txtResultado.Text = resultado.ToString();
            }            
        }
    }
}
