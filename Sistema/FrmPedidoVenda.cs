using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FrmPedidoVenda : Form
    {
        public FrmPedidoVenda()
        {
            InitializeComponent();
        }

        private void FrmPedidoVenda_Load(object sender, EventArgs e)
        {
            CarregaGrid();

        }
        public void CarregaGrid()
        {
            Conexao c = new Conexao();


            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT id as Codigo, dataemissao , status, totalpedido FROM pedidovenda";

            try
            {
                c.AbrirConexao();
                MySqlDataAdapter leitura = new MySqlDataAdapter(SELECT);
                DataTable dt = new DataTable();

                leitura.Fill(dt);
                dataGridView1.DataSource = dt;
                c.FecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Carregar o Grid!");


            }

        }

        private void TsbNovo_Click(object sender, EventArgs e)
        {

        }
    }
}
