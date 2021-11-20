using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Preenche o comboBox com os sabores de pizzas

            cboSabores.Items.Add("Mussarela");
            cboSabores.Items.Add("Palmito");
            cboSabores.Items.Add("Atum");
            cboSabores.Items.Add("Calabresa");

            //seleciona o item da lista que tem índice = 0, o primeiro da lista
            cboSabores.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //seleciona o item da lista que tem índice = 0, o primeiro da lista
            cboSabores.SelectedIndex = 0;
            //coloca o cursor no comboBox
            cboSabores.Focus();

            //Deixa os CheckBox sem seleção
            chkAzeitona.Checked = false;
            chkCebola.Checked = false;

            //deixa o RadioButton rdbSemBorda selecionado
            rdbSemBorda.Checked = true;
        }

        private void pbtnImprimir_Click(object sender, EventArgs e)
        {
            // Declarando as variaveis
            string strSabor;

            //variável para concatenar os textos
            string strPedido = null;

            strSabor = cboSabores.Text;

            if (string.IsNullOrEmpty(cboSabores.Text))
            {
                MessageBox.Show("Selecione um sabor de pizza!", "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSabores.Focus();
                return;

            }
            //estrutura switch para os sabores das pizzas.
            // a variávelo strPedido recebe o texto de strSabor 
            switch (strSabor)
            {
                case "Mussarela":
                    strPedido = "Mussarela";
                    break;
                case "Palmito":
                    strPedido = "Palmito";
                    break;
                case "Atum":
                    strPedido = "Atum";
                    break;
                case "Calabresa":
                    strPedido = "Calabresa";
                    break;
            }
            //neste caso podemos ter os dois selecionados, um ou nenhum.
            //concatena o texto de strPedido com a String definida 
            //verifica se CheckBox está selecionado
            if (chkCebola.Checked)
            {
                //concatena o texto de strPedido com a String definida 
                strPedido = strPedido + " com " + chkCebola.Text;
            }
            if (chkAzeitona.Checked)
            {
                strPedido = strPedido + " com " + chkAzeitona.Text;
            }

            //verifica se RadioButton selecionado
            if (rdbComBorda.Checked)
            {
                //concatena o texto de strPedido com a String definida
                strPedido = strPedido + " com borda recheada";
            }
            else
            {
                strPedido = strPedido + " sem borda";
            }

            // emite mensagem da formação do pedido
            MessageBox.Show(strPedido, "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
