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
        public string conexaoSql = @"Data Source=LOCALHOST;Initial Catalog=RHSOLUTIONS;Integrated Security=True";
        public bool Incluirempresa(EmpresaData _empresaData)
        {
            SqlConnection conexaoDB = new SqlConnection(conexaoSql);
            try
            {
                conexaoDB.Open();
                string query = "INSERT INTO[dbo].[EMPRESA] (NomeEmpresa, CnpjEmpresa, EnderEmpresa, TelefoneEmpresa)"
                    +$" VALUES('{_empresaData.NomeEmpresa}', '{_empresaData.CnpjEmpresa}', '{_empresaData.EnderEmpresa}', '{_empresaData.TelefoneEmpresa}') ";


               SqlCommand cmd = new SqlCommand(query, conexaoDB);

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
            catch (Exception)
            {
                conexaoDB.Close();
                throw;
            }

        }
        public void ExcluirEmpresa(EmpresaData exempresaData)
        {
            SqlConnection conexaoDB = new SqlConnection(conexaoSql);
            try
            {
                conexaoDB.Open();
               
                    string queryDEL = "DELETE * FROM [dbo].[EMPRESA] * WHERE CnpjEmpresa = " + $"{exempresaData.CnpjEmpresa}";
                
            }
            catch (Exception)
            {
                conexaoDB.Close();
                throw;
            }
        }
    }
}
  