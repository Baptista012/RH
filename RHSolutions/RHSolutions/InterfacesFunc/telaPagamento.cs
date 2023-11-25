using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RHSolutions.Data;
using RHSolutions.Controladores;
using System.Data.SqlClient;

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
            Menu Menu = new Menu();
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

        private void FuncPagaBT_Click(object sender, EventArgs e)
        {
            FuncionarioData funcionarioPag = new FuncionarioData();
            PagamentoControl PagFuncionario = new PagamentoControl();
            try
            {
                funcionarioPag.CpfFunc = MtxtCpf.Text.Replace(",", ".");
                PagFuncionario.FolhaFuncionario(funcionarioPag);
                funcionarioPag.Inss = PagFuncionario.ResInss(funcionarioPag);
                funcionarioPag.Salario = funcionarioPag.Salario - funcionarioPag.Inss;
                funcionarioPag.Irrf = PagFuncionario.ResIrrf(funcionarioPag);
                funcionarioPag.Fgts = PagFuncionario.ResFgts(funcionarioPag);
                double total = (funcionarioPag.Salario - funcionarioPag.Vales - funcionarioPag.Irrf - funcionarioPag.Fgts);
                txVales.Text = Convert.ToString(funcionarioPag.Vales);
                txInss.Text = ($"Com: {funcionarioPag.PorInss}, O total é: {funcionarioPag.Inss}");
                txIrrf.Text = ($"Com: {funcionarioPag.PorIrrf}, O total é: {funcionarioPag.Irrf}");
                txFgts.Text = ($"Com: {funcionarioPag.PorFgts}, O total é: {funcionarioPag.Fgts}");
                Total.Text = Convert.ToString(total);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void PesquisarBt_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexaoDB = new SqlConnection(SQLConect.conexaoSql))
                {
                    conexaoDB.Open();
                    var busca = MtxtCpf.Text.Replace(",", ".");
                    var sqlQuery = $"SELECT * FROM Funcionario where Cpf = '{busca}'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conexaoDB))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            GridFunc.DataSource = dt;
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
