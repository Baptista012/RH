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

namespace RHSolutions
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void VoltarBT_Click(object sender, EventArgs e)
        {
            Form4 Menu = new Form4();
            Menu.ShowDialog();
            this.Close();
        }

        private void txNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarBT_Click_1(object sender, EventArgs e)
        {
            FuncionarioData _funcionarioData = new FuncionarioData();
            CadastroFuncio _cadastroFuncio = new CadastroFuncio();
            bool retorno = false;
            try
            {
               
                _funcionarioData.NomeFunc = txNome.Text;
                _funcionarioData.CpfFunc =  MtxCpf.Text.Replace("," ,".");
                _funcionarioData.Funcional = txFuncional.Text;
                _funcionarioData.TelefoneFunc = MtxTelefone.Text;
                _funcionarioData.CargoFunc = TxCargo.Text;
                _funcionarioData.SalarioFunc = float.Parse(txSalario.Text);
                _funcionarioData.Email = txEmail.Text;
                _funcionarioData.Senha = mtxSenha.Text;
                _funcionarioData.VAuxilioAlimentacao = float.Parse(txValeAlim.Text);
                _funcionarioData.VAuxlioRefeicao = float.Parse(txValeRefei.Text);
                _funcionarioData.ValeTransporte = cbxValeTrans.Text.Substring(0,1) == "S" ? "S" : "N";
                _funcionarioData.Inicio = Convert.ToDateTime(MtxtInicio.Text);
                _funcionarioData.Fim = Convert.ToDateTime(MtxtFim.Text);
                _funcionarioData.Cnpj = mTxtCnpjFunc.Text.Replace(",", ".");
                _funcionarioData.Endereco = txEnder.Text;
                _funcionarioData.Cidade = txCidade.Text;
                _funcionarioData.Cep = mTxtCep.Text;
                _funcionarioData.Numero = Convert.ToInt32(txNumEnd.Text);

               

                retorno = _cadastroFuncio.IncluirFuncionario(_funcionarioData);
                if (retorno)
                {
                    MessageBox.Show("Funcionário cadastrado");
                }
                else
                {
                    MessageBox.Show("Não foi possível fazer o cadastro ");
                }
            }
             catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void BTCadastrarEmp_Click(object sender, EventArgs e)
        {
            EmpresaData _empresaData = new EmpresaData();
            CadastroEmpresa _cadastroEmpresa = new CadastroEmpresa();
            bool retorno = false;
            try
            {
                _empresaData.CnpjEmpresa = MtxCnpjEmpr.Text.Replace(",", ".");
                _empresaData.NomeEmpresa = txNomeEmp.Text;
                _empresaData.EnderEmpresa = txEnderecoEmp.Text;
                _empresaData.TelefoneEmpresa = MtxTelEmp.Text;

                retorno = _cadastroEmpresa.Incluirempresa(_empresaData);
                if (retorno)
                {
                    MessageBox.Show("Empresa cadastrada");
                }
                else
                {
                    MessageBox.Show("Não foi possível fazer o cadastro ");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void BTExcluirfunc_Click(object sender, EventArgs e)
        {
            bool retorno = false;
            FuncionarioData exfuncionarioData = new FuncionarioData();
            CadastroFuncio excadastroFuncio = new CadastroFuncio();
            try
            {
                exfuncionarioData.CpfFunc = MtxExcFunc.Text.Replace(",",".");
                retorno = excadastroFuncio.ExcluirFunc(exfuncionarioData);
                if (retorno)
                {
                    MessageBox.Show("Funcionário excluido.");
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o funcionário");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void BTexcluirEmp_Click(object sender, EventArgs e)
        {
            bool retorno = false;
            EmpresaData exempresaData = new EmpresaData();
            CadastroEmpresa excadastroEmpresa = new CadastroEmpresa();
            try
            {
                exempresaData.CnpjEmpresa = MtxExEmp.Text.Replace(",", ".");
                retorno = excadastroEmpresa.ExcluirEmpresa(exempresaData);
                if (retorno)
                {
                    MessageBox.Show("Empresa excluida");
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir a empresa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

       
    }
}
