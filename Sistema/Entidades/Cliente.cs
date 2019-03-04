using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF_CNPJ { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime dataNascimento, string cPF_CNPJ)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            CPF_CNPJ = cPF_CNPJ;
        }
    }
}
