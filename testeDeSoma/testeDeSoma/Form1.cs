using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeDeSoma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int somar( int n1, int n2)
        {
             
            return n1 + n2;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int num1, num2;

            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);
            

            txtNum3.Text = somar(num1, num2).ToString();


        }
    }
}
