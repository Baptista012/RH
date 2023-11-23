
namespace RHSolutions.Interfaces
{
    partial class telaPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Lpagar = new System.Windows.Forms.Label();
            this.FuncPagaBT = new System.Windows.Forms.Button();
            this.PesquisarBt = new System.Windows.Forms.Button();
            this.MtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MtxtPagaEmp = new System.Windows.Forms.MaskedTextBox();
            this.LPagaEmp = new System.Windows.Forms.Label();
            this.EmpPagaBT = new System.Windows.Forms.Button();
            this.PesquisarEmpBT = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rHSOLUTIONSDataSet = new RHSolutions.RHSOLUTIONSDataSet();
            this.fUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCIONARIOTableAdapter = new RHSolutions.RHSOLUTIONSDataSetTableAdapters.FUNCIONARIOTableAdapter();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoFuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioFuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAuxilioAlimentacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAuxilioRefeicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHSOLUTIONSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtVoltar
            // 
            this.BtVoltar.BackColor = System.Drawing.Color.Coral;
            this.BtVoltar.Location = new System.Drawing.Point(33, 12);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(124, 35);
            this.BtVoltar.TabIndex = 12;
            this.BtVoltar.Text = "< Voltar";
            this.BtVoltar.UseVisualStyleBackColor = false;
            this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.Lpagar);
            this.groupBox1.Controls.Add(this.FuncPagaBT);
            this.groupBox1.Controls.Add(this.PesquisarBt);
            this.groupBox1.Controls.Add(this.MtxtCpf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(54, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(914, 690);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folha de pagamento Funcionário";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(157, 499);
            this.maskedTextBox1.Mask = "$ ";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(247, 26);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // Lpagar
            // 
            this.Lpagar.AutoSize = true;
            this.Lpagar.Location = new System.Drawing.Point(43, 502);
            this.Lpagar.Name = "Lpagar";
            this.Lpagar.Size = new System.Drawing.Size(108, 20);
            this.Lpagar.TabIndex = 15;
            this.Lpagar.Text = "Valor a pagar:";
            // 
            // FuncPagaBT
            // 
            this.FuncPagaBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FuncPagaBT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FuncPagaBT.Location = new System.Drawing.Point(307, 427);
            this.FuncPagaBT.Name = "FuncPagaBT";
            this.FuncPagaBT.Size = new System.Drawing.Size(379, 41);
            this.FuncPagaBT.TabIndex = 14;
            this.FuncPagaBT.Text = "Gerar informações de pagamento";
            this.FuncPagaBT.UseVisualStyleBackColor = false;
            // 
            // PesquisarBt
            // 
            this.PesquisarBt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PesquisarBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PesquisarBt.Location = new System.Drawing.Point(447, 32);
            this.PesquisarBt.Name = "PesquisarBt";
            this.PesquisarBt.Size = new System.Drawing.Size(152, 27);
            this.PesquisarBt.TabIndex = 13;
            this.PesquisarBt.Text = "Pesquisar";
            this.PesquisarBt.UseVisualStyleBackColor = false;
            // 
            // MtxtCpf
            // 
            this.MtxtCpf.Location = new System.Drawing.Point(216, 32);
            this.MtxtCpf.Mask = "000.000.000-00";
            this.MtxtCpf.Name = "MtxtCpf";
            this.MtxtCpf.Size = new System.Drawing.Size(206, 26);
            this.MtxtCpf.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o Cpf do funcionário :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.MtxtPagaEmp);
            this.groupBox2.Controls.Add(this.LPagaEmp);
            this.groupBox2.Controls.Add(this.EmpPagaBT);
            this.groupBox2.Controls.Add(this.PesquisarEmpBT);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(1034, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 690);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folha de pagamento empresa";
            // 
            // MtxtPagaEmp
            // 
            this.MtxtPagaEmp.Location = new System.Drawing.Point(151, 502);
            this.MtxtPagaEmp.Mask = "$ ";
            this.MtxtPagaEmp.Name = "MtxtPagaEmp";
            this.MtxtPagaEmp.Size = new System.Drawing.Size(247, 26);
            this.MtxtPagaEmp.TabIndex = 20;
            // 
            // LPagaEmp
            // 
            this.LPagaEmp.AutoSize = true;
            this.LPagaEmp.Location = new System.Drawing.Point(37, 505);
            this.LPagaEmp.Name = "LPagaEmp";
            this.LPagaEmp.Size = new System.Drawing.Size(108, 20);
            this.LPagaEmp.TabIndex = 19;
            this.LPagaEmp.Text = "Valor a pagar:";
            // 
            // EmpPagaBT
            // 
            this.EmpPagaBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmpPagaBT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpPagaBT.Location = new System.Drawing.Point(212, 427);
            this.EmpPagaBT.Name = "EmpPagaBT";
            this.EmpPagaBT.Size = new System.Drawing.Size(379, 41);
            this.EmpPagaBT.TabIndex = 18;
            this.EmpPagaBT.Text = "Gerar informações de pagamento empresa";
            this.EmpPagaBT.UseVisualStyleBackColor = false;
            this.EmpPagaBT.Click += new System.EventHandler(this.EmpPagaBT_Click);
            // 
            // PesquisarEmpBT
            // 
            this.PesquisarEmpBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PesquisarEmpBT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PesquisarEmpBT.Location = new System.Drawing.Point(477, 39);
            this.PesquisarEmpBT.Name = "PesquisarEmpBT";
            this.PesquisarEmpBT.Size = new System.Drawing.Size(152, 27);
            this.PesquisarEmpBT.TabIndex = 16;
            this.PesquisarEmpBT.Text = "Pesquisar";
            this.PesquisarEmpBT.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(246, 39);
            this.maskedTextBox2.Mask = "00.000.000.0000-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(206, 26);
            this.maskedTextBox2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Digite o CNPJ da empresa :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpfDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneFuncDataGridViewTextBoxColumn,
            this.cargoFuncDataGridViewTextBoxColumn,
            this.salarioFuncDataGridViewTextBoxColumn,
            this.funcionalDataGridViewTextBoxColumn,
            this.vAuxilioAlimentacaoDataGridViewTextBoxColumn,
            this.vAuxilioRefeicaoDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dataInicioDataGridViewTextBoxColumn,
            this.dataFimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fUNCIONARIOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 213);
            this.dataGridView1.TabIndex = 21;
            // 
            // rHSOLUTIONSDataSet
            // 
            this.rHSOLUTIONSDataSet.DataSetName = "RHSOLUTIONSDataSet";
            this.rHSOLUTIONSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fUNCIONARIOBindingSource
            // 
            this.fUNCIONARIOBindingSource.DataMember = "FUNCIONARIO";
            this.fUNCIONARIOBindingSource.DataSource = this.rHSOLUTIONSDataSet;
            // 
            // fUNCIONARIOTableAdapter
            // 
            this.fUNCIONARIOTableAdapter.ClearBeforeFill = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // telefoneFuncDataGridViewTextBoxColumn
            // 
            this.telefoneFuncDataGridViewTextBoxColumn.DataPropertyName = "TelefoneFunc";
            this.telefoneFuncDataGridViewTextBoxColumn.HeaderText = "TelefoneFunc";
            this.telefoneFuncDataGridViewTextBoxColumn.Name = "telefoneFuncDataGridViewTextBoxColumn";
            // 
            // cargoFuncDataGridViewTextBoxColumn
            // 
            this.cargoFuncDataGridViewTextBoxColumn.DataPropertyName = "CargoFunc";
            this.cargoFuncDataGridViewTextBoxColumn.HeaderText = "CargoFunc";
            this.cargoFuncDataGridViewTextBoxColumn.Name = "cargoFuncDataGridViewTextBoxColumn";
            // 
            // salarioFuncDataGridViewTextBoxColumn
            // 
            this.salarioFuncDataGridViewTextBoxColumn.DataPropertyName = "SalarioFunc";
            this.salarioFuncDataGridViewTextBoxColumn.HeaderText = "SalarioFunc";
            this.salarioFuncDataGridViewTextBoxColumn.Name = "salarioFuncDataGridViewTextBoxColumn";
            // 
            // funcionalDataGridViewTextBoxColumn
            // 
            this.funcionalDataGridViewTextBoxColumn.DataPropertyName = "Funcional";
            this.funcionalDataGridViewTextBoxColumn.HeaderText = "Funcional";
            this.funcionalDataGridViewTextBoxColumn.Name = "funcionalDataGridViewTextBoxColumn";
            // 
            // vAuxilioAlimentacaoDataGridViewTextBoxColumn
            // 
            this.vAuxilioAlimentacaoDataGridViewTextBoxColumn.DataPropertyName = "VAuxilioAlimentacao";
            this.vAuxilioAlimentacaoDataGridViewTextBoxColumn.HeaderText = "VAuxilioAlimentacao";
            this.vAuxilioAlimentacaoDataGridViewTextBoxColumn.Name = "vAuxilioAlimentacaoDataGridViewTextBoxColumn";
            // 
            // vAuxilioRefeicaoDataGridViewTextBoxColumn
            // 
            this.vAuxilioRefeicaoDataGridViewTextBoxColumn.DataPropertyName = "VAuxilioRefeicao";
            this.vAuxilioRefeicaoDataGridViewTextBoxColumn.HeaderText = "VAuxilioRefeicao";
            this.vAuxilioRefeicaoDataGridViewTextBoxColumn.Name = "vAuxilioRefeicaoDataGridViewTextBoxColumn";
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // dataInicioDataGridViewTextBoxColumn
            // 
            this.dataInicioDataGridViewTextBoxColumn.DataPropertyName = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.HeaderText = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.Name = "dataInicioDataGridViewTextBoxColumn";
            // 
            // dataFimDataGridViewTextBoxColumn
            // 
            this.dataFimDataGridViewTextBoxColumn.DataPropertyName = "DataFim";
            this.dataFimDataGridViewTextBoxColumn.HeaderText = "DataFim";
            this.dataFimDataGridViewTextBoxColumn.Name = "dataFimDataGridViewTextBoxColumn";
            // 
            // telaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtVoltar);
            this.Name = "telaPagamento";
            this.Text = "telaPagamento";
            this.Load += new System.EventHandler(this.telaPagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHSOLUTIONSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MtxtCpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label Lpagar;
        private System.Windows.Forms.Button FuncPagaBT;
        private System.Windows.Forms.Button PesquisarBt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PesquisarEmpBT;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EmpPagaBT;
        private System.Windows.Forms.MaskedTextBox MtxtPagaEmp;
        private System.Windows.Forms.Label LPagaEmp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RHSOLUTIONSDataSet rHSOLUTIONSDataSet;
        private System.Windows.Forms.BindingSource fUNCIONARIOBindingSource;
        private RHSOLUTIONSDataSetTableAdapters.FUNCIONARIOTableAdapter fUNCIONARIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoFuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioFuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vAuxilioAlimentacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vAuxilioRefeicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
    }
}