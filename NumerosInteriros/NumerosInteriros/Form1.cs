using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosInteriros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            // Limpa o ListBox

            lstNumeros.Items.Clear();

            //Declaração da variável controladora do laço 

            int i;

            for(i = 0; i <= 100; i++)
            {
                // Acrescenta o valor da variável i no ListBox
                lstNumeros.Items.Add(i);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // limpa o listBox
            lstNumeros.Items.Clear();

            // declara e inicializa a variavel controladora do laço

            int i = 1;
            while (i <= 100)
            {
                // acrescenta o valor da variavel i no ListBox
                lstNumeros.Items.Add(i);

                // incrementa a variavel controladora
                i++;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            // Limpa o ListBox
            lstNumeros.Items.Clear();

            //Declara a variavel e inicializa 

            int i = 1;

            do
            {
                //acrescenta o valor da variavel i no ListBox 
                lstNumeros.Items.Add(i);

                // incrementa a variavel controladora
                i++;
            }
            while (i <= 100);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();
        }
    }
}
