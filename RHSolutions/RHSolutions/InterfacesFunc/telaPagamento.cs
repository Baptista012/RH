using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHSolutions.Interfaces
{
    public partial class telaPagamento : Form
    {
        public telaPagamento()
        {
            InitializeComponent();
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            Form4 Menu = new Form4();
            Menu.ShowDialog();
            this.Close();
        }

        private void MtxtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void telaPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rHSOLUTIONSDataSet.FUNCIONARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOTableAdapter.Fill(this.rHSOLUTIONSDataSet.FUNCIONARIO);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmpPagaBT_Click(object sender, EventArgs e)
        {

        }
    }
}
