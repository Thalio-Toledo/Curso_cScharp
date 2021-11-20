using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            int x, y; // declaração das variáveis 
            x = Convert.ToInt32(txtX.Text); // converte o valor digitado no textbox para int

            y = ++x; // incremento pré-fixado 

            MessageBox.Show("y = " + y + "X = " + x, "incremento pré-fixado");
            
        }

        private void btnPos_Click(object sender, EventArgs e)
        {

            int x, y; // declaração das variáveis 
            x = Convert.ToInt32(txtX.Text); // converte o valor digitado no textbox para int

            y = x++; // incremento pós-fixado 

            MessageBox.Show("y = " + y + "X = " + x, "incremento pós-fixado");

        }

    }
}

