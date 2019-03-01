using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema
{
    public partial class frmSistema : Form
    {
        private int iSelecionado;
        private int controle;

        public frmSistema()
        {

            InitializeComponent();
            iSelecionado = -1;
            controle = 0;
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            

            if (iSelecionado > -1)
            {
                lsbListaNomes.Items[iSelecionado] = txtNome.Text;
                Ordenar();
                bntLimpar_Click(bntLimpar, new EventArgs());
                iSelecionado = -1;
                btnCadastrar.Text = "Cadastrar";
                return;

            }
            lsbListaNomes.Items.Add(txtNome.Text);
            Ordenar();
            bntLimpar_Click(bntLimpar, new EventArgs());


        }

        private void Ordenar()
        {
            //Lista vai conter todos os itens do list box
            ListBox.ObjectCollection lista = lsbListaNomes.Items;
            List<String> listaString = new List<String>();

            foreach (var item in lista)
            {
                listaString.Add(item.ToString());

            }

            listaString = (from s in listaString select s).OrderBy(x => x).ToList();
            lsbListaNomes.Items.Clear();

            foreach (var item in listaString)
            {
                lsbListaNomes.Items.Add(item);
            }

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
        }

        private void lsbListaNomes_DoubleClick(object sender, EventArgs e)
        {
            iSelecionado = lsbListaNomes.SelectedIndex;
            txtNome.Text = lsbListaNomes.Items[iSelecionado].ToString();
            btnCadastrar.Text = "Alterar";
            //lsbListaNomes.Items.RemoveAt(indice);
        }

        private void chkAtivo_CheckStateChanged(object sender, EventArgs e)
        {
            if (controle == -1)
            {
                controle = 0;
                return;
            }

            if (chkAtivo.Checked == true)
            {
                if (MessageBox.Show("Deseja Ativar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    MessageBox.Show("Não ativado");
                    controle = -1;
                    chkAtivo.CheckState = CheckState.Unchecked;
                }
                else
                {
                    MessageBox.Show("Ativado com sucesso!", "Ativado");
                }

            }
            else
            {

                if (MessageBox.Show("Deseja desativar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    MessageBox.Show("Permanecer ativo");
                    controle = -1;
                    chkAtivo.CheckState = CheckState.Checked;

                }
                else
                {
                    MessageBox.Show("Desativado com Sucesso");
                }
                
            }
        }

        
    }
}
