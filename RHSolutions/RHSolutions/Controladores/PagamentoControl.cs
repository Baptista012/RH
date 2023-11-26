using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RHSolutions.Data;

namespace RHSolutions.Controladores
{
    class PagamentoControl
    {
        public void FolhaFuncionario(FuncionarioData funcionarioPag)
        {
            SqlConnection conexaoDB = new SqlConnection(SQLConect.conexaoSql);
            try
            {
                conexaoDB.Open();
                string consulta = $"SELECT Cpf, SalarioFunc, VAuxilioAlimentacao, VAuxilioRefeicao FROM FUNCIONARIO WHERE Cpf = '{funcionarioPag.CpfFunc}'";
                using (SqlCommand command = new SqlCommand(consulta, conexaoDB))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Extrair os valores do banco de dados
                            string cpf = reader["Cpf"].ToString();
                            double salario = Convert.ToDouble(reader["SalarioFunc"]);
                            double valimentacao = Convert.ToDouble(reader["VAuxilioAlimentacao"]);
                            double vRefeicao = Convert.ToDouble(reader["VAuxilioRefeicao"]);                         

                            // Realizar operações desejadas, como atribuir os valores
                            funcionarioPag.SalarioBruto = salario;
                            funcionarioPag.Salario = salario;
                            funcionarioPag.Vales = vRefeicao +  valimentacao;


                        }
                        conexaoDB.Close();
                    }

                }
            }
            catch (Exception)
            {
                conexaoDB.Close();
                throw;

            }
        }

        public double ResInss(FuncionarioData funcionarioPag)
        {
            try
            {
                double x = funcionarioPag.SalarioBruto;
                if (x <= 1320)
                {
                    funcionarioPag.PorInss = "7%";
                    x = (x * 7) / 100;
                    return x;
                }
                else if (x >= 1321 && x <= 2571)
                {
                    funcionarioPag.PorInss = "9%";
                    x -= 1320;
                    x = (x * 9) / 100;
                    x += 99;
                    return x;
                }
                else if (x >= 2572 && x <= 3856)
                {
                    funcionarioPag.PorInss = "12%";
                    x -= 2571.29;
                    x = (x * 12) / 100;
                    x += 99;
                    x += 112.62;
                    return x;
                }
                else if (x >= 3857 && x <= 7507.49)
                {
                    funcionarioPag.PorInss = "14%";
                    x -= 3650.55;
                    x = (x * 14) / 100;
                    x += 99;
                    x += 112.62;
                    x += 511.07;
                    return x;
                }
                else if (x > 7507.49)
                {
                    funcionarioPag.PorInss = "14%";
                    return x = 876.97;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public double ResIrrf(FuncionarioData funcionarioPag)
        {
            double x = funcionarioPag.Salario;
            if (x < 2112)
            {
                funcionarioPag.PorIrrf = "0%";
                return x = 0;
            }
            else if (x > 2112 && x <= 2826.65)
            {
                funcionarioPag.PorIrrf = "7,5%";
                x = (x * 7.5) / 100;
                x -= 158.40;
                return x;

            }
            else if (x > 2826.65 && x <= 3751.05)
            {
                funcionarioPag.PorIrrf = "15%";
                x = (x * 15) / 100;
                x -= 370.40;
                return x;
            }
            else if (x > 3751.05 && x <= 4664.68)
            {
                funcionarioPag.PorIrrf = "22,5%";
                x = (x * 22.5) / 100;
                x -= 651.73;
                return x;
            }
            else if (x > 4664.68)
            {
                funcionarioPag.PorIrrf = "27,5%";
                x = (x * 27.5) / 100;
                x -= 884.96;
                return x;
            }
            else
            { return 0; }
        }
        public double ResFgts(FuncionarioData funcionarioPag)
        {
            funcionarioPag.PorFgts = "8%";
            double x = funcionarioPag.SalarioBruto;
            x = (x * 8) / 100;
            return x;
        }

    }
}
