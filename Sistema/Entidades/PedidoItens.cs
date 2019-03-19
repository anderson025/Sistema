namespace Sistema.Entidades
{
    class PedidoItens
    {
        public int CodPedido { get; set; }
        public string Descricao { get; set; }
        public int CodProduto{ get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Subtotal { get; set; }
        public Produto Produto { get; set; }


        public PedidoItens()
        {
        }

        public PedidoItens(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Preco * Quantidade;
        }


    }
}
