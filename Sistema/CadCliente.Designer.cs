namespace Sistema
{
    partial class CadCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbIncluir = new System.Windows.Forms.ToolStripButton();
            this.TsbEditar = new System.Windows.Forms.ToolStripButton();
            this.TsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.TsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.TsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.TsbSair = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPais = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblFantasia = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.optJuridica = new System.Windows.Forms.RadioButton();
            this.optFisica = new System.Windows.Forms.RadioButton();
            this.btnDataNascimento = new System.Windows.Forms.Button();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpbTipo.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1117, 57);
            this.toolStrip1.TabIndex = 10;
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
            this.TsbIncluir.Text = "Incluir";
            // 
            // TsbEditar
            // 
            this.TsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("TsbEditar.Image")));
            this.TsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEditar.Name = "TsbEditar";
            this.TsbEditar.Size = new System.Drawing.Size(54, 54);
            this.TsbEditar.Text = "Editar";
            // 
            // TsbSalvar
            // 
            this.TsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("TsbSalvar.Image")));
            this.TsbSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSalvar.Name = "TsbSalvar";
            this.TsbSalvar.Size = new System.Drawing.Size(54, 54);
            this.TsbSalvar.Text = "Gravar";
            // 
            // TsbCancelar
            // 
            this.TsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("TsbCancelar.Image")));
            this.TsbCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCancelar.Name = "TsbCancelar";
            this.TsbCancelar.Size = new System.Drawing.Size(54, 54);
            this.TsbCancelar.Text = "Cancelar";
            // 
            // TsbExcluir
            // 
            this.TsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("TsbExcluir.Image")));
            this.TsbExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbExcluir.Name = "TsbExcluir";
            this.TsbExcluir.Size = new System.Drawing.Size(54, 54);
            this.TsbExcluir.Text = "Excluir";
            // 
            // TsbSair
            // 
            this.TsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSair.Image = ((System.Drawing.Image)(resources.GetObject("TsbSair.Image")));
            this.TsbSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSair.Name = "TsbSair";
            this.TsbSair.Size = new System.Drawing.Size(54, 54);
            this.TsbSair.Text = "Sair";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(811, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 256);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1061, 380);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblPais);
            this.tabPage1.Controls.Add(this.cboPais);
            this.tabPage1.Controls.Add(this.cboEstado);
            this.tabPage1.Controls.Add(this.cboEstados);
            this.tabPage1.Controls.Add(this.lblCidade);
            this.tabPage1.Controls.Add(this.cboCidade);
            this.tabPage1.Controls.Add(this.lblComplemento);
            this.tabPage1.Controls.Add(this.txtComplemento);
            this.tabPage1.Controls.Add(this.lblBairro);
            this.tabPage1.Controls.Add(this.txtBairro);
            this.tabPage1.Controls.Add(this.lblRua);
            this.tabPage1.Controls.Add(this.txtRua);
            this.tabPage1.Controls.Add(this.lblNumero);
            this.tabPage1.Controls.Add(this.txtNumero);
            this.tabPage1.Controls.Add(this.lblFantasia);
            this.tabPage1.Controls.Add(this.txtFantasia);
            this.tabPage1.Controls.Add(this.lblCPF);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.txtCPF);
            this.tabPage1.Controls.Add(this.gpbTipo);
            this.tabPage1.Controls.Add(this.btnDataNascimento);
            this.tabPage1.Controls.Add(this.lblDataNascimento);
            this.tabPage1.Controls.Add(this.txtData);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.lblCodigo);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1053, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(361, 174);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(39, 17);
            this.lblPais.TabIndex = 28;
            this.lblPais.Text = "País:";
            // 
            // cboPais
            // 
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(364, 194);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(210, 24);
            this.cboPais.TabIndex = 27;
            // 
            // cboEstado
            // 
            this.cboEstado.AutoSize = true;
            this.cboEstado.Location = new System.Drawing.Point(190, 174);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(56, 17);
            this.cboEstado.TabIndex = 26;
            this.cboEstado.Text = "Estado:";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(190, 194);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(168, 24);
            this.cboEstados.TabIndex = 25;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 174);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 17);
            this.lblCidade.TabIndex = 24;
            this.lblCidade.Text = "Cidade:";
            // 
            // cboCidade
            // 
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(16, 194);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(168, 24);
            this.cboCidade.TabIndex = 23;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(607, 123);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(98, 17);
            this.lblComplemento.TabIndex = 22;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(610, 140);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(183, 22);
            this.txtComplemento.TabIndex = 21;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(384, 123);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(50, 17);
            this.lblBairro.TabIndex = 20;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(387, 140);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(217, 22);
            this.txtBairro.TabIndex = 19;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(6, 120);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(38, 17);
            this.lblRua.TabIndex = 18;
            this.lblRua.Text = "Rua:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(9, 140);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(294, 22);
            this.txtRua.TabIndex = 17;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(309, 123);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 17);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Numero:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(310, 140);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(68, 22);
            this.txtNumero.TabIndex = 15;
            // 
            // lblFantasia
            // 
            this.lblFantasia.AutoSize = true;
            this.lblFantasia.Location = new System.Drawing.Point(522, 20);
            this.lblFantasia.Name = "lblFantasia";
            this.lblFantasia.Size = new System.Drawing.Size(107, 17);
            this.lblFantasia.TabIndex = 14;
            this.lblFantasia.Text = "Nome Fantasia:";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(525, 40);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(268, 22);
            this.txtFantasia.TabIndex = 13;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(6, 71);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 17);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "CPF:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(784, 88);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(9, 88);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(294, 22);
            this.txtCPF.TabIndex = 11;
            // 
            // gpbTipo
            // 
            this.gpbTipo.Controls.Add(this.optJuridica);
            this.gpbTipo.Controls.Add(this.optFisica);
            this.gpbTipo.Location = new System.Drawing.Point(90, 14);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(154, 48);
            this.gpbTipo.TabIndex = 10;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo";
            // 
            // optJuridica
            // 
            this.optJuridica.AutoSize = true;
            this.optJuridica.Location = new System.Drawing.Point(73, 20);
            this.optJuridica.Name = "optJuridica";
            this.optJuridica.Size = new System.Drawing.Size(78, 21);
            this.optJuridica.TabIndex = 1;
            this.optJuridica.Text = "Jurídica";
            this.optJuridica.UseVisualStyleBackColor = true;
            // 
            // optFisica
            // 
            this.optFisica.AutoSize = true;
            this.optFisica.Checked = true;
            this.optFisica.Location = new System.Drawing.Point(6, 18);
            this.optFisica.Name = "optFisica";
            this.optFisica.Size = new System.Drawing.Size(65, 21);
            this.optFisica.TabIndex = 0;
            this.optFisica.TabStop = true;
            this.optFisica.Text = "Física";
            this.optFisica.UseVisualStyleBackColor = true;
            this.optFisica.CheckedChanged += new System.EventHandler(this.optFisica_CheckedChanged);
            // 
            // btnDataNascimento
            // 
            this.btnDataNascimento.Location = new System.Drawing.Point(733, 88);
            this.btnDataNascimento.Name = "btnDataNascimento";
            this.btnDataNascimento.Size = new System.Drawing.Size(60, 24);
            this.btnDataNascimento.TabIndex = 9;
            this.btnDataNascimento.UseVisualStyleBackColor = true;
            this.btnDataNascimento.Click += new System.EventHandler(this.btnDataNascimento_Click);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(607, 68);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(120, 17);
            this.lblDataNascimento.TabIndex = 7;
            this.lblDataNascimento.Text = "Data Nascimento:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(610, 88);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(117, 22);
            this.txtData.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(309, 71);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(310, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(247, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(250, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(268, 22);
            this.txtNome.TabIndex = 2;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 14);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(75, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1053, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 665);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CadCliente";
            this.Text = "CadCliente";
            this.Load += new System.EventHandler(this.CadCliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbIncluir;
        private System.Windows.Forms.ToolStripButton TsbEditar;
        private System.Windows.Forms.ToolStripButton TsbSalvar;
        private System.Windows.Forms.ToolStripButton TsbCancelar;
        private System.Windows.Forms.ToolStripButton TsbExcluir;
        private System.Windows.Forms.ToolStripButton TsbSair;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnDataNascimento;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.RadioButton optJuridica;
        private System.Windows.Forms.RadioButton optFisica;
        private System.Windows.Forms.Label lblFantasia;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label cboEstado;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
    }
}