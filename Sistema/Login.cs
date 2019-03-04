using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Sistema.Entidades;

namespace Sistema
{
    public partial class frmLogin : Form
    {
        string usuario;
        public frmLogin()
        {
            InitializeComponent();    
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CarregaCombo();
            cboUsuario.Text = "";

            //Recebe a data do dia mais o horário
            DateTime data = DateTime.Now;
            lbldata.Text = data.ToString();
        }

        public void CarregaCombo()
        {
            Conexao c = new Conexao();


            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT usuario FROM usuario";

            try
            {
                c.AbrirConexao();
                MySqlDataReader leitura = SELECT.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(leitura);
                cboUsuario.DisplayMember = "usuario";
                cboUsuario.DataSource = dt;
                c.FecharConexao();

            }
            catch (Exception)
            {

                MessageBox.Show("Erro");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Conexao c = new Conexao();
            Usuarios usuarios = new Usuarios();
            frmPrincipal principal = new frmPrincipal();
            FrmCadUsuarios cad = new FrmCadUsuarios();


            var senha = cad.criptografaSHA512(txtSenha.Text);

            //string usuario;
            //string senha;
            //MySqlConnection conexao = new MySqlConnection("Server= localhost; Database=sasistema; Uid=root; pwd =12345;");

            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT usuario, senha FROM usuario WHERE usuario =@User AND senha =@Pass";
            SELECT.Parameters.AddWithValue("@User", usuario);
            SELECT.Parameters.AddWithValue("@Pass", senha);



            try
            {
                c.AbrirConexao();
                MySqlDataReader leitura = SELECT.ExecuteReader();


                if (leitura.Read())
                {
                    usuarios.Usuario = leitura[0].ToString();
                    usuarios.Senha = leitura[1].ToString();



                    if (usuario == usuarios.Usuario && senha == usuarios.Senha)
                    {
                        MessageBox.Show("Bem vindo ao Sistema", "Bem Vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        principal.Show();
                        this.Hide();



                    }
                    else
                    {
                        MessageBox.Show("Usuario e senha não conferem!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario e senha não conferem!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Erro"); ;
            }
                

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexao c = new Conexao();


            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT usuario FROM usuario WHERE usuario =@user";
            SELECT.Parameters.AddWithValue("@User", cboUsuario.Text);

            try
            {
                c.AbrirConexao();
                MySqlDataReader leitura = SELECT.ExecuteReader();

                if (leitura.Read())
                {
                    usuario = leitura[0].ToString();

                }
                
                //DataTable dt = new DataTable();
                //dt.Load(leitura);
                //cboUsuario.DisplayMember = "usuario";
                //cboUsuario.DataSource = dt;
                
                c.FecharConexao();

            }
            catch (Exception)
            {

                MessageBox.Show("Erro"); ;
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void cboUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
