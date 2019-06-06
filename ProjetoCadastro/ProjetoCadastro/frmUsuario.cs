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
            txtCodigo.Text = (FrmPrincipal.usuario[atual].cd_usuario) > 0? FrmPrincipal.usuario[atual].cd_usuario.ToString(): "";
            txtNome.Text = FrmPrincipal.usuario[atual].nm_usuario.ToString();
            txtNivel.Text = FrmPrincipal.usuario[atual].sg_nivel.ToString();
            txtlogin.Text = FrmPrincipal.usuario[atual].nm_login.ToString();
            txtSenha.Text = FrmPrincipal.usuario[atual].ds_senha.ToString();
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
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
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
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (atual < FrmPrincipal.contUsu - 1)
            {
                atual++;
                mostra();
            }
        }
    }
}
