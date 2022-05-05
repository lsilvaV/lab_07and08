using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_07.LabCalculos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            Lab07.TelaPrincipal maior = new Lab07.TelaPrincipal();
            maior.Show();
        }

        private void btnFrete_Click(object sender, EventArgs e)
        {
            Lab08.TelaPrincipal frete = new Lab08.TelaPrincipal();
            frete.Show();
        }
    }
}
