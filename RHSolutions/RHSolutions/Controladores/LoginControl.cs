using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RHSolutions.Data;
using System.Data;
using System.Data.SqlClient;

namespace RHSolutions.Controladores
{
    internal class LoginControl
    {
        private static SqlConnection conexaosql;
        public string Login { get; set; }
        public string Senha { get; set; }

        private static SqlConnection conexaoRh()
        {
            conexaosql = new SqlConnection(@"Data Source=localhost;Initial Catalog=RHDB;Integrated Security=True");
            conexaosql.Open();
            return conexaosql;
        }
        /*
        protected bool Valida(LoginData login)
        {
            LoginData loginModel = new LoginData();

            var conexaoSql = @"Data Source=localhost;Initial Catalog=RHDB;Integrated Security=True";
            SqlConnection conexaoDB = new SqlConnection(conexaoSql);
            
            conexaoDB.Open();
            try
            {
                if (login.Funcional == null || login.Senha == null)
                {
                    Mes
                    return false;
                }
                if (login.Funcional == " " || login.Senha == " ")
                {
                    MessageBox.show = "Não foi possivel fazer o login funcional ou senha incorretos";
                    return false;
                }
                 
                string query = $"SELECT Funcional, Senha FROM FUNCIONARIO WHERE Funcional = '{login.Funcional}' AND Senha = '{login.Senha}'";
                SqlCommand command = new SqlCommand(query, conexaoDB);
                SqlDataReader reader = command.ExecuteReader();
                if (!reader.Read())
                {

                    TempData["MensagemErro"] = "Não foi possivel fazer o login funcional ou senha incorretos";
                    return false;

                }
                else
                {
                    loginModel.Funcional = reader.GetString(0);
                 
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            /*public static DataTable ObterUsuarios()
            {
                SqlDataAdapter da = null;
                DataTable dt = new DataTable();
                try
                {
                    using (var cnx = conexaoRh().CreateCommand())
                    {
                        cnx.CommandText = "SELECT * FROM ";
                     }
                }
                catch (Exception ex)
                {
                    throw ex;

                }
            */

    }

}





