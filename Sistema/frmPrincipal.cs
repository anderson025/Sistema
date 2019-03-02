using System;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadUsuarios cadUsuario = new FrmCadUsuarios();

            cadUsuario.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadProduto produto = new FrmCadProduto();
            produto.Show();
        }

        private void TsbCadUsuario_Click(object sender, EventArgs e)
        {
            FrmCadUsuarios usuario = new FrmCadUsuarios();
            usuario.Show();

        }

        private void TsbCadProduto_Click(object sender, EventArgs e)
        {
            FrmCadProduto produto = new FrmCadProduto();
            produto.Show();
        }

        private void TsbSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja encerrar a aplicação ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
