namespace ProjetoCadastro
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdcUsuario = new System.Drawing.Printing.PrintDocument();
            this.pdcCliente = new System.Drawing.Printing.PrintDocument();
            this.pdcFornecedor = new System.Drawing.Printing.PrintDocument();
            this.ppdUsuario = new System.Windows.Forms.PrintPreviewDialog();
            this.ppdCliente = new System.Windows.Forms.PrintPreviewDialog();
            this.ppdFornecedor = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.fornecedorToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem1,
            this.clienteToolStripMenuItem1,
            this.fornecedorToolStripMenuItem1});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // usuárioToolStripMenuItem1
            // 
            this.usuárioToolStripMenuItem1.Name = "usuárioToolStripMenuItem1";
            this.usuárioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.usuárioToolStripMenuItem1.Text = "Usuário";
            this.usuárioToolStripMenuItem1.Click += new System.EventHandler(this.usuárioToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fornecedorToolStripMenuItem1.Text = "Fornecedor";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // pdcUsuario
            // 
            this.pdcUsuario.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdcUsuario_PrintPage);
            // 
            // ppdUsuario
            // 
            this.ppdUsuario.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdUsuario.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdUsuario.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdUsuario.Document = this.pdcUsuario;
            this.ppdUsuario.Enabled = true;
            this.ppdUsuario.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdUsuario.Icon")));
            this.ppdUsuario.Name = "ppdUsuario";
            this.ppdUsuario.Visible = false;
            // 
            // ppdCliente
            // 
            this.ppdCliente.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdCliente.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdCliente.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdCliente.Document = this.pdcCliente;
            this.ppdCliente.Enabled = true;
            this.ppdCliente.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdCliente.Icon")));
            this.ppdCliente.Name = "ppdCliente";
            this.ppdCliente.Visible = false;
            // 
            // ppdFornecedor
            // 
            this.ppdFornecedor.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdFornecedor.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdFornecedor.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdFornecedor.Document = this.pdcFornecedor;
            this.ppdFornecedor.Enabled = true;
            this.ppdFornecedor.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdFornecedor.Icon")));
            this.ppdFornecedor.Name = "ppdFornecedor";
            this.ppdFornecedor.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmPrincipal";
            this.Text = "Projeto Cadastro";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument pdcUsuario;
        private System.Drawing.Printing.PrintDocument pdcCliente;
        private System.Drawing.Printing.PrintDocument pdcFornecedor;
        private System.Windows.Forms.PrintPreviewDialog ppdUsuario;
        private System.Windows.Forms.PrintPreviewDialog ppdCliente;
        private System.Windows.Forms.PrintPreviewDialog ppdFornecedor;
    }
}

