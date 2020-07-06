using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Sistema.Entidades;
using System.Security.Cryptography;

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

            //Recebe a data do dia mais o horário
            DateTime data = DateTime.Now;
            lbldata.Text = data.ToString();
        }

        public void CarregaCombo()
        {
            Conexao c = new Conexao();


            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT usuario FROM usuario ORDER BY usuario";

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

                MessageBox.Show("Erro no carregamento do componenente combobox! Verifique com suporte!");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Conexao c = new Conexao();
            Usuarios usuarios = new Usuarios();
            frmPrincipal principal = new frmPrincipal();
            CriptografaSenha s = new CriptografaSenha();

            
            var senha = s.criptografaSHA512(txtSenha.Text);            

            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT usuario, senha FROM usuario WHERE usuario =@User AND senha =@Pass";
            SELECT.Parameters.AddWithValue("@User", usuario);
            SELECT.Parameters.AddWithValue("@Pass", senha);

            if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha inválida, verifique!");
                txtSenha.Focus();
            }

            else
            {
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

                    MessageBox.Show("Erro ao verificar usuário e senha."); ;
                }

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
                c.FecharConexao();

            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao selecionar usuário!"); ;
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
