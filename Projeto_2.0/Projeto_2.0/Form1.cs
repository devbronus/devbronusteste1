using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Convert.ToDouble(textBox1.Text);
            valor2 = Convert.ToDouble(textBox2.Text);

            resultado = valor1 + valor2;

            richTextBox1.Text = "A soma dos número é: \r" + resultado.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Convert.ToDouble(textBox1.Text);
            valor2 = Convert.ToDouble(textBox2.Text);

            resultado = valor1 - valor2;

            richTextBox1.Text = "A subtração dos números é: \r" + resultado.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Convert.ToDouble(textBox1.Text);
            valor2 = Convert.ToDouble(textBox2.Text);

            resultado = valor1 * valor2;

            richTextBox1.Text = "A multiplicação dos números é: \r" + resultado.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Convert.ToDouble(textBox1.Text);
            valor2 = Convert.ToDouble(textBox2.Text);

            resultado = valor1 / valor2;

            richTextBox1.Text = "A divisão dos número é: \r" + resultado.ToString();

        }


    }
}
