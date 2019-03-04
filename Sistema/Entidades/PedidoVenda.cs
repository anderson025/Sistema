using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidades.Enums;

namespace Sistema.Entidades
{
    class PedidoVenda
    {
        public DateTime Data { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
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
    }
}
