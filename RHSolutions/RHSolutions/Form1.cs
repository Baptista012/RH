using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHSolutions
{
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Login = new Form2();
            Login.ShowDialog();
            this.Close();
        }
    }
}
