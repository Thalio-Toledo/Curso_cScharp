using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTotal.Clear(); // Limpa o conteudo do text box
            txtX.Clear();
            txtY.Clear();
            txtX.Focus(); // Coloca o foco do cursor no Txtx

            rdbSomar.Checked = true; // Deixa selecionada a opção somar
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // declaração de variaveis

            double x, y, total;

            // verifica se o que foi digitado em txtx é numero e tabem faz a validação se o txtx está vazio.

            if (double.TryParse(txtX.Text, out x) == false)
            {
                // Adiciona o botão Ok e o icone de informação no messageBox
                MessageBox.Show("Informe um valor Valido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtX.Clear(); // Limpa o texto
                txtX.Focus(); // Coloca o foco do cursor no textBox
                return; // Sai da sub-Rotina 
            }

            if (double.TryParse(txtY.Text, out y) == false)
            {
                // Adiciona o botão Ok e o icone de informação no messageBox
                MessageBox.Show("Informe um valor Valido", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtY.Clear(); // Limpa o texto
                txtY.Focus(); // Coloca o foco do cursor no textBox
                return; // Sai da sub-Rotina 
            }

            // Processamento
            // Testa na estrutura condicional qual RadioButton está selecionado

            if (rdbSomar.Checked == true)
            {
                total = x + y;
            }

            else if (rdbSubtrair.Checked)
            {
                total = x - y;

            }

            else if (rdbMultiplicar.Checked)
            {
                total = x * y;

            }

            else
            {
                if (y == 0)
                {


                    txtTotal.Text = "Divisão por Zero";
                    return;
                }
                total = x / y;
            }

            // apresenta a saida de dados convertendo para string

            txtTotal.Text = total.ToString();
        }
    }
}

