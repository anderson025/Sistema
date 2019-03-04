using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades.Enums
{
    enum StatusPedido : int
    {
        Pendente = 0,
        Processamento = 1,
        Enviado = 2,
        Entregue = 3
    }
}
