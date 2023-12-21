using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Exercício_For_ou_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }

        public void btncalcular_Click(object sender, EventArgs e)
        {

            int numero = Convert.ToInt32(txtnum.Text);
            int fatorial = 1;
            string sequencia = "";

            // Cálculo do fatorial com for
            int i;
            for (i = 1; i <= numero; i++)
            {
                fatorial *= i;
                sequencia += i + " x ";
            }
            sequencia = sequencia.Remove(sequencia.Length - 3);

            label1.Text = $"Fatorial: {sequencia} = {fatorial}";


        }

        public void btnpag2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
        }
    }
}