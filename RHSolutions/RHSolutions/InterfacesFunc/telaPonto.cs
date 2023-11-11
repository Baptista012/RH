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
    public partial class telaPonto : Form
    {
        public telaPonto()
        {
            InitializeComponent();
        }

        private void telaPonto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rHSOLUTIONSDataSet.PONTO'. Você pode movê-la ou removê-la conforme necessário.
            this.pONTOTableAdapter.Fill(this.rHSOLUTIONSDataSet.PONTO);

        }

        private void MtxtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            Form4 Menu = new Form4();
            Menu.ShowDialog();
            this.Close();
        }
    }
}
