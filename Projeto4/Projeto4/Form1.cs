using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Declarando a variável media 
            double media;

            // Variavel Media recebeo valor que foi digitado no textbox
            media = Convert.ToDouble(txtMedia.Text);

            if(media>7.0)
            {
                MessageBox.Show("Aluno aprovado!!", "Média");
            }

        }
    }
}
