
namespace RHSolutions.Interfaces
{
    partial class telaFerias
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneFuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoFuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioFuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rhdbDataSet1 = new RHSolutions.RHDBDataSet();
            this.fUNCIONARIOTableAdapter = new RHSolutions.RHDBDataSetTableAdapters.FUNCIONARIOTableAdapter();
            this.PesquisarBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhdbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nome,
            this.cpfDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneFuncDataGridViewTextBoxColumn,
            this.cargoFuncDataGridViewTextBoxColumn,
            this.SalarioFunc,
            this.salarioFuncDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fUNCIONARIOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 142);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Cpf";
            this.Column1.HeaderText = "Cpf";
            this.Column1.Name = "Column1";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // SalarioFunc
            // 
            this.SalarioFunc.DataPropertyName = "SalarioFunc";
            this.SalarioFunc.HeaderText = "Tempo restante";
            this.SalarioFunc.Name = "SalarioFunc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o Cpf do funcionário :";
            // 
            // MtxtCpf
            // 
            this.MtxtCpf.Location = new System.Drawing.Point(184, 98);
            this.MtxtCpf.Mask = "000.000.000-00";
            this.MtxtCpf.Name = "MtxtCpf";
            this.MtxtCpf.Size = new System.Drawing.Size(206, 20);
            this.MtxtCpf.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primeiro Periodo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo Perido :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Terceiro Periodo :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 348);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 386);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(173, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(31, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "< Voltar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1°",
            "2°",
            "3°"});
            this.checkedListBox1.Location = new System.Drawing.Point(419, 329);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(309, 49);
            this.checkedListBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Divisão em periodos :";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Primeiro Periodo";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Segundo Periodo";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // telefoneFuncDataGridViewTextBoxColumn
            // 
            this.telefoneFuncDataGridViewTextBoxColumn.DataPropertyName = "TelefoneFunc";
            this.telefoneFuncDataGridViewTextBoxColumn.HeaderText = "Terceiro Periodo";
            this.telefoneFuncDataGridViewTextBoxColumn.Name = "telefoneFuncDataGridViewTextBoxColumn";
            // 
            // cargoFuncDataGridViewTextBoxColumn
            // 
            this.cargoFuncDataGridViewTextBoxColumn.DataPropertyName = "CargoFunc";
            this.cargoFuncDataGridViewTextBoxColumn.HeaderText = "Periodos";
            this.cargoFuncDataGridViewTextBoxColumn.Name = "cargoFuncDataGridViewTextBoxColumn";
            // 
            // salarioFuncDataGridViewTextBoxColumn
            // 
            this.salarioFuncDataGridViewTextBoxColumn.DataPropertyName = "SalarioFunc";
            this.salarioFuncDataGridViewTextBoxColumn.HeaderText = "Data limite";
            this.salarioFuncDataGridViewTextBoxColumn.Name = "salarioFuncDataGridViewTextBoxColumn";
            // 
            // fUNCIONARIOBindingSource
            // 
            this.fUNCIONARIOBindingSource.DataMember = "FUNCIONARIO";
            this.fUNCIONARIOBindingSource.DataSource = this.rhdbDataSet1;
            // 
            // rhdbDataSet1
            // 
            this.rhdbDataSet1.DataSetName = "RHDBDataSet";
            this.rhdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fUNCIONARIOTableAdapter
            // 
            this.fUNCIONARIOTableAdapter.ClearBeforeFill = true;
            // 
            // PesquisarBt
            // 
            this.PesquisarBt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PesquisarBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PesquisarBt.Location = new System.Drawing.Point(419, 94);
            this.PesquisarBt.Name = "PesquisarBt";
            this.PesquisarBt.Size = new System.Drawing.Size(152, 27);
            this.PesquisarBt.TabIndex = 13;
            this.PesquisarBt.Text = "Pesquisar";
            this.PesquisarBt.UseVisualStyleBackColor = false;
            // 
            // telaFerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.PesquisarBt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MtxtCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "telaFerias";
            this.Text = "telaFerias";
            this.Load += new System.EventHandler(this.telaFerias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhdbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RHDBDataSet rhdbDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fUNCIONARIOBindingSource;
        private RHDBDataSetTableAdapters.FUNCIONARIOTableAdapter fUNCIONARIOTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MtxtCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneFuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoFuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioFuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button PesquisarBt;
    }
}