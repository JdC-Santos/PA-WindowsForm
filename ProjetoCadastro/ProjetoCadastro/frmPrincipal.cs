using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class FrmPrincipal : Form
    {
        public static int contUsu = 0, contCli = 0, contFor = 0;

        public struct Usuario
        {
            public int cd_usuario;
            public string nm_usuario;
            public string sg_nivel;
            public string nm_login;
            public string ds_senha;
        }

        public struct Cliente
        {
            public int codigo;
            public string nome;
            public string endereco;
            public string bairro;
            public string cidade;
            public string CEP;
            public string cpf;
            public string nm_login;
            public string ds_senha;

        }

        public struct Fornecedor
        {
            public int codigo;
            public string nome;
            public string telefone;
            public string cnpj;
            public string login;
            public string senha;
        }
        public static Usuario[] usuario = new Usuario[10];
        public static Cliente[] cliente = new Cliente[10];
        public static Fornecedor[] fornecedor = new Fornecedor[10];

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cli = new frmCliente();
            cli.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor ff = new frmFornecedor();
            ff.ShowDialog();
        }

        private void pdcUsuario_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objImpressao = e.Graphics;
            string strDados = "", txt = "";
            int pag = 0, i = 0, lin = 0;
            bool cab = true, det = true;

            while (cab)
            {
                pag++;
                strDados += "Listagem de Usuários\n";
                txt = "Página: " + pag;
                strDados += String.Format("{0,-64}",txt); strDados += " JDCSOFT\n";
                for (int j = 0; j < 80; j++) { strDados += "-"; }
                strDados += "\n";
                strDados += String.Format("{0,-10}", "Código ");
                strDados += String.Format("{0,-40}", "Nome ");
                strDados += String.Format("{0,-10}", "Nivel ");
                strDados += String.Format("{0,-20}", "Login ");
                strDados += "\n";

                for (int j = 0; j < 80; j++){ strDados += "-"; }
                strDados += "\n";

                lin += 5;
                det = true;
                while (det)
                {
                    strDados += String.Format("{0,-10}", (usuario[i].cd_usuario.ToString("000000")));
                    strDados += String.Format("{0,-40}", usuario[i].nm_usuario);
                    strDados += String.Format("{0,-10}", usuario[i].sg_nivel);
                    strDados += String.Format("{0,-20}", usuario[i].nm_login) + "\n";
                    i++;
                    lin++;

                    if (lin >= 66)
                    {
                        det = false;
                    }
                    if (i >= contUsu)
                    {
                        det = false;
                        cab = false;
                    }
                }

                strDados += (char)12;
            }
            objImpressao.DrawString(strDados, new System.Drawing.Font("courier new", 10, FontStyle.Bold), Brushes.Black, 50, 50);
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ppdUsuario.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ppdCliente.Show();
        }

        private void pdcCliente_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objImpressao = e.Graphics;
            string strDados = "", txt = "";
            int pag = 0, i = 0, lin = 0;
            bool cab = true, det = true;

            while (cab)
            {
                pag++;
                strDados += "Listagem de Clientes\n";
                txt = "Página: " + pag;
                strDados += String.Format("{0,-64}", txt); strDados += " JDCSOFT\n";
                for (int j = 0; j < 80; j++) { strDados += "-"; }
                strDados += "\n";
                strDados += String.Format("{0,-10}", "Código ");
                strDados += String.Format("{0,-20}", "Nome ");
                strDados += String.Format("{0,-15}", "Cidade");
                strDados += String.Format("{0,-15}", "CEP");
                strDados += String.Format("{0,-20}", "Login ");
                strDados += "\n";

                for (int j = 0; j < 80; j++) { strDados += "-"; }
                strDados += "\n";

                lin += 5;
                det = true;
                while (det)
                {
                    strDados += String.Format("{0,-10}", (cliente[i].codigo.ToString("000000")));
                    strDados += String.Format("{0,-20}", cliente[i].nome);
                    strDados += String.Format("{0,-15}", cliente[i].cidade);
                    strDados += String.Format("{0,-15}", cliente[i].CEP);
                    strDados += String.Format("{0,-20}", cliente[i].nm_login) + "\n";
                    i++;
                    lin++;

                    if (lin >= 7)
                    {
                        det = false;
                    }
                    if (i >= contCli)
                    {
                        det = false;
                        cab = false;
                    }
                }

                strDados += (char)12;
            }
            objImpressao.DrawString(strDados, new System.Drawing.Font("courier new", 10, FontStyle.Bold), Brushes.Black, 50, 50);
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ppdFornecedor.Show();
        }

        private void pdcFornecedor_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objImpressao = e.Graphics;
            string strDados = "", txt = "";
            int pag = 0, i = 0, lin = 0;
            bool cab = true, det = true;

            while (cab)
            {
                pag++;
                strDados += "Listagem de Fornecedores\n";
                txt = "Página: " + pag;
                strDados += String.Format("{0,-64}", txt); strDados += " JDCSOFT\n";
                for (int j = 0; j < 80; j++) { strDados += "-"; }
                strDados += "\n";
                strDados += String.Format("{0,-10}", "Código ");
                strDados += String.Format("{0,-30}", "Nome ");
                strDados += String.Format("{0,-20}", "CNPJ");
                strDados += String.Format("{0,-20}", "Login ");
                strDados += "\n";

                for (int j = 0; j < 80; j++) { strDados += "-"; }
                strDados += "\n";

                lin += 5;
                det = true;
                while (det)
                {
                    strDados += String.Format("{0,-10}", (fornecedor[i].codigo.ToString("000000")));
                    strDados += String.Format("{0,-30}", fornecedor[i].nome);
                    strDados += String.Format("{0,-20}", fornecedor[i].cnpj);
                    strDados += String.Format("{0,-20}", fornecedor[i].login) + "\n";
                    i++;
                    lin++;

                    if (lin >= 66)
                    {
                        det = false;
                    }
                    if (i >= contFor)
                    {
                        det = false;
                        cab = false;
                    }
                }

                strDados += (char)12;
            }
            objImpressao.DrawString(strDados, new System.Drawing.Font("courier new", 10, FontStyle.Bold), Brushes.Black, 50, 50);
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        
        }
    }
}
