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
    public partial class telaFerias : Form
    {
        public telaFerias()
        {
            InitializeComponent();
        }

        private void telaFerias_Load(object sender, EventArgs e)
        {
          

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
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
                    var busca = buscarCPF.Text.Replace(",", ".");
                    var sqlQuery = $"SELECT * FROM FERIAS where Cpf = '{busca}'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conexaoDB))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            GridFerias.DataSource = dt;
                        }
                    }
                    conexaoDB.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show( "Erro: "+ex);
            }
        }
    }
}
