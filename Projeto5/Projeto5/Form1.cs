using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //variaveis
            double nota1, nota2, nota3, media;

            // entrada de dados

            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            nota3 = Convert.ToDouble(txtNota3.Text);

            // Processamento

            media = (nota1 + nota2 + nota3) / 3;




            lblMedia.Text = Convert.ToString(media);

            //lblMedia.Text = media.ToString();

            if (media > 7.0)
            {
                lblSituação.Text = "Aluno Aprovado!";

            }
            else
            {
                lblSituação.Text = "Aluno Reprovado!";

            }


        }

        private void lblSituação_Click(object sender, EventArgs e)
        {

        }
    }
}
