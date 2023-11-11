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
                _funcionarioData.CpfFunc = Convert.ToInt32( MtxCpf.Text);
                _funcionarioData.Funcional = Convert.ToInt32(txFuncional);
                _funcionarioData.TelefoneFunc = Convert.ToInt32(MtxTelefone);
                _funcionarioData.CargoFunc = TxCargo.Text;
                _funcionarioData.SalarioFunc = Convert.ToDouble(txSalario);
                _funcionarioData.Email = txEmail.Text;
                _funcionarioData.Senha = mtxSenha.Text;
                _funcionarioData.VAuxilioAlimentacao = Convert.ToInt32(txValeAlim);
                _funcionarioData.VAuxilioTransporte = Convert.ToInt32(txValeTrans);
                _funcionarioData.EnderecoFunc = txEnder.Text;
                _funcionarioData.Inicio = Convert.ToDateTime(MtxtInicio);
                _funcionarioData.Fim = Convert.ToDateTime(MtxtFim);

               

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
                _empresaData.CnpjEmpresa = Convert.ToInt32(MtxCnpjEmpr);
                _empresaData.NomeEmpresa = txNomeEmp.Text;
                _empresaData.EnderEmpresa = txEnderecoEmp.Text;
                _empresaData.TelefoneEmpresa = Convert.ToInt32(MtxTelEmp);

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

        }

        private void BTexcluirEmp_Click(object sender, EventArgs e)
        {
            EmpresaData exempresaData = new EmpresaData();
            CadastroEmpresa excadastroEmpresa = new CadastroEmpresa();

            exempresaData.CnpjEmpresa = Convert.ToInt32(MtxExEmp);
            excadastroEmpresa.ExcluirEmpresa(exempresaData);
        }
    }
}
