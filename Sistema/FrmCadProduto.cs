using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;


namespace Sistema
{
    public partial class FrmCadProduto : Form
    {


        public FrmCadProduto()
        {
            InitializeComponent();

        }

        private string controle;
        private bool carregagrid;
        Produto prod = new Produto();

        public FrmCadProduto(string descricao)
        {
            InitializeComponent();
            CarregaGridPesquisa(descricao);


        }


        private void FrmCadProduto_Load(object sender, EventArgs e)
        {

            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            txtId.Enabled = false;
            txtCodBarra.Enabled = false;
            txtDescricao.Enabled = false;
            txtPrecoVenda.Enabled = false;
            txtPrecoCusto.Enabled = false;
            txtPrecoCompra.Enabled = false;

            //Funcao para carregar o Grid
            if (carregagrid == true)
            {
                txtId.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                txtCodBarra.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                txtDescricao.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                txtPrecoVenda.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                //txtPrecoCompra.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                //txtPrecoCusto.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();

                return;
            }
            else
            {
                CarregaGrid();

            }



            //Oculta a coluna Senha para não exibri no Grid
            dataGridView1.Columns["precocusto"].Visible = false;

            //Carrega os campos do datagrid nos textbox
            txtId.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtCodBarra.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            txtDescricao.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            txtPrecoVenda.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            txtPrecoCompra.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            txtPrecoCusto.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();

            //bloqueia a edição da celula no datagrid
            dataGridView1.ReadOnly = true;

        }

        public void CarregaGrid()
        {
            Conexao c = new Conexao();


            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT id as Codigo, codbarra , descricao, precovenda, precocompra,precocusto FROM produto";

            try
            {
                c.AbrirConexao();
                MySqlDataAdapter leitura = new MySqlDataAdapter(SELECT);
                DataTable dt = new DataTable();

                leitura.Fill(dt);
                dataGridView1.DataSource = dt;
                c.FecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Carregar o Grid!");


            }



        }

        public void CarregaGridPesquisa(string descricao)
        {
            Conexao c = new Conexao();
            carregagrid = true;

            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT id as Codigo, codbarra , descricao, precovenda FROM produto WHERE descricao = @descricao";
            SELECT.Parameters.AddWithValue("@descricao", descricao);

            try
            {
                c.AbrirConexao();
                MySqlDataAdapter leitura = new MySqlDataAdapter(SELECT);
                DataTable dt = new DataTable();

                leitura.Fill(dt);
                dataGridView1.DataSource = dt;
                c.FecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Carregar o Grid!");


            }



        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            //Limpa os campos
            txtId.Text = String.Empty;
            txtCodBarra.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            txtPrecoVenda.Text = String.Empty;
            txtPrecoCompra.Text = String.Empty;
            txtPrecoCusto.Text = String.Empty;

            //Habilita os textbox
            txtCodBarra.Enabled = true;
            txtDescricao.Enabled = true;
            txtPrecoCompra.Enabled = true;
            txtPrecoCusto.Enabled = true;
            txtPrecoVenda.Enabled = true;

            //Habilita e desabilita botoes
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSair.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;

            txtCodBarra.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Habilita os textbox
            txtCodBarra.Enabled = true;
            txtDescricao.Enabled = true;
            txtPrecoCompra.Enabled = true;
            txtPrecoCusto.Enabled = true;
            txtPrecoVenda.Enabled = true;

            //Habilita e desabilita botoes
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSair.Enabled = false;
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;

            controle = "Editar";

            txtCodBarra.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            prod.CodInterno = int.Parse(txtId.Text);
            prod.CodBarra = txtCodBarra.Text;
            prod.Descricao = txtDescricao.Text;
            prod.PrecoVenda = double.Parse(txtPrecoVenda.Text, NumberStyles.Currency);
            prod.PrecoCusto = double.Parse(txtPrecoCusto.Text, NumberStyles.Currency);
            prod.PrecoCompra = double.Parse(txtPrecoCompra.Text, NumberStyles.Currency);

            if (controle == "Editar")
            {
                prod.EditarProduto();

                txtId.Text = String.Empty;
                txtCodBarra.Text = String.Empty;
                txtDescricao.Text = String.Empty;
                txtPrecoVenda.Text = String.Empty;
                txtPrecoCompra.Text = String.Empty;
                txtPrecoCusto.Text = String.Empty;

                btnCancelar_Click(btnCancelar, new EventArgs());

                CarregaGrid();

            }
            else
            {
                prod.InserirProduto();

                txtId.Text = String.Empty;
                txtCodBarra.Text = String.Empty;
                txtDescricao.Text = String.Empty;
                txtPrecoVenda.Text = String.Empty;
                txtPrecoCompra.Text = String.Empty;
                txtPrecoCusto.Text = String.Empty;

                btnCancelar_Click(btnCancelar, new EventArgs());

                CarregaGrid();

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prod.CodInterno = int.Parse(txtId.Text);
                prod.ExcluirProduto();

                txtId.Text = String.Empty;
                txtCodBarra.Text = String.Empty;
                txtDescricao.Text = String.Empty;
                txtPrecoVenda.Text = String.Empty;
                txtPrecoCompra.Text = String.Empty;
                txtPrecoCusto.Text = String.Empty;

                //btnCancelar_Click(btnCancelar, new EventArgs());

                CarregaGrid();
            }
        }




        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Navegação do Datagrid incluindo os valores no textbox
            if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCodBarra.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescricao.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrecoVenda.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPrecoCompra.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPrecoCusto.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Habilita os textbox
            txtCodBarra.Enabled = false;
            txtDescricao.Enabled = false;
            txtPrecoCompra.Enabled = false;
            txtPrecoCusto.Enabled = false;
            txtPrecoVenda.Enabled = false;

            //Habilita e desabilita botoes
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSair.Enabled = true;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;


        }

        private void FrmCadProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F5")
            {
                Pesquisa pesquisa = new Pesquisa();
                pesquisa.Show();

            }
        }



        private void txtCodBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txtPrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txtPrecoCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void txtPrecoCusto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        
    }
}
