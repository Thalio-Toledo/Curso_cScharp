using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiorNumero
{
    public partial class Form1 : Form
    {

        //Declaração e implementação da função

            int verificaMaior(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        // Declaração e implementação do procedimento para limpar os controles
        // o tipo de retorno é void ou seja não tem retorno

        void limparControles()
        {
            //limpa os conteúdos dos controles 
            txtA.Clear();
            txtB.Clear();
            txtMaior.Clear();
            txtA.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Declaração de Variaveis 
            int a, b;

            // entrada de dados para as variaveis 
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);

            // chamando a função VerificaMaior 
            // e passando os argumentos para os paramentros num1 e num2 
            // textBox txtMaior recebe o retorno da função 

            txtMaior.Text = verificaMaior(a, b).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // chamando a função limparControles
            limparControles();  
        }
    }
}
