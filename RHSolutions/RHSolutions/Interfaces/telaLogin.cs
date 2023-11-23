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
using RHSolutions.Interfaces;
using RHSolutions.Data;
using RHSolutions.Controladores;

namespace RHSolutions
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

     

        private void LoginBT_Click(object sender, EventArgs e)
        {
            LoginData loginModel = new LoginData();
            loginModel.Funcional = TxtFuncional.Text;
            loginModel.Senha = TxtSenha.Text;
                
            SqlConnection conexaoDB = new SqlConnection(SQLConect.conexaoSql);

            conexaoDB.Open();
            try
            {

                if ((String.IsNullOrEmpty(TxtFuncional.Text)) || (String.IsNullOrEmpty(TxtSenha.Text)))
                {
                    MessageBox.Show("Não foi possivel fazer o login preencha os campos ");
                    this.Close();
                    telaInicial Tela_um = new telaInicial();
                    Tela_um.ShowDialog();
                    
                    

                }

                string query = $"SELECT Funcional, Senha FROM FUNCIONARIO WHERE Funcional = '{loginModel.Funcional}' AND Senha = '{loginModel.Senha}'";
                SqlCommand command = new SqlCommand(query, conexaoDB);
                SqlDataReader reader = command.ExecuteReader();
                if (!reader.Read())
                {

                    MessageBox.Show("Não foi possivel fazer o login funcional ou senha incorretos");
                   

                }
                else
                {

                    loginModel.Funcional = reader.GetString(0);
                    this.Close();
                    Form4 Menu = new Form4();
                    Menu.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
                            
        }

    }
}

