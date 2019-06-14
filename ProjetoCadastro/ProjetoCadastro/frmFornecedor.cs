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
    public partial class frmFornecedor : Form
    {
        int atual = 0;
        bool novoCadastro = false;

        private void Habilita()
        {
            txtCod.Enabled = false;
            txtNome.Enabled = true;
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
            if (FrmPrincipal.contFor > 0)
            {
                txtCod.Text = (FrmPrincipal.fornecedor[atual].codigo) > 0 ? FrmPrincipal.fornecedor[atual].codigo.ToString() : "";
                txtNome.Text = FrmPrincipal.fornecedor[atual].nome;
                txtCPF.Text = FrmPrincipal.fornecedor[atual].cnpj;
                txtLogin.Text = FrmPrincipal.fornecedor[atual].login;
                txtSenha.Text = FrmPrincipal.fornecedor[atual].senha;
            }
            else
            {
                txtCod.Text = "";
                txtNome.Text = "";
                txtCPF.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
            }

        }
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            Desabilita();
            mostra();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //se a quantidade de usuarios registrador for menos que 10, registre
            if (FrmPrincipal.contFor < 10)
            {
                //cria um novo ID para o usuário que será registrado
                txtCod.Text = (FrmPrincipal.contFor + 1).ToString();
                //limpa os campos do formulário para que o usuário possa preenche-los
                txtNome.Text = "";
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
                MessageBox.Show("Operação Inválida: nao é possivel cadastrar mais fornecedores");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (FrmPrincipal.contFor < 10)
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
                atual = FrmPrincipal.contFor;
                nr = FrmPrincipal.contFor++;
            }
            else
            {
                nr = int.Parse(txtCod.Text) - 1;
            }

            FrmPrincipal.fornecedor[nr].codigo = int.Parse(txtCod.Text);
            FrmPrincipal.fornecedor[nr].nome = txtNome.Text;
            FrmPrincipal.fornecedor[nr].cnpj = txtCPF.Text;
            FrmPrincipal.fornecedor[nr].login = txtLogin.Text;
            FrmPrincipal.fornecedor[nr].senha = txtSenha.Text;

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
            if (atual < FrmPrincipal.contFor - 1)
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
                for (int i = 0; i < (FrmPrincipal.fornecedor.Length); i++)
                {
                    if (i != excluir)
                    {
                        FrmPrincipal.fornecedor[i] = FrmPrincipal.fornecedor[i];
                    }
                }

                FrmPrincipal.contFor--;
                atual--;
            }

            mostra();
        }
    }
}
