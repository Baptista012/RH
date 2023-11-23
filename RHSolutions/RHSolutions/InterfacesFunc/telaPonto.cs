using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RHSolutions.Controladores;

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

        private void PesquisarBt_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexaoDB = new SqlConnection(SQLConect.conexaoSql))
                {
                    conexaoDB.Open();
                    var busca = MtxtCpf.Text.Replace(",", ".");
                    var sqlQuery = $"SELECT * FROM PONTO WHERE Cpf = '{busca}'";                    
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conexaoDB))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            GridPonto.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}
