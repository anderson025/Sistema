using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    class Cliente
    {
        public int CodCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Telefone { get; set; }
        public Endereco Endereco { get; set; }

        


        public Cliente()
        {
        }

        public Cliente(int codCliente, string nome, string email, DateTime dataNascimento)
        {
            CodCliente = codCliente;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Endereco = new Endereco();
        }
    }
}
