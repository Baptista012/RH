
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rHSOLUTIONSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rHSOLUTIONSDataSet = new RHSolutions.RHSOLUTIONSDataSet();
            this.MtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fUNCIONARIOTableAdapter = new RHSolutions.RHSOLUTIONSDataSetTableAdapters.FUNCIONARIOTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MtxtPagaEmp = new System.Windows.Forms.MaskedTextBox();
            this.LPagaEmp = new System.Windows.Forms.Label();
            this.EmpPagaBT = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cpfFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PesquisarEmpBT = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eMPRESATableAdapter = new RHSolutions.RHSOLUTIONSDataSetTableAdapters.EMPRESATableAdapter();
            this.fKENDERECOFUNCpf48CFD27EBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNDERECOFUNCTableAdapter = new RHSolutions.RHSOLUTIONSDataSetTableAdapters.ENDERECOFUNCTableAdapter();
            this.dataFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAuxilioRefeicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vAuxilioAlimentacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioFuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoFuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHSOLUTIONSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHSOLUTIONSDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKENDERECOFUNCpf48CFD27EBindingSource)).BeginInit();
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
            this.groupBox1.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpfDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cargoFuncDataGridViewTextBoxColumn,
            this.salarioFuncDataGridViewTextBoxColumn,
            this.funcionalDataGridViewTextBoxColumn,
            this.vAuxilioAlimentacaoDataGridViewTextBoxColumn,
            this.vAuxilioRefeicaoDataGridViewTextBoxColumn,
            this.dataInicioDataGridViewTextBoxColumn,
            this.dataFimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fUNCIONARIOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(888, 324);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // fUNCIONARIOBindingSource
            // 
            this.fUNCIONARIOBindingSource.DataMember = "FUNCIONARIO";
            this.fUNCIONARIOBindingSource.DataSource = this.rHSOLUTIONSDataSetBindingSource;
            // 
            // rHSOLUTIONSDataSetBindingSource
            // 
            this.rHSOLUTIONSDataSetBindingSource.DataSource = this.rHSOLUTIONSDataSet;
            this.rHSOLUTIONSDataSetBindingSource.Position = 0;
            // 
            // rHSOLUTIONSDataSet
            // 
            this.rHSOLUTIONSDataSet.DataSetName = "RHSOLUTIONSDataSet";
            this.rHSOLUTIONSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // fUNCIONARIOTableAdapter
            // 
            this.fUNCIONARIOTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MtxtPagaEmp);
            this.groupBox2.Controls.Add(this.LPagaEmp);
            this.groupBox2.Controls.Add(this.EmpPagaBT);
            this.groupBox2.Controls.Add(this.dataGridView2);
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
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpfFuncionarioDataGridViewTextBoxColumn,
            this.Salario,
            this.nomeEmpresaDataGridViewTextBoxColumn,
            this.cnpjEmpresaDataGridViewTextBoxColumn,
            this.enderEmpresaDataGridViewTextBoxColumn,
            this.telefoneEmpresaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.eMPRESABindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(40, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(773, 324);
            this.dataGridView2.TabIndex = 17;
            // 
            // cpfFuncionarioDataGridViewTextBoxColumn
            // 
            this.cpfFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "CpfFuncionario";
            this.cpfFuncionarioDataGridViewTextBoxColumn.HeaderText = "CpfFuncionario";
            this.cpfFuncionarioDataGridViewTextBoxColumn.Name = "cpfFuncionarioDataGridViewTextBoxColumn";
            this.cpfFuncionarioDataGridViewTextBoxColumn.Width = 120;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "SalarioFunc";
            this.Salario.Name = "Salario";
            this.Salario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Salario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nomeEmpresaDataGridViewTextBoxColumn
            // 
            this.nomeEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NomeEmpresa";
            this.nomeEmpresaDataGridViewTextBoxColumn.HeaderText = "NomeEmpresa";
            this.nomeEmpresaDataGridViewTextBoxColumn.Name = "nomeEmpresaDataGridViewTextBoxColumn";
            this.nomeEmpresaDataGridViewTextBoxColumn.Width = 120;
            // 
            // cnpjEmpresaDataGridViewTextBoxColumn
            // 
            this.cnpjEmpresaDataGridViewTextBoxColumn.DataPropertyName = "CnpjEmpresa";
            this.cnpjEmpresaDataGridViewTextBoxColumn.HeaderText = "CnpjEmpresa";
            this.cnpjEmpresaDataGridViewTextBoxColumn.Name = "cnpjEmpresaDataGridViewTextBoxColumn";
            this.cnpjEmpresaDataGridViewTextBoxColumn.Width = 120;
            // 
            // enderEmpresaDataGridViewTextBoxColumn
            // 
            this.enderEmpresaDataGridViewTextBoxColumn.DataPropertyName = "EnderEmpresa";
            this.enderEmpresaDataGridViewTextBoxColumn.HeaderText = "EnderEmpresa";
            this.enderEmpresaDataGridViewTextBoxColumn.Name = "enderEmpresaDataGridViewTextBoxColumn";
            this.enderEmpresaDataGridViewTextBoxColumn.Width = 120;
            // 
            // telefoneEmpresaDataGridViewTextBoxColumn
            // 
            this.telefoneEmpresaDataGridViewTextBoxColumn.DataPropertyName = "TelefoneEmpresa";
            this.telefoneEmpresaDataGridViewTextBoxColumn.HeaderText = "TelefoneEmpresa";
            this.telefoneEmpresaDataGridViewTextBoxColumn.Name = "telefoneEmpresaDataGridViewTextBoxColumn";
            this.telefoneEmpresaDataGridViewTextBoxColumn.Width = 150;
            // 
            // eMPRESABindingSource
            // 
            this.eMPRESABindingSource.DataMember = "EMPRESA";
            this.eMPRESABindingSource.DataSource = this.rHSOLUTIONSDataSetBindingSource;
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
            // eMPRESATableAdapter
            // 
            this.eMPRESATableAdapter.ClearBeforeFill = true;
            // 
            // fKENDERECOFUNCpf48CFD27EBindingSource
            // 
            this.fKENDERECOFUNCpf48CFD27EBindingSource.DataMember = "FK__ENDERECOFUN__Cpf__48CFD27E";
            this.fKENDERECOFUNCpf48CFD27EBindingSource.DataSource = this.fUNCIONARIOBindingSource;
            // 
            // eNDERECOFUNCTableAdapter
            // 
            this.eNDERECOFUNCTableAdapter.ClearBeforeFill = true;
            // 
            // dataFimDataGridViewTextBoxColumn
            // 
            this.dataFimDataGridViewTextBoxColumn.DataPropertyName = "DataFim";
            this.dataFimDataGridViewTextBoxColumn.HeaderText = "DataFim";
            this.dataFimDataGridViewTextBoxColumn.Name = "dataFimDataGridViewTextBoxColumn";
            // 
            // dataInicioDataGridViewTextBoxColumn
            // 
            this.dataInicioDataGridViewTextBoxColumn.DataPropertyName = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.HeaderText = "DataInicio";
            this.dataInicioDataGridViewTextBoxColumn.Name = "dataInicioDataGridViewTextBoxColumn";
            // 
            // vAuxilioRefeicaoDataGridViewTextBoxColumn
            // 
            this.vAuxilioRefeicaoDataGridViewTextBoxColumn.DataPropertyName = "VAuxilioRefeicao";
            this.vAuxilioRefeicaoDataGridViewTextBoxColumn.HeaderText = "VAuxilioRefeicao";
            this.vAuxilioRefeicaoDataGridViewTextBoxColumn.Name = "vAuxilioRefeicaoDataGridViewTextBoxColumn";
            // 
            // vAuxilioAlimentacaoDataGridViewTextBoxColumn
            // 
            this.vAuxilioAlimentacaoDataGridViewTextBoxColumn.DataPropertyName = "VAuxilioAlimentacao";
            this.vAuxilioAlimentacaoDataGridViewTextBoxColumn.HeaderText = "VAuxilioAlimentacao";
            this.vAuxilioAlimentacaoDataGridViewTextBoxColumn.Name = "vAuxilioAlimentacaoDataGridViewTextBoxColumn";
            // 
            // funcionalDataGridViewTextBoxColumn
            // 
            this.funcionalDataGridViewTextBoxColumn.DataPropertyName = "Funcional";
            this.funcionalDataGridViewTextBoxColumn.HeaderText = "Funcional";
            this.funcionalDataGridViewTextBoxColumn.Name = "funcionalDataGridViewTextBoxColumn";
            // 
            // salarioFuncDataGridViewTextBoxColumn
            // 
            this.salarioFuncDataGridViewTextBoxColumn.DataPropertyName = "SalarioFunc";
            this.salarioFuncDataGridViewTextBoxColumn.HeaderText = "SalarioFunc";
            this.salarioFuncDataGridViewTextBoxColumn.Name = "salarioFuncDataGridViewTextBoxColumn";
            // 
            // cargoFuncDataGridViewTextBoxColumn
            // 
            this.cargoFuncDataGridViewTextBoxColumn.DataPropertyName = "CargoFunc";
            this.cargoFuncDataGridViewTextBoxColumn.HeaderText = "CargoFunc";
            this.cargoFuncDataGridViewTextBoxColumn.Name = "cargoFuncDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHSOLUTIONSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHSOLUTIONSDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKENDERECOFUNCpf48CFD27EBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rHSOLUTIONSDataSetBindingSource;
        private RHSOLUTIONSDataSet rHSOLUTIONSDataSet;
        private System.Windows.Forms.MaskedTextBox MtxtCpf;
        private System.Windows.Forms.BindingSource fUNCIONARIOBindingSource;
        private RHSOLUTIONSDataSetTableAdapters.FUNCIONARIOTableAdapter fUNCIONARIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label Lpagar;
        private System.Windows.Forms.Button FuncPagaBT;
        private System.Windows.Forms.Button PesquisarBt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button PesquisarEmpBT;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource eMPRESABindingSource;
        private RHSOLUTIONSDataSetTableAdapters.EMPRESATableAdapter eMPRESATableAdapter;
        private System.Windows.Forms.Button EmpPagaBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfFuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox MtxtPagaEmp;
        private System.Windows.Forms.Label LPagaEmp;
        private System.Windows.Forms.BindingSource fKENDERECOFUNCpf48CFD27EBindingSource;
        private RHSOLUTIONSDataSetTableAdapters.ENDERECOFUNCTableAdapter eNDERECOFUNCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoFuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioFuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vAuxilioAlimentacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vAuxilioRefeicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
    }
}