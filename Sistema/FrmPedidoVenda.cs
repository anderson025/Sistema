using MySql.Data.MySqlClient;
using Sistema.Entidades;
using System;
using System.Data;
using System.Reflection;
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
            TsbGravar.Enabled = false;
            TsbCancelar.Enabled = false;
            txtCodCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtCodVendedor.Enabled = false;
            txtNomeVendedor.Enabled = false;
            cboCondPagto.Enabled = false;



            //Carrega os campos do datagrid nos textbox
            //txtCodCliente.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            //txtNomeCliente.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();


            //bloqueia a edição da celula no datagrid
            dataGridView1.ReadOnly = true;
            CarregaGrid();

        }
        public void CarregaGrid()
        {
            Conexao c = new Conexao();


            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT p.id as Pedido, c.nome as Cliente, p.dataemissao , p.status, p.totalpedido FROM pedidovenda p INNER JOIN clientes c ON p.id_cliente = c.id";

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
            TsbNovo.Enabled = false;
            TsbEditar.Enabled = false;
            TsbGravar.Enabled = true;
            TsbCancelar.Enabled = true;
            TsbExcluir.Enabled = false;

            txtCodCliente.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtCodVendedor.Enabled = true;
            txtNomeVendedor.Enabled = true;
            cboCondPagto.Enabled = true;


        }

        private void TsbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbGravar_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Cliente cliente = new Cliente();
            cliente.Nome = txtDescricao.Text;
            cliente.CodCliente = int.Parse(txtCodCliente.Text);

            PedidoVenda pedido = new PedidoVenda();

            if (true)
            {

            }
        }

        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            TsbNovo.Enabled = true;
            TsbEditar.Enabled = true;
            TsbGravar.Enabled = false;
            TsbCancelar.Enabled = false;
            TsbExcluir.Enabled = true;

            txtCodCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtCodVendedor.Enabled = false;
            txtNomeVendedor.Enabled = false;
            cboCondPagto.Enabled = false;
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            TsbNovo.Enabled = false;
            TsbEditar.Enabled = false;
            TsbGravar.Enabled = true;
            TsbCancelar.Enabled = true;
            TsbExcluir.Enabled = false;

            txtCodCliente.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtCodVendedor.Enabled = true;
            txtNomeVendedor.Enabled = true;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            Produto prod = new Produto(int.Parse(txtCodProduto.Text), txtDescricao.Text, txtCodBarras.Text, double.Parse(txtPreco.Text));

            PedidoVenda pedido = new PedidoVenda();
            PedidoItens itens = new PedidoItens(int.Parse(txtQuantidade.Text), double.Parse(txtPreco.Text), prod);




            pedido.AdicionarItem(itens);

            dataGridView2.DataSource = pedido.Items;
            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dataGridView2.Rows[e.RowIndex].DataBoundItem != null) && (dataGridView2.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dataGridView2.Rows[e.RowIndex].DataBoundItem, dataGridView2.Columns[e.ColumnIndex].DataPropertyName);
            }

        }

        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";
            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;
                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;
                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }
            return retValue;
        }

        private void txtCodCliente_Validated(object sender, EventArgs e)
        {
            if (txtCodCliente.Text == String.Empty)
            {
                MessageBox.Show("Informe o código do cliente!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtCodCliente.Focus();
            }
            
        }
    }
}
