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

    
        private void telaPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'rHSOLUTIONSDataSet.FUNCIONARIO'. Você pode movê-la ou removê-la conforme necessário.           

        }

       

        private void EmpPagaBT_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexaoDB = new SqlConnection(SQLConect.conexaoSql))
                {
                    conexaoDB.Open();
                    var busca = mtxCnpj.Text.Replace(",", ".");
                    var sqlQuery = $"SELECT a.Cpf, a.SalarioFunc, b.CnpjEmpresa FROM FUNCIONARIO as a INNER JOIN EMPRESA as b ON a.Cpf = b.CpfFuncionario WHERE CnpjEmpresa = '{busca}'";

                    using (SqlCommand command = new SqlCommand(sqlQuery, conexaoDB))
                    {
                        DataTable dataTable = new DataTable();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }

                        // Bind the DataTable to the DataGridView
                        GridEmpresa.DataSource = dataTable;

                        int totalPessoas = dataTable.Rows.Count;
                        decimal totalSalarios = dataTable.AsEnumerable().Sum(row => Convert.ToDecimal(row["SalarioFunc"]));

                        // Exibe os resultados
                        txNFunc.Text = $"Total de Pessoas: {totalPessoas}";
                        txTotalEmp.Text = $"Total de Salários: {totalSalarios:C}";
                    }

                    conexaoDB.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro");
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
                double total = (funcionarioPag.Salario - /*funcionarioPag.Vales */ funcionarioPag.Irrf );
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
                    var sqlQuery = $"SELECT a.Cpf, a.SalarioFunc, b.CnpjEmpresa FROM FUNCIONARIO as a INNER JOIN EMPRESA as b ON a.Cpf = b.CpfFuncionario WHERE CnpjEmpresa = '{busca}'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, conexaoDB))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                GridEmpresa.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("No data found.");
                            }
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
