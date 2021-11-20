using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MostrarPatas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboAnimais.Items.Add("Cavalo");
            cboAnimais.Items.Add("Cachorro");
            cboAnimais.Items.Add("Gato");
            cboAnimais.Items.Add("Centopeia");
            cboAnimais.Items.Add("Cobra");
            cboAnimais.Items.Add("Pássaro");
        }

        private void bntPatas_Click(object sender, EventArgs e)
        {
            /* Declaração de variavel
            string animal = cboAnimais.Text;

            // estrutura switch

            switch (animal)
            {
                case "Cavalo":
                case "Gato":
                case "Cachorro":
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Centopeia":
                    MessageBox.Show("Este animal tem 100 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Cobra":
                    MessageBox.Show("Este animal não tem patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Pássaro":
                    MessageBox.Show("Este animal tem 2 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:
                    MessageBox.Show("Selecione um Animal", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            */
            //declara variável
            String strAnimal;

            //variável recebe o texto do item do ComboBox Selecionado
            strAnimal = cboAnimais.Text;

            //instrução de seleção
            switch (strAnimal)
            {
                case "Cachorro":

                    //carrega o arquivo que está na pasta Debug
                    pctAnimais.Load("Cachorro.jpg");
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cavalo":
                    pctAnimais.Load("Cavalo.jpg");
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Centopeia":
                    pctAnimais.Load("Centopeia.jpg");
                    MessageBox.Show("Este animal tem 100 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cobra":
                    pctAnimais.Load("Cobra.jpg");
                    MessageBox.Show("Este animal não tem patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Gato":
                    pctAnimais.Load("Gato.jpg");
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Pássaro":
                    pctAnimais.Load("Passaro.jpg");
                    MessageBox.Show("Este animal tem 2 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    //limpa o PictureBox
                    pctAnimais.ResetText();
                    MessageBox.Show("Selecione um Animal", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }


        }
        }
    }

