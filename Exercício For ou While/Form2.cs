using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_For_ou_While
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public void btncalculowhile_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtnum.Text);
            int soma = 0;
            int i = 1;

            // Cálculo da soma com while
            while (i <= numero)
            {
                soma += i;
                i++;
            }

            label1.Text = $"Soma: {soma}";
        }

        public void btnPag1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
