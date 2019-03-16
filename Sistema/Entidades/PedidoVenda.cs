using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema.Entidades.Enums;

namespace Sistema.Entidades
{
    class PedidoVenda
    {
        public int CodPedido { get; set; }
        public DateTime Data { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public BindingList<PedidoItens> bindingList {get;set;} = new BindingList<PedidoItens>();
        public List<PedidoItens> Items { get; set; } = new List<PedidoItens>();
        public double TotalPedido { get; set; }

        public PedidoVenda()
        {

        }
        public PedidoVenda(DateTime data, StatusPedido status, Cliente cliente)
        {
            Data = data;
            Status = status;
            Cliente = cliente;
        }

        public void AdicionarItem(PedidoItens item)
        {
            Items.Add(item);  
            
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
