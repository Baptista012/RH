using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RHSolutions.Data;

namespace RHSolutions.Controladores
{
    class CadastroFuncio 
    {
        public string conexaoSql = @"Data Source=LOCALHOST;Initial Catalog=RHSOLUTIONS;Integrated Security=True";
        public bool IncluirFuncionario(FuncionarioData _funcionarioData)
        {
            SqlConnection conexaoDB = new SqlConnection(conexaoSql);
            try
            {
                conexaoDB.Open();
                string InicioForma = _funcionarioData.Inicio.ToString("dd/MM/yyyy");
                string FimForma = _funcionarioData.Fim.ToString("dd/MM/yyyy");
                string query = "INSERT INTO[dbo].[FUNCIONARIO] (Cpf, Nome, TelefoneFunc, CargoFunc, SalarioFunc, Funcional, " +
                    "VAuxilioAlimentacao, VAuxilioRefeicao, Senha, Email, DataInicio, DataFim)" +
                    $" VALUES('{_funcionarioData.CpfFunc}', '{_funcionarioData.NomeFunc}', '{_funcionarioData.TelefoneFunc}', '{_funcionarioData.CargoFunc}', '{_funcionarioData.SalarioFunc}', " +
                    $"'{_funcionarioData.Funcional}', '{_funcionarioData.VAuxilioAlimentacao}', '{_funcionarioData.VAuxilioTransporte}', '{_funcionarioData.Senha}', '{_funcionarioData.Email}', " +
                    $"'{InicioForma}', '{FimForma}' )";

                SqlCommand cmd = new SqlCommand(query, conexaoDB);


               
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conexaoDB.Close();
                    return true;
                }
                else{
                    conexaoDB.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                conexaoDB.Close();
                throw;
            }

        }
        public void ExcluirFunc()
        {

        }
    }
}
