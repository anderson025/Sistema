namespace Sistema
{
    partial class FrmCadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadProduto));
            this.TabGeral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpbPreco = new System.Windows.Forms.GroupBox();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.grbProduto = new System.Windows.Forms.GroupBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCodBarra = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbIncluir = new System.Windows.Forms.ToolStripButton();
            this.TsbEditar = new System.Windows.Forms.ToolStripButton();
            this.TsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.TsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.TsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.TsbSair = new System.Windows.Forms.ToolStripButton();
            this.TabGeral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpbPreco.SuspendLayout();
            this.grbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabGeral
            // 
            this.TabGeral.Controls.Add(this.tabPage1);
            this.TabGeral.Controls.Add(this.tabPage2);
            this.TabGeral.Controls.Add(this.tabPage3);
            this.TabGeral.Location = new System.Drawing.Point(12, 254);
            this.TabGeral.Name = "TabGeral";
            this.TabGeral.SelectedIndex = 0;
            this.TabGeral.Size = new System.Drawing.Size(754, 293);
            this.TabGeral.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gpbPreco);
            this.tabPage1.Controls.Add(this.grbProduto);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Geral";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gpbPreco
            // 
            this.gpbPreco.Controls.Add(this.lblPrecoCusto);
            this.gpbPreco.Controls.Add(this.txtPrecoCusto);
            this.gpbPreco.Controls.Add(this.txtPrecoVenda);
            this.gpbPreco.Controls.Add(this.lblCompra);
            this.gpbPreco.Controls.Add(this.lblPrecoVenda);
            this.gpbPreco.Controls.Add(this.txtPrecoCompra);
            this.gpbPreco.Location = new System.Drawing.Point(9, 135);
            this.gpbPreco.Name = "gpbPreco";
            this.gpbPreco.Size = new System.Drawing.Size(734, 119);
            this.gpbPreco.TabIndex = 1;
            this.gpbPreco.TabStop = false;
            this.gpbPreco.Text = "Preço";
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Location = new System.Drawing.Point(229, 28);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(70, 17);
            this.lblPrecoCusto.TabIndex = 12;
            this.lblPrecoCusto.Text = "Pr. Custo:";
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Location = new System.Drawing.Point(232, 48);
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(100, 22);
            this.txtPrecoCusto.TabIndex = 11;
            this.txtPrecoCusto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoCusto_KeyDown);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(14, 48);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(100, 22);
            this.txtPrecoVenda.TabIndex = 4;
            this.txtPrecoVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoVenda_KeyDown);
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(120, 28);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(83, 17);
            this.lblCompra.TabIndex = 10;
            this.lblCompra.Text = "Pr. Compra:";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(11, 28);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(75, 17);
            this.lblPrecoVenda.TabIndex = 8;
            this.lblPrecoVenda.Text = "Pr. Venda:";
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Location = new System.Drawing.Point(123, 48);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(100, 22);
            this.txtPrecoCompra.TabIndex = 9;
            this.txtPrecoCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecoCompra_KeyDown);
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.lblDescricao);
            this.grbProduto.Controls.Add(this.lblCodBarra);
            this.grbProduto.Controls.Add(this.lblCodigo);
            this.grbProduto.Controls.Add(this.txtDescricao);
            this.grbProduto.Controls.Add(this.txtCodBarra);
            this.grbProduto.Controls.Add(this.txtId);
            this.grbProduto.Location = new System.Drawing.Point(8, 6);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(732, 123);
            this.grbProduto.TabIndex = 0;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "Geral";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(286, 34);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(75, 17);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Descricão:";
            // 
            // lblCodBarra
            // 
            this.lblCodBarra.AutoSize = true;
            this.lblCodBarra.Location = new System.Drawing.Point(89, 34);
            this.lblCodBarra.Name = "lblCodBarra";
            this.lblCodBarra.Size = new System.Drawing.Size(122, 17);
            this.lblCodBarra.TabIndex = 6;
            this.lblCodBarra.Text = "Código de Barras:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Código:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(289, 54);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(437, 22);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Location = new System.Drawing.Point(92, 54);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.Size = new System.Drawing.Size(189, 22);
            this.txtCodBarra.TabIndex = 2;
            this.txtCodBarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodBarra_KeyDown);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(16, 54);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(70, 22);
            this.txtId.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fiscal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(746, 264);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Alter. Preços";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbIncluir,
            this.TsbEditar,
            this.TsbSalvar,
            this.TsbCancelar,
            this.TsbExcluir,
            this.TsbSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(778, 57);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbIncluir
            // 
            this.TsbIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbIncluir.Image = ((System.Drawing.Image)(resources.GetObject("TsbIncluir.Image")));
            this.TsbIncluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbIncluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbIncluir.Name = "TsbIncluir";
            this.TsbIncluir.Size = new System.Drawing.Size(54, 54);
            this.TsbIncluir.Text = "tsbIncluir";
            this.TsbIncluir.Click += new System.EventHandler(this.TsbIncluir_Click);
            // 
            // TsbEditar
            // 
            this.TsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("TsbEditar.Image")));
            this.TsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEditar.Name = "TsbEditar";
            this.TsbEditar.Size = new System.Drawing.Size(54, 54);
            this.TsbEditar.Text = "tsbEditar";
            this.TsbEditar.Click += new System.EventHandler(this.TsbEditar_Click);
            // 
            // TsbSalvar
            // 
            this.TsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("TsbSalvar.Image")));
            this.TsbSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSalvar.Name = "TsbSalvar";
            this.TsbSalvar.Size = new System.Drawing.Size(54, 54);
            this.TsbSalvar.Text = "tsbGravar";
            this.TsbSalvar.Click += new System.EventHandler(this.TsbSalvar_Click);
            // 
            // TsbCancelar
            // 
            this.TsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("TsbCancelar.Image")));
            this.TsbCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCancelar.Name = "TsbCancelar";
            this.TsbCancelar.Size = new System.Drawing.Size(54, 54);
            this.TsbCancelar.Text = "tsbCancelar";
            this.TsbCancelar.Click += new System.EventHandler(this.TsbCancelar_Click);
            // 
            // TsbExcluir
            // 
            this.TsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("TsbExcluir.Image")));
            this.TsbExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbExcluir.Name = "TsbExcluir";
            this.TsbExcluir.Size = new System.Drawing.Size(54, 54);
            this.TsbExcluir.Text = "tsbExcluir";
            this.TsbExcluir.Click += new System.EventHandler(this.TsbExcluir_Click);
            // 
            // TsbSair
            // 
            this.TsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSair.Image = ((System.Drawing.Image)(resources.GetObject("TsbSair.Image")));
            this.TsbSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSair.Name = "TsbSair";
            this.TsbSair.Size = new System.Drawing.Size(54, 54);
            this.TsbSair.Text = "tsbSair";
            this.TsbSair.Click += new System.EventHandler(this.TsbSair_Click);
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 552);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TabGeral);
            this.KeyPreview = true;
            this.Name = "FrmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadProduto_KeyDown);
            this.TabGeral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gpbPreco.ResumeLayout(false);
            this.gpbPreco.PerformLayout();
            this.grbProduto.ResumeLayout(false);
            this.grbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl TabGeral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbPreco;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.GroupBox grbProduto;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCodBarra;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbIncluir;
        private System.Windows.Forms.ToolStripButton TsbEditar;
        private System.Windows.Forms.ToolStripButton TsbSalvar;
        private System.Windows.Forms.ToolStripButton TsbCancelar;
        private System.Windows.Forms.ToolStripButton TsbExcluir;
        private System.Windows.Forms.ToolStripButton TsbSair;
    }
}