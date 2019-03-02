namespace Sistema
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbCadUsuario = new System.Windows.Forms.ToolStripButton();
            this.TsbCadProduto = new System.Windows.Forms.ToolStripButton();
            this.TsbSair = new System.Windows.Forms.ToolStripButton();
            this.TsbCadFornecedor = new System.Windows.Forms.ToolStripButton();
            this.TsbCadCliente = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem1,
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.financeiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem1
            // 
            this.arquivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem1.Name = "arquivoToolStripMenuItem1";
            this.arquivoToolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.arquivoToolStripMenuItem1.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbCadUsuario,
            this.TsbCadCliente,
            this.TsbCadFornecedor,
            this.TsbCadProduto,
            this.TsbSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1116, 73);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbCadUsuario
            // 
            this.TsbCadUsuario.AutoSize = false;
            this.TsbCadUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCadUsuario.Image = ((System.Drawing.Image)(resources.GetObject("TsbCadUsuario.Image")));
            this.TsbCadUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbCadUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCadUsuario.Name = "TsbCadUsuario";
            this.TsbCadUsuario.Size = new System.Drawing.Size(70, 70);
            this.TsbCadUsuario.Text = "Cadastro de Usuários";
            this.TsbCadUsuario.Click += new System.EventHandler(this.TsbCadUsuario_Click);
            // 
            // TsbCadProduto
            // 
            this.TsbCadProduto.AutoSize = false;
            this.TsbCadProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCadProduto.Image = ((System.Drawing.Image)(resources.GetObject("TsbCadProduto.Image")));
            this.TsbCadProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbCadProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCadProduto.Name = "TsbCadProduto";
            this.TsbCadProduto.Size = new System.Drawing.Size(70, 70);
            this.TsbCadProduto.Text = "Cadastro de Produtos";
            this.TsbCadProduto.Click += new System.EventHandler(this.TsbCadProduto_Click);
            // 
            // TsbSair
            // 
            this.TsbSair.AutoSize = false;
            this.TsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSair.Image = ((System.Drawing.Image)(resources.GetObject("TsbSair.Image")));
            this.TsbSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSair.Name = "TsbSair";
            this.TsbSair.Size = new System.Drawing.Size(70, 70);
            this.TsbSair.Text = "Sair";
            this.TsbSair.Click += new System.EventHandler(this.TsbSair_Click);
            // 
            // TsbCadFornecedor
            // 
            this.TsbCadFornecedor.AutoSize = false;
            this.TsbCadFornecedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCadFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("TsbCadFornecedor.Image")));
            this.TsbCadFornecedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbCadFornecedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCadFornecedor.Name = "TsbCadFornecedor";
            this.TsbCadFornecedor.Size = new System.Drawing.Size(70, 70);
            this.TsbCadFornecedor.Text = "Cadastro de Fornecedor";
            // 
            // TsbCadCliente
            // 
            this.TsbCadCliente.AutoSize = false;
            this.TsbCadCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCadCliente.Image = ((System.Drawing.Image)(resources.GetObject("TsbCadCliente.Image")));
            this.TsbCadCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbCadCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCadCliente.Name = "TsbCadCliente";
            this.TsbCadCliente.Size = new System.Drawing.Size(70, 70);
            this.TsbCadCliente.Text = "Cadastro de Cliente";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Sem título.jpg");
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "AS- Sistemas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbCadUsuario;
        private System.Windows.Forms.ToolStripButton TsbCadProduto;
        private System.Windows.Forms.ToolStripButton TsbSair;
        private System.Windows.Forms.ToolStripButton TsbCadFornecedor;
        private System.Windows.Forms.ToolStripButton TsbCadCliente;
        private System.Windows.Forms.ImageList imageList1;
    }
}