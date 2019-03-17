using MySql.Data.MySqlClient;
using Sistema.Entidades;
using System;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace Sistema
{
    public partial class FrmPedidoVenda : Form
    {
        //private string controle;
        //private bool carregagrid;
        //Produto prod = new Produto();
        PedidoVenda pedido = new PedidoVenda();
        //PedidoItens itens = new PedidoItens();
        private double valor;

        public FrmPedidoVenda()
        {
            InitializeComponent();
        }

        private void FrmPedidoVenda_Load(object sender, EventArgs e)
        {
            TsbGravar.Enabled = false;
            TsbCancelar.Enabled = false;

            //Bloqueia os campos cliente e vendedor
            txtCodCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtCodVendedor.Enabled = false;
            txtNomeVendedor.Enabled = false;
            cboCondPagto.Enabled = false;
            txtDataPedido.Enabled = false;
            txtNumPedido.Enabled = false;

            //Bloqueia campos dos itens

            txtCodProduto.Enabled = false;
            txtCodBarras.Enabled = false;
            txtDescricaoProd.Enabled = false;
            txtQuantidade.Enabled = false;
            txtPreco.Enabled = false;
            btnIncluir.Enabled = false;
            btnExcluir.Enabled = false;


            //bloqueia a edição da celula no datagrid
            dataGridView1.ReadOnly = true;

            
            

            //Formatar o Grid
            FormataGrid();

            //Carregar o Grid de identificação do pedido
            CarregaGrid();

            //Oculta a coluna Senha para não exibri no Grid
            dataGridView1.Columns["id_vendedor"].Visible = false;
            dataGridView1.Columns["nomevendedor"].Visible = false;

            //Carrega os campos do datagrid nos textbox
            txtNumPedido.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtCodCliente.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();

            txtNomeCliente.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            txtDataPedido.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();

            txtCodVendedor.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            txtNomeVendedor.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();

            CarregaCombo();

        }



        public void CarregaGrid()
        {
            Conexao c = new Conexao();


            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT p.id AS Pedido, c.id AS Codigo, c.nome AS Cliente, p.dataemissao AS Emissao, p.Status, p.totalpedido AS Total, p.id_vendedor , v.nomeVendedor FROM pedidovenda p INNER JOIN clientes c ON p.id_cliente = c.id INNER JOIN vendedor v ON v.id = p.id_vendedor ORDER BY p.id ASC;";


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

            //Desblqueia campos referente a clientes e vendedor
            txtCodCliente.Enabled = true;
            txtCodVendedor.Enabled = true;
            cboCondPagto.Enabled = true;

            //Desbloqueia campos referente a Itens
            txtCodProduto.Enabled = true;
            txtCodBarras.Enabled = true;
            //txtDescricaoProd.Enabled = true;
            txtQuantidade.Enabled = true;
            txtPreco.Enabled = true;
            btnIncluir.Enabled = true;
            btnExcluir.Enabled = true;

            LimparDados();
            txtCodCliente.Focus();

            //Pega a data da Emissão do Pedido
            DateTime data = DateTime.Now;
            txtDataPedido.Text = data.ToString("dd/MM/yyyy");



        }

        private void TsbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsbGravar_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Cliente cliente = new Cliente();
            cliente.Nome = txtDescricaoProd.Text;
            cliente.CodCliente = int.Parse(txtCodCliente.Text);

            //pedido.CodPedido = int.Parse(txtNumPedido.Text);
            pedido.Data = dt;
            pedido.Cliente = cliente;
            pedido.TotalPedido = double.Parse(txtSubTotal.Text);

            Vendedor vendedor = new Vendedor(int.Parse(txtCodVendedor.Text), txtNomeVendedor.Text);
            Produto prod = new Produto();
            PedidoItens itens = new PedidoItens(int.Parse(txtQuantidade.Text), double.Parse(txtPreco.Text), prod);

            Conexao c = new Conexao();
            try
            {
               

                c.AbrirConexao();
                MySqlCommand INSERT = new MySqlCommand("INSERT INTO pedidovenda ( dataemissao, totalpedido, id_cliente, id_vendedor) " +
                                                        "VALUES(@Dataemissao, @Totalpedido, @Id_cliente, @Id_vendedor)", c.conexao);
                INSERT.Parameters.AddWithValue("@Dataemissao", pedido.Data);
                INSERT.Parameters.AddWithValue("@Totalpedido", pedido.TotalPedido);
                INSERT.Parameters.AddWithValue("@Id_cliente", pedido.Cliente.CodCliente);
                INSERT.Parameters.AddWithValue("@Id_vendedor", vendedor.CodVendedor);

                INSERT.ExecuteNonQuery();

                MySqlCommand INSERTPROD = new MySqlCommand("INSERT INTO pedidoItens ( id_pedidovenda, id_produto, descricaoprod, quatidade, preco) " +
                                                       "VALUES(@Id_pedidovenda, @Id_produto, @Descricaoprod, @Quantidade, @Preco)", c.conexao);
                INSERTPROD.Parameters.AddWithValue("@Id_pedidovenda", pedido.CodPedido);
                INSERTPROD.Parameters.AddWithValue("@Id_produto", itens.Produto.CodInterno);
                INSERTPROD.Parameters.AddWithValue("@Descricaoprod", itens.Produto.Descricao);
                INSERTPROD.Parameters.AddWithValue("@Quantidade", itens.Quantidade);
                INSERTPROD.Parameters.AddWithValue("@Preco", itens.Preco);

                INSERTPROD.ExecuteNonQuery();

                MessageBox.Show("Pedido criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TsbCancelar_Click(TsbCancelar, new EventArgs());

                CarregaGrid();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("MySQL Não conectado!", "Erro na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Erro", ex);

            }

            finally
            {
                c.FecharConexao();
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

            txtCodProduto.Enabled = false;
            txtCodBarras.Enabled = false;
            txtDescricaoProd.Enabled = false;
            txtQuantidade.Enabled = false;
            txtPreco.Enabled = false;
            btnIncluir.Enabled = false;
            btnExcluir.Enabled = false;

            LimparDados();
            LimparProdutos();

        }

        private void LimparDados()
        {
            txtCodCliente.Text = String.Empty;
            txtNomeCliente.Text = String.Empty;
            txtCodVendedor.Text = String.Empty;
            txtNomeVendedor.Text = String.Empty;
            cboCondPagto.Text = String.Empty;
            txtNumPedido.Text = String.Empty;
            txtDataPedido.Text = String.Empty;
        }

        private void LimparProdutos()
        {
            txtCodProduto.Text = String.Empty;
            txtCodBarras.Text = String.Empty;
            txtDescricaoProd.Text = String.Empty;
            txtQuantidade.Text = String.Empty;
            txtPreco.Text = String.Empty;
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            TsbNovo.Enabled = false;
            TsbEditar.Enabled = false;
            TsbGravar.Enabled = true;
            TsbCancelar.Enabled = true;
            TsbExcluir.Enabled = false;

            txtCodCliente.Enabled = true;
            //txtNomeCliente.Enabled = true;
            txtCodVendedor.Enabled = true;
            //txtNomeVendedor.Enabled = true;

            cboCondPagto.Enabled = true;

            txtCodProduto.Enabled = true;
            txtCodBarras.Enabled = true;
            txtDescricaoProd.Enabled = true;
            txtQuantidade.Enabled = true;
            txtPreco.Enabled = true;

            txtCodCliente.Focus();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Produto prod = new Produto(int.Parse(txtCodProduto.Text), txtDescricaoProd.Text, txtCodBarras.Text, double.Parse(txtPreco.Text, CultureInfo.InvariantCulture));
            //PedidoVenda pedido = new PedidoVenda();
            PedidoItens itens = new PedidoItens(int.Parse(txtQuantidade.Text), double.Parse(txtPreco.Text), prod);

            itens.Subtotal = itens.SubTotal();
            
            valor += itens.SubTotal();
            //pedido.TotalPedido = pedido.TotalPedido + valor;

            txtSubTotal.Text = valor.ToString("F2", CultureInfo.InvariantCulture);

            itemsBindingSource.Add(itens);

            //pedido.AdicionarItem(itens);
            LimparProdutos();
            txtCodProduto.Focus();

            //dataGridView2.DataSource = pedido.bindingSource1;
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
                MessageBox.Show("Informe o código do cliente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodCliente.Focus();
            }
            else
            {
                Cliente cliente = new Cliente
                {
                    CodCliente = int.Parse(txtCodCliente.Text),
                    Nome = txtNomeCliente.Text


                };

                Conexao c = new Conexao();

                MySqlCommand SELECT = c.conexao.CreateCommand();
                SELECT.CommandType = CommandType.Text;
                SELECT.CommandText = "SELECT * FROM clientes WHERE id =@id";
                SELECT.Parameters.AddWithValue("@id", txtCodCliente.Text);


                try
                {
                    c.AbrirConexao();
                    MySqlDataReader leitura = SELECT.ExecuteReader();

                    if (leitura.Read())
                    {
                        txtNomeCliente.Text = leitura["Nome"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodCliente.Text = String.Empty;
                        txtCodCliente.Focus();
                    }
                    c.FecharConexao();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao localizar o Cliente!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }



        public void EnterDoMouse(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
        private void txtCodCliente_KeyDown(object sender, KeyEventArgs e)
        {
            EnterDoMouse(sender, e);
        }

        private void txtCodVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            EnterDoMouse(sender, e);
        }

        private void txtCodVendedor_Validated(object sender, EventArgs e)
        {
            if (txtCodVendedor.Text == String.Empty)
            {
                MessageBox.Show("Informe o código do Vendedor!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodVendedor.Focus();
            }
            else
            {
                //Vendedor vendedor = new Vendedor(int.Parse(txtCodVendedor.Text), txtNomeVendedor.Text);


                Conexao c = new Conexao();

                MySqlCommand SELECT = c.conexao.CreateCommand();
                SELECT.CommandType = CommandType.Text;
                SELECT.CommandText = "SELECT * FROM vendedor WHERE id =@id";
                SELECT.Parameters.AddWithValue("@id", txtCodVendedor.Text);


                try
                {
                    c.AbrirConexao();
                    MySqlDataReader leitura = SELECT.ExecuteReader();

                    if (leitura.Read())
                    {
                        txtNomeVendedor.Text = leitura["nomeVendedor"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Vendedor não localizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodVendedor.Text = String.Empty;
                        txtCodVendedor.Focus();
                    }
                    c.FecharConexao();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao localizar o Vendedor!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtCodProduto_Validated(object sender, EventArgs e)
        {
            if (txtCodProduto.Text == String.Empty)
            {
                MessageBox.Show("Informe o código do Produto!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodProduto.Focus();
            }
            else
            {
                //Produto produto = new Produto(int.Parse(txtCodProduto.Text), txtDescricaoProd.Text, txtCodBarras.Text, double.Parse(txtPreco.Text));


                Conexao c = new Conexao();

                MySqlCommand SELECT = c.conexao.CreateCommand();
                SELECT.CommandType = CommandType.Text;
                SELECT.CommandText = "SELECT * FROM Produto WHERE id =@id";
                SELECT.Parameters.AddWithValue("@id", txtCodProduto.Text);


                try
                {
                    c.AbrirConexao();
                    MySqlDataReader leitura = SELECT.ExecuteReader();

                    if (leitura.Read())
                    {
                        txtCodBarras.Text = leitura["codbarra"].ToString();
                        txtDescricaoProd.Text = leitura["descricao"].ToString();
                        txtPreco.Text = leitura["precovenda"].ToString();
                        txtQuantidade.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Produto não localizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodProduto.Focus();
                        txtCodProduto.Text = String.Empty;

                    }

                    c.FecharConexao();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao localizar o Produto!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void CarregaCombo()
        {
            Conexao c = new Conexao();


            MySqlCommand SELECT = c.conexao.CreateCommand();
            SELECT.CommandType = CommandType.Text;
            SELECT.CommandText = "SELECT * FROM condpagto";

            try
            {
                c.AbrirConexao();
                MySqlDataReader leitura = SELECT.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(leitura);
                cboCondPagto.DisplayMember = "descricao";
                cboCondPagto.DataSource = dt;



                c.FecharConexao();

            }
            catch (Exception)
            {

                MessageBox.Show("Erro");
            }
        }

        private void FormataGrid()
        {
            /*********Grid Dados******/
            //removendo o indicador do Datagrid do lado esquerdo da tela.
            dataGridView1.RowHeadersVisible = false;

            //Fundo do datagrid cinza claro
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;

            //Configura o grid para preencher a tela toda
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Remover a ultima linha do Datagrid
            dataGridView1.AllowUserToAddRows = false;

            /*********Grid Itens******/
            //removendo o indicador do Datagrid do lado esquerdo da tela.
            dataGridView2.RowHeadersVisible = false;

            //Fundo do datagrid cinza claro
            dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;

            //Configura o grid para preencher a tela toda
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Remover a ultima linha do Datagrid2
            dataGridView2.AllowUserToAddRows = false;


        }

        private void cboCondPagto_KeyDown(object sender, KeyEventArgs e)
        {
            //EnterDoMouse(sender, e);
            txtCodProduto.Focus();
        }

        private void txtCodProduto_KeyDown(object sender, KeyEventArgs e)
        {
            EnterDoMouse(sender, e);
        }

        private void txtCodBarras_KeyDown(object sender, KeyEventArgs e)
        {
            EnterDoMouse(sender, e);
        }

        private void txtDescricaoProd_KeyDown(object sender, KeyEventArgs e)
        {
            EnterDoMouse(sender, e);
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            EnterDoMouse(sender, e);
        }

        private void txtPreco_KeyDown(object sender, KeyEventArgs e)
        {
            EnterDoMouse(sender, e);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                dataGridView2.Rows.RemoveAt(row.Index);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                txtNumPedido.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCodCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtNomeCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDataPedido.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                txtCodVendedor.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtNomeVendedor.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }
    }

}