using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    class Vendedor
    {
        public int CodVendedor { get; set; }
        public string NomeVendedor { get; set; }

        public Vendedor()
        {

        }

        public Vendedor(int codVendedor, string nomeVendedor)
        {
            CodVendedor = codVendedor;
            NomeVendedor = nomeVendedor;
        }
    }
}
