using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Conexao c = new Conexao();

            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT * FROM produto WHERE descricao =@descricao";
            SELECT.Parameters.AddWithValue("@descricao", txtPesquisar.Text);


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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            //CodInterno = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
            //prod.CodBarra = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            string descricao = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            FrmCadProduto cadprod = new FrmCadProduto(descricao);
            
            cadprod.Show();
            this.Close();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
