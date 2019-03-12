﻿namespace Sistema.Entidades
{
     class PedidoItens 
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { private get; set; }


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