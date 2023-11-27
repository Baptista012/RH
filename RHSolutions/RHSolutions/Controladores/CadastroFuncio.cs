using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RHSolutions.Data;
using RHSolutions.Controladores;

namespace RHSolutions.Controladores
{
    class CadastroFuncio 
    {
        
        public bool IncluirFuncionario(FuncionarioData _funcionarioData)
        {
            SqlConnection conexaoDB = new SqlConnection(SQLConect.conexaoSql);
            try
            {
                conexaoDB.Open();
                string InicioForma = _funcionarioData.Inicio.ToString("dd/MM/yyyy");
                string FimForma = _funcionarioData.Fim.ToString("dd/MM/yyyy");
                /*string query = "INSERT INTO[dbo].[FUNCIONARIO] (Cpf, Nome, TelefoneFunc, CargoFunc, SalarioFunc, Funcional, " +
                    "VAuxilioAlimentacao, VAuxilioRefeicao, Senha, Email, DataInicio, DataFim)" +
                    $" VALUES('{_funcionarioData.CpfFunc}', '{_funcionarioData.NomeFunc}', '{_funcionarioData.TelefoneFunc}', '{_funcionarioData.CargoFunc}', '{_funcionarioData.SalarioFunc}', " +
                    $"'{_funcionarioData.Funcional}', '{_funcionarioData.VAuxilioAlimentacao}', '{_funcionarioData.VAuxilioTransporte}', '{_funcionarioData.Senha}', '{_funcionarioData.Email}', " +
                    $"'{InicioForma}', '{FimForma}' )";*/
                string query = "INSERT INTO[dbo].[FUNCIONARIO] (Cpf, Nome, TelefoneFunc, CargoFunc, SalarioFunc, Funcional, " +
                    "VAuxilioAlimentacao, VAuxilioRefeicao, Senha, Email, DataInicio, DataFim,ValeTransporte)" +
                    $" VALUES(@Cpf, @Nome, @TelefoneFunc, @CargoFunc, @SalarioFunc, @Funcional, " +
                    "@VAuxilioAlimentacao, @VAuxilioRefeicao, @Senha, @Email, @DataInicio, @DataFim, @ValeTransporte)";
                string queryEnd = "INSERT INTO [dbo].[ENDERECOFUNC](Endereco, Numero, Cidade, Cpf, Cep) VALUES(@Endereco, @Numero, @Cidade, @Cpf, @Cep)";
                string queryEmp = "INSERT INTO [dbo].[EMPRESA](CpfFuncionario,CnpjEmpresa) VALUES(@Cpf, @Cnpj)";
                
                using (SqlCommand cmd = new SqlCommand(query, conexaoDB))
                {

                    cmd.Parameters.AddWithValue("@Cpf", _funcionarioData.CpfFunc);
                    cmd.Parameters.AddWithValue("@Nome",_funcionarioData.NomeFunc);
                    cmd.Parameters.AddWithValue("@TelefoneFunc", _funcionarioData.TelefoneFunc);
                    cmd.Parameters.AddWithValue("@CargoFunc", _funcionarioData.CargoFunc);
                    cmd.Parameters.AddWithValue("@SalarioFunc", _funcionarioData.SalarioFunc);
                    cmd.Parameters.AddWithValue("@Funcional", _funcionarioData.Funcional);
                    cmd.Parameters.AddWithValue("@VAuxilioAlimentacao",_funcionarioData.VAuxilioAlimentacao);
                    cmd.Parameters.AddWithValue("@VAuxilioRefeicao", _funcionarioData.VAuxlioRefeicao);
                    cmd.Parameters.AddWithValue("@Senha", _funcionarioData.Senha);
                    cmd.Parameters.AddWithValue("@Email", _funcionarioData.Email);
                    cmd.Parameters.AddWithValue("@DataInicio", InicioForma);
                    cmd.Parameters.AddWithValue("@DataFim", FimForma);
                    cmd.Parameters.AddWithValue("@ValeTransporte", _funcionarioData.ValeTransporte);
                    cmd.ExecuteNonQuery();
                   
                }
                using (SqlCommand Emp = new SqlCommand(queryEmp, conexaoDB))
                {
                    Emp.Parameters.AddWithValue("@Cpf", _funcionarioData.CpfFunc);
                    Emp.Parameters.AddWithValue("@Cnpj", _funcionarioData.Cnpj);
                    Emp.ExecuteNonQuery();
                }
                using (SqlCommand End = new SqlCommand(queryEnd, conexaoDB))
                {
                    End.Parameters.AddWithValue("@Endereco", _funcionarioData.Endereco);
                    End.Parameters.AddWithValue("@Numero", _funcionarioData.Numero);
                    End.Parameters.AddWithValue("@Cidade", _funcionarioData.Cidade);
                    End.Parameters.AddWithValue("@Cpf", _funcionarioData.CpfFunc);
                    End.Parameters.AddWithValue("@Cep", _funcionarioData.Cep);                   
                    if (End.ExecuteNonQuery() > 0)
                    {
                        conexaoDB.Close();
                        return true;
                    }
                    else
                    {
                        conexaoDB.Close();
                        return false;
                    }
                }
                




            }
            catch (Exception)
            {
                conexaoDB.Close();
           
                throw;
            }

        }
        public bool ExcluirFunc(FuncionarioData exfuncionarioData)
        {
            SqlConnection conexaoDB = new SqlConnection(SQLConect.conexaoSql);
            try
            {
                conexaoDB.Open();

                string queryDEL = $"DELETE FROM [dbo].[FUNCIONARIO] WHERE CPF = '{exfuncionarioData.CpfFunc}'";
                SqlCommand Del = new SqlCommand(queryDEL, conexaoDB);
                
                if ( Del.ExecuteNonQuery() >0)
                {
                    conexaoDB.Close();
                    return true;
                }
                else
                {
                    conexaoDB.Close();
                    return false;
                }

                /* string queryDEL = "DELETE FROM [dbo].[FUNCIONARIO] WHERE Cpf = @Cpf ";
                 using (SqlCommand Del = new SqlCommand(queryDEL, conexaoDB))
                 {
                     Del.Parameters.AddWithValue("@Cpf", exfuncionarioData.CpfFunc);
                     if (Del.ExecuteNonQuery() > 0)
                     {
                         conexaoDB.Close();
                         return true;
                     }
                     else
                     {
                         conexaoDB.Close();
                         return false;
                     }
                 }*/
            }
            catch (Exception)
            {
                conexaoDB.Close();
                throw;
            }
        }
    }
}
