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
