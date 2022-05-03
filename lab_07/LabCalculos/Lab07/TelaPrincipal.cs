using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_07.LabCalculos.Lab07
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        public void MaiorDeTres()
        {
            int valor1 = Convert.ToInt32(nudValor1.Text);
            int valor2 = Convert.ToInt32(nudValor2.Text);
            int valor3 = Convert.ToInt32(nudValor3.Text);

            if (valor1 > valor2 && valor1 > valor3)
            {
                lblResultado.Text = "O maior valor é: " + valor1.ToString();
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                lblResultado.Text = "O maior valor é: " + valor2.ToString();
            }
            else if(valor3 > valor1 && valor3 > valor1)
            {
                lblResultado.Text = "O maior valor é: " + valor3.ToString();

            }else if (valor1 == valor2 & valor2 == valor3)
            {
                lblResultado.Text = "Os valores são iguais";
            }
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MaiorDeTres();
        }
    }
}
