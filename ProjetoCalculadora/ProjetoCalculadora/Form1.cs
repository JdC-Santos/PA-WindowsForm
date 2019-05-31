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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (double.Parse(txtValor1.Text) + double.Parse(txtValor2.Text)).ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (double.Parse(txtValor1.Text) - double.Parse(txtValor2.Text)).ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (double.Parse(txtValor1.Text) * double.Parse(txtValor2.Text)).ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (double.Parse(txtValor1.Text) / double.Parse(txtValor2.Text)).ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
