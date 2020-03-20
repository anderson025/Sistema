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
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void btnDataNascimento_Click(object sender, EventArgs e)
        {
            monthCalendar1.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtData.Text = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy");
            monthCalendar1.Visible = false;
        }

        private void optFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (optJuridica.Checked)
            {
                lblCPF.Text = "CNPJ:";
                lblNome.Text = "Razão Social:";
                txtFantasia.Enabled = true;
            }
            else
            {
                lblCPF.Text = "CPF:";
                lblNome.Text = "Nome:";
                txtFantasia.Enabled = false;
            }
        }

        private void CadCliente_Load(object sender, EventArgs e)
        {
            txtFantasia.Enabled = false;
        }
    }
}
