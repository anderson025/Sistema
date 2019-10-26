namespace Sistema.Entidades
{
    class Endereco
    {
        public int CodEndereco { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }

        public Endereco()
        {
        }

        public Endereco(int codEndereco, string rua, int numero, string bairro, string cidade, string complemento, string cEP)
        {
            CodEndereco = codEndereco;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Complemento = complemento;
            CEP = cEP;
        }
    }
}
