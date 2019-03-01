namespace Sistema
{
    partial class frmSistema
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lsbListaNomes = new System.Windows.Forms.ListBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblListaNome = new System.Windows.Forms.Label();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTeste1 = new System.Windows.Forms.RadioButton();
            this.rbTeste = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 258);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 40);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(258, 22);
            this.txtNome.TabIndex = 2;
            // 
            // lsbListaNomes
            // 
            this.lsbListaNomes.FormattingEnabled = true;
            this.lsbListaNomes.ItemHeight = 16;
            this.lsbListaNomes.Location = new System.Drawing.Point(12, 90);
            this.lsbListaNomes.Name = "lsbListaNomes";
            this.lsbListaNomes.Size = new System.Drawing.Size(258, 148);
            this.lsbListaNomes.TabIndex = 3;
            this.lsbListaNomes.DoubleClick += new System.EventHandler(this.lsbListaNomes_DoubleClick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblListaNome
            // 
            this.lblListaNome.AutoSize = true;
            this.lblListaNome.Location = new System.Drawing.Point(12, 70);
            this.lblListaNome.Name = "lblListaNome";
            this.lblListaNome.Size = new System.Drawing.Size(110, 17);
            this.lblListaNome.TabIndex = 5;
            this.lblListaNome.Text = "Lista de Nomes:";
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(114, 258);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(96, 40);
            this.bntLimpar.TabIndex = 6;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(322, 44);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(61, 21);
            this.chkAtivo.TabIndex = 7;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckStateChanged += new System.EventHandler(this.chkAtivo_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(322, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 21);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(322, 98);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 21);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNao);
            this.groupBox1.Controls.Add(this.rbSim);
            this.groupBox1.Location = new System.Drawing.Point(298, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(21, 59);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(55, 21);
            this.rbNao.TabIndex = 13;
            this.rbNao.Text = "Nao";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Checked = true;
            this.rbSim.Location = new System.Drawing.Point(21, 32);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(52, 21);
            this.rbSim.TabIndex = 12;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTeste1);
            this.groupBox2.Controls.Add(this.rbTeste);
            this.groupBox2.Location = new System.Drawing.Point(298, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rbTeste1
            // 
            this.rbTeste1.AutoSize = true;
            this.rbTeste1.Checked = true;
            this.rbTeste1.Location = new System.Drawing.Point(21, 59);
            this.rbTeste1.Name = "rbTeste1";
            this.rbTeste1.Size = new System.Drawing.Size(73, 21);
            this.rbTeste1.TabIndex = 13;
            this.rbTeste1.TabStop = true;
            this.rbTeste1.Text = "Teste1";
            this.rbTeste1.UseVisualStyleBackColor = true;
            // 
            // rbTeste
            // 
            this.rbTeste.AutoSize = true;
            this.rbTeste.Location = new System.Drawing.Point(21, 32);
            this.rbTeste.Name = "rbTeste";
            this.rbTeste.Size = new System.Drawing.Size(65, 21);
            this.rbTeste.TabIndex = 12;
            this.rbTeste.Text = "Teste";
            this.rbTeste.UseVisualStyleBackColor = true;
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.lblListaNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lsbListaNomes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmSistema";
            this.Text = "Sistema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox lsbListaNomes;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblListaNome;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTeste1;
        private System.Windows.Forms.RadioButton rbTeste;
    }
}

