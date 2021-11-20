using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto2
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void btnInteiros_Click(object sender, EventArgs e)
        {
            /*Declarando das Variaveis*/
            int a, b, soma;

            /*entrada de Dados*/

            a = Int32.Parse(txtA.Text); // converte a variavel a em um texto;
            b = Int32.Parse(txtB.Text);

            /*Processamento*/
            soma = a + b;

            /*saída de dados*/
            txtResultado.Text = soma.ToString();
            
        }
        
        private void btnReais_Click(object sender, EventArgs e)
        {
            double a, b, soma;

            a = Convert.ToDouble(txtA.Text);
            b = double.Parse(txtB.Text);

            soma = a + b;

            txtResultado.Text = soma.ToString();
        }
    }
}
