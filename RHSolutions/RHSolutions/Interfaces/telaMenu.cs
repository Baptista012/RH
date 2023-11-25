using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RHSolutions.Interfaces;
using RHSolutions.Data;

namespace RHSolutions
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void CntrFerias_Click(object sender, EventArgs e)
        {
            telaFerias tFerias = new telaFerias();
            tFerias.ShowDialog();
            this.Close();
        }

        private void FolhaPonto_Click(object sender, EventArgs e)
        {
            telaPonto tPonto = new telaPonto();
            tPonto.ShowDialog();
            this.Close();
        }

        private void folhaDePagamento_Click(object sender, EventArgs e)
        {
            telaPagamento tPagamento = new telaPagamento();
            tPagamento.ShowDialog();
            this.Close();
        }

        private void CadastreBT_Click(object sender, EventArgs e)
        {
            Form3 Cadastro = new Form3();
            Cadastro.ShowDialog();
            this.Close();
        }

        private void SairBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
