using MySql.Data.MySqlClient;


namespace Sistema
{
    public class Conexao
    {

        public MySqlConnection conexao = new MySqlConnection("Server= localhost; Database=sasistema; Uid=root; pwd =12345;");
        public void Conectar()
        {
            //string Configuracao = "Server= localhost; Database=sasistema; Uid=root; pwd =12345;";
            

            
        }

        public void AbrirConexao()
        {
            conexao.Open();
        }
        public void FecharConexao()
        {
            conexao.Close();
        }




    }
}
