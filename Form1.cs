using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Operaciones_Basicas
{
    public partial class Form1 : Form
    {
        private float Num1;
        private float Num2;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(keyPressEnter);
        }
        private void bttSuma_Click(object sender, EventArgs e)
        {
            Nums();  
            float suma = SUMA.SumaClass.suma(Num1, Num2);
            lblSigno.Text = "+";
            lblResultado.Text = $"= {suma}"; 
        }

        private void bttResta_Click(object sender, EventArgs e)
        {
            Nums();

            float resta = RESTA.RestarClass.Resta(Num1, Num2);
            lblSigno.Text = "-";
            lblResultado.Text = $"= {resta}";
        }

        private void bttMultiplicacion_Click(object sender, EventArgs e)
        {
            Nums();
            float multiplicacion = MULTIPLICAR.MultiplicarClass.multiplicacion(Num1, Num2);
            lblSigno.Text = "x";
            lblResultado.Text = $"= {multiplicacion}";
        }

        private void bttDivision_Click(object sender, EventArgs e)
        {
            Nums();
            float division = DIVISION.DividirClass.Division(Num1, Num2);
            lblSigno.Text = "/";
            lblResultado.Text = $"= {division}";
        }

        private void Nums()
        {
            if (txbNum1.Text == "" || txbNum2.Text == "")
            {
                MessageBox.Show("Ingrese un número");
            }
            else
            {
                Num1 = float.Parse(txbNum1.Text);
                Num2 = float.Parse(txbNum2.Text);
            }
        }

        private void keyPressNums(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.");
            }
        }

        private void keyPressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}"); 
            }
        }   
    }
}
