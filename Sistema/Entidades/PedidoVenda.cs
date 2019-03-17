using Sistema.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Sistema.Entidades
{
    class PedidoVenda
    {
        public int CodPedido { get; set; }
        public DateTime Data { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<PedidoItens> Items { get; set; } = new List<PedidoItens>();
        public BindingSource bindingSource1 = new BindingSource();
        public double TotalPedido { get; set; }

        public PedidoVenda()
        {

        }

        public PedidoVenda(int codPedido, DateTime data, Cliente cliente, double totalPedido)
        {
            CodPedido = codPedido;
            Data = data;
            Cliente = cliente;
            TotalPedido = totalPedido;
        }

        public void AdicionarItem(PedidoItens item)
        {
            bindingSource1.Add(new PedidoItens() { Quantidade = item.Quantidade, Preco = item.Preco, Produto = item.Produto });
            //Items.Add(item);
            
        }

        public void RemoverItem(PedidoItens item)
        {
            Items.Remove(item);
        }

        public double Total()
        {

            foreach (var item in Items)
            {
                TotalPedido += item.SubTotal();

            }
            return TotalPedido;
        }


        public void InserirPedido()
        {
            try
            {
                Conexao c = new Conexao();

                c.AbrirConexao();
                //MySqlCommand INSERT = new MySqlCommand("INSERT INTO produto (codbarra, descricao, precovenda, precocompra, precocusto) " +
                //                                        "VALUES(@Codbarra, @Descricao, @Precovenda,@Precocompra,@Precocusto)", c.conexao);
                //INSERT.Parameters.AddWithValue("@Codbarra", CodBarra);
                //INSERT.Parameters.AddWithValue("@Descricao", Descricao.ToUpper());
                //INSERT.Parameters.AddWithValue("@Precovenda", PrecoVenda);
                //INSERT.Parameters.AddWithValue("@Precocompra", PrecoCompra);
                //INSERT.Parameters.AddWithValue("@Precocusto", PrecoCusto);
                //INSERT.ExecuteNonQuery();

                //MessageBox.Show("Cadastrado com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //c.FecharConexao();



            }
            catch (Exception ex)
            {

                MessageBox.Show("MySQL Não conectado!", "Erro na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Erro", ex);

            }
        }

        
    }
}
