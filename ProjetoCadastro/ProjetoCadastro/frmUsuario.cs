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
    public partial class frmUsuario : Form
    {
        int atual = 0;
        bool novoCadastro = false;

        private void Habilita()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtNivel.Enabled = true;
            txtlogin.Enabled = true;
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
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtNivel.Enabled = false;
            txtlogin.Enabled = false;
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
            if (FrmPrincipal.contUsu > 0)
            {
                txtCodigo.Text = (FrmPrincipal.usuario[atual].cd_usuario) > 0 ? FrmPrincipal.usuario[atual].cd_usuario.ToString() : "";
                txtNome.Text = FrmPrincipal.usuario[atual].nm_usuario;
                txtNivel.Text = FrmPrincipal.usuario[atual].sg_nivel;
                txtlogin.Text = FrmPrincipal.usuario[atual].nm_login;
                txtSenha.Text = FrmPrincipal.usuario[atual].ds_senha;
            }
            else
            {
                txtCodigo.Text =  "";
                txtNome.Text = "";
                txtNivel.Text = "";
                txtlogin.Text = "";
                txtSenha.Text = "";
            }
            
        }

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            Desabilita();
            mostra();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //se a quantidade de usuarios registrador for menos que 10, registre
            if (FrmPrincipal.contUsu < 10)
            {
                //cria um novo ID para o usuário que será registrado
                txtCodigo.Text = (FrmPrincipal.contUsu + 1).ToString();
                //limpa os campos do formulário para que o usuário possa preenche-los
                txtNome.Text = "";
                txtNivel.Text = "";
                txtlogin.Text = "";
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
                MessageBox.Show("Operação Inválida: nao é possivel cadastrar mais usuários");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (FrmPrincipal.contUsu < 10)
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
                atual = FrmPrincipal.contUsu;
                nr = FrmPrincipal.contUsu++;
            }
            else
            {
                nr = int.Parse(txtCodigo.Text) - 1;
            }

            FrmPrincipal.usuario[nr].cd_usuario = int.Parse(txtCodigo.Text);
            FrmPrincipal.usuario[nr].nm_usuario = txtNome.Text;
            FrmPrincipal.usuario[nr].sg_nivel = txtNivel.Text;
            FrmPrincipal.usuario[nr].nm_login = txtlogin.Text;
            FrmPrincipal.usuario[nr].ds_senha = txtSenha.Text;

            novoCadastro = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if(atual > 0)
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
            if (atual < FrmPrincipal.contUsu - 1)
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
            int excluir = int.Parse(txtCodigo.Text) - 1 ;

            if (atual >= 0)
            {
                for (int i = 0; i < (FrmPrincipal.usuario.Length); i++)
                {
                    if (i != excluir)
                    {
                        FrmPrincipal.usuario[i] = FrmPrincipal.usuario[i];
                    }
                }

                FrmPrincipal.contUsu--;
                atual--;
            }
           
            mostra();  
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = true;
        }

        private void btnSairPesquisa_Click(object sender, EventArgs e)
        {
            pnlPesquisa.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (txtPesquisa.Text != "")
            {
                for (i = 0; i < FrmPrincipal.contUsu; i++)
                {
                    if (FrmPrincipal.usuario[i].nm_usuario == txtPesquisa.Text)
                    {
                        atual = i;
                        mostra();
                        break;
                    }
                }

                if (i >= FrmPrincipal.contUsu)
                {
                    MessageBox.Show("Não Encontrado");
                }
                pnlPesquisa.Visible = false;
            }
        }
    }
}
