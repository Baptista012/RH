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
using System.Globalization;

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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmpPagaBT_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexaoDB = new SqlConnection(SQLConect.conexaoSql))
                {
                    conexaoDB.Open();

                    string query = "SELECT DISTINCT a.Cpf, a.SalarioFunc, b.CnpjEmpresa " +
                                   "FROM FUNCIONARIO as a " +
                                   "INNER JOIN EMPRESA as b ON a.Cpf = b.CpfFuncionario " +
                                   "WHERE CnpjEmpresa = @CnpjEmpresa";

                    using (SqlCommand command = new SqlCommand(query, conexaoDB))
                    {
                        command.Parameters.AddWithValue("@CnpjEmpresa", mtxCnpj.Text.Replace(",", "."));

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int totalPessoas = 0;
                            decimal totalSalarios = 0;

                            while (reader.Read())
                            {
                                totalPessoas++;

                                // Adiciona o salário ao total
                                totalSalarios += Convert.ToDecimal(reader["SalarioFunc"]);
                            }

                            // Exibe os resultados
                            txNFunc.Text = $"Total de Pessoas: {totalPessoas}";
                            txTotalEmp.Text = $"Total de Salários: {totalSalarios:C}";
                        }
                    }
                    conexaoDB.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                txInss.Text = ($"Com: {funcionarioPag.PorInss} , O total é: R$" +funcionarioPag.Inss.ToString("F2", CultureInfo.InvariantCulture));
                txIrrf.Text = ($"Com: {funcionarioPag.PorIrrf} , O total é: R$" +funcionarioPag.Irrf.ToString("F2", CultureInfo.InvariantCulture));
                txFgts.Text = ($"Com: {funcionarioPag.PorFgts} , O total é: R$" +funcionarioPag.Fgts.ToString("F2",CultureInfo.InvariantCulture));
                txTotal.Text = ("R$: "+ total.ToString("F2",CultureInfo.InvariantCulture));
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
                    conexaoDB.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void PesquisarEmpBT_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexaoDB = new SqlConnection(SQLConect.conexaoSql))
                {
                    conexaoDB.Open();
                    var busca = mtxCnpj.Text.Replace(",", ".");
                    var sqlQuery = $"SELECT a.Nome, a.Cpf, a.SalarioFunc, b.NomeEmpresa, b.CnpjEmpresa from FUNCIONARIO as a inner join EMPRESA as b on  a.Cpf = b.CpfFuncionario where CnpjEmpresa = '{busca}'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conexaoDB))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            GridEmpresa.DataSource = dt;
                        }
                    }
                    conexaoDB.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        
    }
}
