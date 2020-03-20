using MySql.Data.MySqlClient;
using Sistema.Entidades;
using System;
using System.Data;
using System.Windows.Forms;


namespace Sistema
{
    public partial class FrmCadUsuarios : Form
    {
        public FrmCadUsuarios()
        {
            InitializeComponent();
        }

        private string controle = null;

        private void FrmCadUsuarios_Load(object sender, EventArgs e)
        {
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            txtCodigo.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            CarregaGrid();


            txtCodigo.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtUsuario.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            txtSenha.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();

            //Oculta a coluna Senha para não exibir no Grid
            dataGridView1.Columns["Senha"].Visible = false;
            dataGridView1.ReadOnly = true;


        }

        private void FormataGrid()
        {
            /*********Grid Dados******/
            //removendo o indicador do Datagrid do lado esquerdo da tela.
            dataGridView1.RowHeadersVisible = false;

            //Fundo do datagrid cinza claro
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;

            //Configura o grid para preencher a tela toda
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Remover a ultima linha do Datagrid
            dataGridView1.AllowUserToAddRows = false;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtUsuario.Text = String.Empty;
            txtSenha.Text = String.Empty;
            txtCodigo.Text = String.Empty;
            btnNovo.Enabled = false;
            BtnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSair.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;

            txtUsuario.Focus();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Conexao c = new Conexao();
            CriptografaSenha s = new CriptografaSenha();

            if (controle == "Editar")
            {

                try
                {

                    var senha = s.criptografaSHA512(txtSenha.Text);

                    MySqlCommand UPDATE = new MySqlCommand("UPDATE usuario SET Usuario = @User, Senha = @Pass WHERE id = @Id", c.conexao);
                    UPDATE.Parameters.AddWithValue("@User", txtUsuario.Text);
                    UPDATE.Parameters.AddWithValue("@Pass", senha);
                    UPDATE.Parameters.AddWithValue("@Id", txtCodigo.Text);
                    c.AbrirConexao();
                    UPDATE.ExecuteNonQuery();
                    MessageBox.Show("Alterador com Sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    c.FecharConexao();
                    //txtCodigo.Text = String.Empty;
                    //txtSenha.Text = String.Empty;
                    //txtUsuario.Text = String.Empty;

                    btnCancelar_Click(btnCancelar, new EventArgs());

                    CarregaGrid();

                    PosicionaDataGrid();

                }
                catch (Exception)
                {

                    MessageBox.Show("MySQL Não conectado!", "Erro na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    var usuario = txtUsuario.Text;
                    var senha = s.criptografaSHA512(txtSenha.Text);
                    c.AbrirConexao();
                    MySqlCommand INSERT = new MySqlCommand("INSERT INTO usuario (Usuario, Senha) VALUES(@User, @Pass)", c.conexao);
                    INSERT.Parameters.AddWithValue("@User", usuario.ToUpper());
                    INSERT.Parameters.AddWithValue("@Pass", senha);
                    INSERT.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    c.FecharConexao();
                    txtSenha.Text = String.Empty;
                    txtUsuario.Text = String.Empty;

                    btnCancelar_Click(btnCancelar, new EventArgs());

                    CarregaGrid();

                    PosicionaDataGrid();

                }
                catch (Exception)
                {

                    MessageBox.Show("MySQL Não conectado!", "Erro na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        public void PosicionaDataGrid()
        {
            txtCodigo.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtUsuario.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            txtSenha.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            BtnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;
            btnCancelar.Enabled = false;
            btnGravar.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;

            CarregaGrid();
            PosicionaDataGrid();


        }

        public void CarregaGrid()
        {
            Conexao c = new Conexao();

            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT id as Codigo, Usuario , Senha FROM usuario";

            try
            {
                c.AbrirConexao();
                MySqlDataAdapter leitura = new MySqlDataAdapter(SELECT);
                DataTable dt = new DataTable();

                leitura.Fill(dt);
                dataGridView1.DataSource = dt;

                FormataGrid();


                c.FecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Carregar o Grid!");


            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                txtCodigo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSenha.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            btnNovo.Enabled = false;
            BtnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSair.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            controle = "Editar";


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Conexao c = new Conexao();

                try
                {
                    MySqlCommand DELETE = new MySqlCommand("DELETE FROM usuario WHERE id = @Id", c.conexao);
                    DELETE.Parameters.AddWithValue("@Id", txtCodigo.Text);
                    c.AbrirConexao();
                    DELETE.ExecuteNonQuery();
                    MessageBox.Show("Excluído com Sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    c.FecharConexao();
                    txtSenha.Text = String.Empty;
                    txtUsuario.Text = String.Empty;
                    txtCodigo.Text = String.Empty;

                    //btnCancelar_Click(btnCancelar, new EventArgs());

                    CarregaGrid();
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao excluir usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }



            }

        }
                  
    }
}
