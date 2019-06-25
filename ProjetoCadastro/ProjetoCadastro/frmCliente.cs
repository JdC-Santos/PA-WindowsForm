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
    public partial class frmCliente : Form
    {
        int atual = 0;
        bool novoCadastro = false;

        private void Habilita()
        {
            txtCod.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtCEP.Enabled = true;
            txtCPF.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;

            btnAlterar.Enabled = false;
            btnAnterior.Enabled = false;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = false;
            btnImprimir.Enabled = false;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnProximo.Enabled = false;
            btnSair.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void Desabilita()
        {
            txtCod.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtCEP.Enabled = false;
            txtCPF.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;

            btnAlterar.Enabled = true;
            btnAnterior.Enabled = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
            btnImprimir.Enabled = true;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnProximo.Enabled = true;
            btnSair.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void mostra()
        {
            if (FrmPrincipal.contCli > 0)
            {
                txtCod.Text = (FrmPrincipal.cliente[atual].codigo) > 0 ? FrmPrincipal.cliente[atual].codigo.ToString() : "";
                txtNome.Text = FrmPrincipal.cliente[atual].nome;
                txtEndereco.Text = FrmPrincipal.cliente[atual].endereco;
                txtBairro.Text = FrmPrincipal.cliente[atual].bairro;
                txtCidade.Text = FrmPrincipal.cliente[atual].cidade;
                txtCEP.Text = FrmPrincipal.cliente[atual].CEP;
                txtCPF.Text = FrmPrincipal.cliente[atual].cpf;
                txtLogin.Text = FrmPrincipal.cliente[atual].nm_login;
                txtSenha.Text = FrmPrincipal.cliente[atual].ds_senha;
            }
            else
            {
                txtCod.Text = "";
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtCEP.Text = "";
                txtCPF.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
            }

        }

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Desabilita();
            mostra();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //se a quantidade de usuarios registrador for menos que 10, registre
            if (FrmPrincipal.contCli < 10)
            {
                //cria um novo ID para o usuário que será registrado
                txtCod.Text = (FrmPrincipal.contCli + 1).ToString();
                //limpa os campos do formulário para que o usuário possa preenche-los
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtCEP.Text = "";
                txtCPF.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
                //habilita o formulário
                Habilita();
                //coloca o cursor dentro do input txtNome
                txtNome.Focus();
                //torna a variavel booleana verdadeira (para avisar que é um novo usuario e nao a atualizacao de um existente)
                novoCadastro = true;
            }
            else
            {
                //se a quantidade de usuariSos registrador for maior ou igual a 10, envia a mensagem de erro.
                MessageBox.Show("Operação Inválida: nao é possivel cadastrar mais clientes");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (FrmPrincipal.contCli < 10)
            {
                Habilita();
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Operação Inválida");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();

            int nr = 0;

            if (novoCadastro)
            {
                atual = FrmPrincipal.contCli;
                nr = FrmPrincipal.contCli++;
            }
            else
            {
                nr = int.Parse(txtCod.Text) - 1;
            }

            FrmPrincipal.cliente[nr].codigo = int.Parse(txtCod.Text);
            FrmPrincipal.cliente[nr].nome = txtNome.Text;
            FrmPrincipal.cliente[nr].endereco = txtEndereco.Text;
            FrmPrincipal.cliente[nr].bairro = txtBairro.Text;
            FrmPrincipal.cliente[nr].cidade = txtCidade.Text;
            FrmPrincipal.cliente[nr].CEP = txtCEP.Text;
            FrmPrincipal.cliente[nr].cpf = txtCPF.Text;
            FrmPrincipal.cliente[nr].nm_login = txtLogin.Text;
            FrmPrincipal.cliente[nr].ds_senha = txtSenha.Text;

            novoCadastro = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (atual > 0)
            {
                atual--;
                mostra();
            }
            else
            {
                MessageBox.Show("não há registros anteriores");
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (atual < FrmPrincipal.contCli - 1)
            {
                atual++;
                mostra();
            }
            else
            {
                MessageBox.Show("não há registros posteriores");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int excluir = int.Parse(txtCod.Text) - 1;

            if (atual >= 0)
            {
                for (int i = 0; i < (FrmPrincipal.cliente.Length); i++)
                {
                    if (i != excluir)
                    {
                        FrmPrincipal.cliente[i] = FrmPrincipal.cliente[i];
                    }
                }

                FrmPrincipal.contCli--;
                atual--;
            }

            mostra();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = true;
            txtPesquisa.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (txtPesquisa.Text != "")
            {
                for (i = 0; i < FrmPrincipal.contCli; i++)
                {
                    if (FrmPrincipal.cliente[i].nome == txtPesquisa.Text)
                    {
                        atual = i;
                        mostra();
                        break;
                    }
                }

                if (i >= FrmPrincipal.contCli)
                {
                    MessageBox.Show("Não Encontrado");
                }
                pnlPesquisa.Visible = false;
            }
        }

        private void btnSairPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objImpressao = e.Graphics;
            string strDados;

            strDados = "Ficha de Cliente \n";
            strDados += "-------------------------------------------------\n";
            strDados += "Código do Cliente: " + txtCod.Text + "\n";
            strDados += "Nome do Cliente: " + txtNome.Text + "\n";
            strDados += "Endereço do Cliente: " + txtEndereco.Text + "\n";
            strDados += "Bairro do Cliente: " + txtBairro.Text + "\n";
            strDados += "Cidade do Cliente: " + txtCidade.Text + "\n";
            strDados += "CEP do Cliente: " + txtCEP.Text + "\n";
            strDados += "CPF do Cliente: " + txtCPF.Text + "\n";
            strDados += "Login do Cliente: " + txtLogin.Text + "\n";
            strDados += "-------------------------------------------------\n";

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }
    }
}
