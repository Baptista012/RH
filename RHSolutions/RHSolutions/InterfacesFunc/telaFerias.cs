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
    public partial class telaFerias : Form
    {
        public telaFerias()
        {
            InitializeComponent();
        }

        private void telaFerias_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rhdbDataSet1.FUNCIONARIO'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOTableAdapter.Fill(this.rhdbDataSet1.FUNCIONARIO);

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Menu = new Form4();
            Menu.ShowDialog();
            this.Close();
        }
    }
}
