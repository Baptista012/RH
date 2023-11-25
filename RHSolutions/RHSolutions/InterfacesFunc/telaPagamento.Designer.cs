
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
            this.txVales = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txFgts = new System.Windows.Forms.TextBox();
            this.txInss = new System.Windows.Forms.TextBox();
            this.txIrrf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GridFunc = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.MaskedTextBox();
            this.Lpagar = new System.Windows.Forms.Label();
            this.FuncPagaBT = new System.Windows.Forms.Button();
            this.PesquisarBt = new System.Windows.Forms.Button();
            this.MtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GridEmpresa = new System.Windows.Forms.DataGridView();
            this.MtxtPagaEmp = new System.Windows.Forms.MaskedTextBox();
            this.LPagaEmp = new System.Windows.Forms.Label();
            this.EmpPagaBT = new System.Windows.Forms.Button();
            this.PesquisarEmpBT = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rHSOLUTIONSDataSet = new RHSolutions.RHSOLUTIONSDataSet();
            this.fUNCIONARIOTableAdapter = new RHSolutions.RHSOLUTIONSDataSetTableAdapters.FUNCIONARIOTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFunc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHSOLUTIONSDataSet)).BeginInit();
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
            this.groupBox1.Controls.Add(this.txVales);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txFgts);
            this.groupBox1.Controls.Add(this.txInss);
            this.groupBox1.Controls.Add(this.txIrrf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.GridFunc);
            this.groupBox1.Controls.Add(this.Total);
            this.groupBox1.Controls.Add(this.Lpagar);
            this.groupBox1.Controls.Add(this.FuncPagaBT);
            this.groupBox1.Controls.Add(this.PesquisarBt);
            this.groupBox1.Controls.Add(this.MtxtCpf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(55, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 558);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folha de pagamento Funcionário";
            // 
            // txVales
            // 
            this.txVales.Location = new System.Drawing.Point(89, 375);
            this.txVales.Name = "txVales";
            this.txVales.Size = new System.Drawing.Size(303, 26);
            this.txVales.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Vales:";
            // 
            // txFgts
            // 
            this.txFgts.Location = new System.Drawing.Point(89, 470);
            this.txFgts.Name = "txFgts";
            this.txFgts.Size = new System.Drawing.Size(303, 26);
            this.txFgts.TabIndex = 23;
            // 
            // txInss
            // 
            this.txInss.Location = new System.Drawing.Point(89, 405);
            this.txInss.Name = "txInss";
            this.txInss.Size = new System.Drawing.Size(303, 26);
            this.txInss.TabIndex = 22;
            // 
            // txIrrf
            // 
            this.txIrrf.Location = new System.Drawing.Point(89, 438);
            this.txIrrf.Name = "txIrrf";
            this.txIrrf.Size = new System.Drawing.Size(303, 26);
            this.txIrrf.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "FGTS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "IRRF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "INSS:";
            // 
            // GridFunc
            // 
            this.GridFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFunc.Location = new System.Drawing.Point(10, 98);
            this.GridFunc.Name = "GridFunc";
            this.GridFunc.Size = new System.Drawing.Size(500, 207);
            this.GridFunc.TabIndex = 17;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(145, 507);
            this.Total.Mask = "$ ";
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(247, 26);
            this.Total.TabIndex = 16;
            // 
            // Lpagar
            // 
            this.Lpagar.AutoSize = true;
            this.Lpagar.Location = new System.Drawing.Point(31, 507);
            this.Lpagar.Name = "Lpagar";
            this.Lpagar.Size = new System.Drawing.Size(108, 20);
            this.Lpagar.TabIndex = 15;
            this.Lpagar.Text = "Valor a pagar:";
            // 
            // FuncPagaBT
            // 
            this.FuncPagaBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FuncPagaBT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FuncPagaBT.Location = new System.Drawing.Point(89, 311);
            this.FuncPagaBT.Name = "FuncPagaBT";
            this.FuncPagaBT.Size = new System.Drawing.Size(379, 41);
            this.FuncPagaBT.TabIndex = 14;
            this.FuncPagaBT.Text = "Gerar informações de pagamento";
            this.FuncPagaBT.UseVisualStyleBackColor = false;
            this.FuncPagaBT.Click += new System.EventHandler(this.FuncPagaBT_Click);
            // 
            // PesquisarBt
            // 
            this.PesquisarBt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PesquisarBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PesquisarBt.Location = new System.Drawing.Point(240, 65);
            this.PesquisarBt.Name = "PesquisarBt";
            this.PesquisarBt.Size = new System.Drawing.Size(152, 27);
            this.PesquisarBt.TabIndex = 13;
            this.PesquisarBt.Text = "Pesquisar";
            this.PesquisarBt.UseVisualStyleBackColor = false;
            this.PesquisarBt.Click += new System.EventHandler(this.PesquisarBt_Click);
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
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.GridEmpresa);
            this.groupBox2.Controls.Add(this.MtxtPagaEmp);
            this.groupBox2.Controls.Add(this.LPagaEmp);
            this.groupBox2.Controls.Add(this.EmpPagaBT);
            this.groupBox2.Controls.Add(this.PesquisarEmpBT);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(700, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 564);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folha de pagamento empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(142, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(579, 46);
            this.label3.TabIndex = 22;
            this.label3.Text = "Não ta funcionando vou arruma";
            // 
            // GridEmpresa
            // 
            this.GridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmpresa.Location = new System.Drawing.Point(29, 104);
            this.GridEmpresa.Name = "GridEmpresa";
            this.GridEmpresa.Size = new System.Drawing.Size(527, 201);
            this.GridEmpresa.TabIndex = 21;
            // 
            // MtxtPagaEmp
            // 
            this.MtxtPagaEmp.Location = new System.Drawing.Point(150, 624);
            this.MtxtPagaEmp.Mask = "$ ";
            this.MtxtPagaEmp.Name = "MtxtPagaEmp";
            this.MtxtPagaEmp.Size = new System.Drawing.Size(247, 26);
            this.MtxtPagaEmp.TabIndex = 20;
            // 
            // LPagaEmp
            // 
            this.LPagaEmp.AutoSize = true;
            this.LPagaEmp.Location = new System.Drawing.Point(36, 627);
            this.LPagaEmp.Name = "LPagaEmp";
            this.LPagaEmp.Size = new System.Drawing.Size(108, 20);
            this.LPagaEmp.TabIndex = 19;
            this.LPagaEmp.Text = "Valor a pagar:";
            // 
            // EmpPagaBT
            // 
            this.EmpPagaBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmpPagaBT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpPagaBT.Location = new System.Drawing.Point(150, 431);
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
            this.PesquisarEmpBT.Location = new System.Drawing.Point(273, 71);
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
            // fUNCIONARIOBindingSource
            // 
            this.fUNCIONARIOBindingSource.DataMember = "FUNCIONARIO";
            this.fUNCIONARIOBindingSource.DataSource = this.rHSOLUTIONSDataSet;
            // 
            // rHSOLUTIONSDataSet
            // 
            this.rHSOLUTIONSDataSet.DataSetName = "RHSOLUTIONSDataSet";
            this.rHSOLUTIONSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fUNCIONARIOTableAdapter
            // 
            this.fUNCIONARIOTableAdapter.ClearBeforeFill = true;
            // 
            // telaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtVoltar);
            this.Name = "telaPagamento";
            this.Text = "telaPagamento";
            this.Load += new System.EventHandler(this.telaPagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFunc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHSOLUTIONSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MtxtCpf;
        private System.Windows.Forms.MaskedTextBox Total;
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
        private RHSOLUTIONSDataSet rHSOLUTIONSDataSet;
        private System.Windows.Forms.BindingSource fUNCIONARIOBindingSource;
        private RHSOLUTIONSDataSetTableAdapters.FUNCIONARIOTableAdapter fUNCIONARIOTableAdapter;
        private System.Windows.Forms.DataGridView GridFunc;
        private System.Windows.Forms.TextBox txFgts;
        private System.Windows.Forms.TextBox txInss;
        private System.Windows.Forms.TextBox txIrrf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridEmpresa;
        private System.Windows.Forms.TextBox txVales;
        private System.Windows.Forms.Label label7;
    }
}