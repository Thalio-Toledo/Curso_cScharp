using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDiaSemana.ResetText();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int dia;

            dia = Convert.ToInt32(txtDia.Text);

            switch (dia)
            {
                case 1:
                    lblDiaSemana.Text = "Domingo";
                    break;
                case 2:
                    lblDiaSemana.Text = "Segunda";
                    break;

                case 3:
                    lblDiaSemana.Text = "Terça";
                    break;

                case 4:
                    lblDiaSemana.Text = "Quarta";
                    break;

                case 5:
                    lblDiaSemana.Text = "Quinta";
                    break;

                case 6:
                    lblDiaSemana.Text = "Sexta";
                    break;

                case 7:
                    lblDiaSemana.Text = "Sábado";
                    break;

                default:
                    lblDiaSemana.Text = "Dia inválido";
                    break;



            }
        }
    }
}
