using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RHSolutions.Data;

namespace RHSolutions.Controladores
{
    class CadastroEmpresa
    {
        
        public bool Incluirempresa(EmpresaData _empresaData)
        {
            _empresaData.CpfPadrao = "123.456.789-01";
            SqlConnection conexaoDB = new SqlConnection(SQLConect.conexaoSql);
            try
            {
                conexaoDB.Open();
                /* string query = "INSERT INTO[dbo].[EMPRESA] (NomeEmpresa, CnpjEmpresa, EnderEmpresa, TelefoneEmpresa)"
                     +$" VALUES('{_empresaData.NomeEmpresa}', '{_empresaData.CnpjEmpresa}', '{_empresaData.EnderEmpresa}', '{_empresaData.TelefoneEmpresa}') ";
                */
                string query = "INSERT INTO[dbo].[EMPRESA] (CpfFuncionario, NomeEmpresa, CnpjEmpresa, EnderEmpresa, TelefoneEmpresa)" +
                    "VALUES(@CpfFuncionario, @NomeEmpresa, @CnpjEmpresa, @EnderEmpresa, @TelefoneEmpresa)";


                using (SqlCommand cmd = new SqlCommand(query, conexaoDB))
                {
                    cmd.Parameters.AddWithValue("@CpfFuncionario",_empresaData.CpfPadrao);
                    cmd.Parameters.AddWithValue("@NomeEmpresa", _empresaData.NomeEmpresa);
                    cmd.Parameters.AddWithValue("@CnpjEmpresa", _empresaData.CnpjEmpresa);
                    cmd.Parameters.AddWithValue("@EnderEmpresa", _empresaData.EnderEmpresa);
                    cmd.Parameters.AddWithValue("@TelefoneEmpresa", _empresaData.TelefoneEmpresa);
                    if (cmd.ExecuteNonQuery() > 0)
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
        public bool ExcluirEmpresa(EmpresaData exempresaData)
        {
            SqlConnection conexaoDB = new SqlConnection(SQLConect.conexaoSql);
            try
            {
                conexaoDB.Open();
               
                string queryDEL = $"DELETE FROM [dbo].[EMPRESA] WHERE CnpjEmpresa = '{exempresaData.CnpjEmpresa}'";
                SqlCommand Del = new SqlCommand(queryDEL, conexaoDB);
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

            }
            catch (Exception)
            {
                conexaoDB.Close();
                throw;
            }
        }
    }
}
  