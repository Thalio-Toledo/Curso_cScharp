using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParametrosValorRef
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        // implementação das sub-rotinas

         void PorValor(double varA, double varB)
        {
            // altera o valor das variaveis locais que são passadas por valor
            // não altera os valores das variaveis originais 
            // essas alterações são validas somente dentro deste escopo 
            varA = varA * 2;
            varB = varB * 5;
             
        }

        void porReferencia( ref double varA, ref double VarB)
        {
            // altera o valor das Variáveis que são passadas por refencia 
            // altera os valores das variáveis originais 

            varA = varA * 2;
            VarB = VarB * 5;
        }

        void limparControles()
        {
            // limpar os textos dos controles

            txtResA.Clear();
            txtResB.Clear();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            // declaração das variaveis originais 
            double varA, varB;

            // entrada de dados 

            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);
            

            // chama o procedimento porValor passando os paramentros pro valor 
            PorValor(varA, varB);
            // chama a função limparControles 
            limparControles();

            //saída de dados para verificar que não houve alteração no valor da variavel original 
            // os valores das variaveis não foram alterados no procedimento
            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            // declaração das variaveis originais 
            double varA, varB;
            // entrada de Dados 
            varA = Convert.ToDouble(txtVarA.Text);
            varB = Convert.ToDouble(txtVarB.Text);

            // chama o procedimento porReferencia passando os parametros por referencia 
            porReferencia(ref varA, ref varB);

            // chama a função limparControles()
            limparControles();

            // Saída de Dados para verificar a alteração do valor original das variaveis 

            txtResA.Text = varA.ToString();
            txtResB.Text = varB.ToString();

        }
    }
}
