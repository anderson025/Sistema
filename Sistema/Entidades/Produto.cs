using MySql.Data.MySqlClient;
using System;
using System.Text;
using System.Windows.Forms;

namespace Sistema.Entidades
{
     class Produto
    {
        public int CodInterno { get; set; }
        public string Descricao { get; set; }
        public string CodBarra { get; set; }
        public double PrecoVenda { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoCusto { get; set; }

        public Produto()
        {

        }

        public Produto(int codInterno, string descricao, string codBarra, double precoVenda)
        {
            CodInterno = codInterno;
            Descricao = descricao;
            CodBarra = codBarra;
            PrecoVenda = precoVenda;
            
        }

        public void InserirProduto()
        {

            try
            {
                Conexao c = new Conexao();

                c.AbrirConexao();
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO produto (codbarra, descricao, precovenda, precocompra, precocusto) " +
                                                        "VALUES(@Codbarra, @Descricao, @Precovenda,@Precocompra,@Precocusto)", c.conexao);
                INSERT.Parameters.AddWithValue("@Codbarra", CodBarra);
                INSERT.Parameters.AddWithValue("@Descricao", Descricao.ToUpper());
                INSERT.Parameters.AddWithValue("@Precovenda", PrecoVenda);
                INSERT.Parameters.AddWithValue("@Precocompra", PrecoCompra);
                INSERT.Parameters.AddWithValue("@Precocusto", PrecoCusto);
                INSERT.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                c.FecharConexao();



            }
            catch (Exception ex)
            {

                MessageBox.Show("MySQL Não conectado!", "Erro na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Erro", ex);

            }

        }

        public void EditarProduto()
        {
            try
            {
                Conexao c = new Conexao();
                c.AbrirConexao();
                MySqlCommand UPDATE = new MySqlCommand("UPDATE produto SET codbarra = @Codbarra, descricao = @Descricao, precovenda = @Precovenda, precocompra = @Precocompra, precocusto = @Precocusto WHERE id = @Id", c.conexao);
                UPDATE.Parameters.AddWithValue("@Codbarra", CodBarra);
                UPDATE.Parameters.AddWithValue("@Descricao", Descricao.ToUpper());
                UPDATE.Parameters.AddWithValue("@Precovenda", PrecoVenda);
                UPDATE.Parameters.AddWithValue("@Precocompra", PrecoCompra);
                UPDATE.Parameters.AddWithValue("@Precocusto", PrecoCusto);
                UPDATE.Parameters.AddWithValue("@Id", CodInterno);

                

                UPDATE.ExecuteNonQuery();
                MessageBox.Show("Alterador com Sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                c.FecharConexao();



            }
            catch (Exception ex)
            {

                MessageBox.Show("MySQL Não conectado!", "Erro na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(ex);
            }
        }
        public void ExcluirProduto()
        {
            Conexao c = new Conexao();

            try
            {
                MySqlCommand DELETE = new MySqlCommand("DELETE FROM produto WHERE id = @Id", c.conexao);
                DELETE.Parameters.AddWithValue("@Id", CodInterno);
                c.AbrirConexao();
                DELETE.ExecuteNonQuery();
                MessageBox.Show("Excluído com Sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                c.FecharConexao();


            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao excluir usuário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        

    }
}
