using System;

namespace Sistema.Entidades
{
    class ClientePessoaFisica : Cliente
    {
        public string CPF { get; set; }
        public int Sexo { get; set; }

        public ClientePessoaFisica()
        {

        }

        public ClientePessoaFisica(int codCliente, string nome, string email, DateTime dataNascimento, string cPF, int sexo)
            : base(codCliente, nome, email, dataNascimento)
        {
            CPF = cPF;
            Sexo = sexo;
        }
    }
}
