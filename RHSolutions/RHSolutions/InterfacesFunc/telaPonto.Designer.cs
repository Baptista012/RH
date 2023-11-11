
namespace RHSolutions.Interfaces
{
    partial class telaPonto
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
            this.rHSOLUTIONSDataSet = new RHSolutions.RHSOLUTIONSDataSet();
            this.rHSOLUTIONSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pONTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pONTOTableAdapter = new RHSolutions.RHSOLUTIONSDataSetTableAdapters.PONTOTableAdapter();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasTrabalhadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primeiraBatidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundaBatidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terceiraBatidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quartaBatidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lcpf = new System.Windows.Forms.Label();
            this.BtVoltar = new System.Windows.Forms.Button();
            this.PesquisarBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHSOLUTIONSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHSOLUTIONSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pONTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpfDataGridViewTextBoxColumn,
            this.diaDataGridViewTextBoxColumn,
            this.horasTrabalhadasDataGridViewTextBoxColumn,
            this.primeiraBatidaDataGridViewTextBoxColumn,
            this.segundaBatidaDataGridViewTextBoxColumn,
            this.terceiraBatidaDataGridViewTextBoxColumn,
            this.quartaBatidaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pONTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // rHSOLUTIONSDataSet
            // 
            this.rHSOLUTIONSDataSet.DataSetName = "RHSOLUTIONSDataSet";
            this.rHSOLUTIONSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rHSOLUTIONSDataSetBindingSource
            // 
            this.rHSOLUTIONSDataSetBindingSource.DataSource = this.rHSOLUTIONSDataSet;
            this.rHSOLUTIONSDataSetBindingSource.Position = 0;
            // 
            // pONTOBindingSource
            // 
            this.pONTOBindingSource.DataMember = "PONTO";
            this.pONTOBindingSource.DataSource = this.rHSOLUTIONSDataSetBindingSource;
            // 
            // pONTOTableAdapter
            // 
            this.pONTOTableAdapter.ClearBeforeFill = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "Dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "Dia";
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            // 
            // horasTrabalhadasDataGridViewTextBoxColumn
            // 
            this.horasTrabalhadasDataGridViewTextBoxColumn.DataPropertyName = "HorasTrabalhadas";
            this.horasTrabalhadasDataGridViewTextBoxColumn.HeaderText = "HorasTrabalhadas";
            this.horasTrabalhadasDataGridViewTextBoxColumn.Name = "horasTrabalhadasDataGridViewTextBoxColumn";
            // 
            // primeiraBatidaDataGridViewTextBoxColumn
            // 
            this.primeiraBatidaDataGridViewTextBoxColumn.DataPropertyName = "PrimeiraBatida";
            this.primeiraBatidaDataGridViewTextBoxColumn.HeaderText = "PrimeiraBatida";
            this.primeiraBatidaDataGridViewTextBoxColumn.Name = "primeiraBatidaDataGridViewTextBoxColumn";
            // 
            // segundaBatidaDataGridViewTextBoxColumn
            // 
            this.segundaBatidaDataGridViewTextBoxColumn.DataPropertyName = "SegundaBatida";
            this.segundaBatidaDataGridViewTextBoxColumn.HeaderText = "SegundaBatida";
            this.segundaBatidaDataGridViewTextBoxColumn.Name = "segundaBatidaDataGridViewTextBoxColumn";
            // 
            // terceiraBatidaDataGridViewTextBoxColumn
            // 
            this.terceiraBatidaDataGridViewTextBoxColumn.DataPropertyName = "TerceiraBatida";
            this.terceiraBatidaDataGridViewTextBoxColumn.HeaderText = "TerceiraBatida";
            this.terceiraBatidaDataGridViewTextBoxColumn.Name = "terceiraBatidaDataGridViewTextBoxColumn";
            // 
            // quartaBatidaDataGridViewTextBoxColumn
            // 
            this.quartaBatidaDataGridViewTextBoxColumn.DataPropertyName = "QuartaBatida";
            this.quartaBatidaDataGridViewTextBoxColumn.HeaderText = "QuartaBatida";
            this.quartaBatidaDataGridViewTextBoxColumn.Name = "quartaBatidaDataGridViewTextBoxColumn";
            // 
            // MtxtCpf
            // 
            this.MtxtCpf.Location = new System.Drawing.Point(67, 87);
            this.MtxtCpf.Mask = "000.000.000-00";
            this.MtxtCpf.Name = "MtxtCpf";
            this.MtxtCpf.Size = new System.Drawing.Size(206, 20);
            this.MtxtCpf.TabIndex = 4;
            this.MtxtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MtxtCpf_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o Cpf do funcionário para saber as informações sobre a folha de ponto dele" +
    "";
            // 
            // Lcpf
            // 
            this.Lcpf.AutoSize = true;
            this.Lcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lcpf.Location = new System.Drawing.Point(26, 90);
            this.Lcpf.Name = "Lcpf";
            this.Lcpf.Size = new System.Drawing.Size(38, 17);
            this.Lcpf.TabIndex = 5;
            this.Lcpf.Text = "CPF:";
            // 
            // BtVoltar
            // 
            this.BtVoltar.BackColor = System.Drawing.Color.Coral;
            this.BtVoltar.Location = new System.Drawing.Point(29, 12);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(124, 35);
            this.BtVoltar.TabIndex = 11;
            this.BtVoltar.Text = "< Voltar";
            this.BtVoltar.UseVisualStyleBackColor = false;
            this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // PesquisarBt
            // 
            this.PesquisarBt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PesquisarBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PesquisarBt.Location = new System.Drawing.Point(279, 83);
            this.PesquisarBt.Name = "PesquisarBt";
            this.PesquisarBt.Size = new System.Drawing.Size(152, 27);
            this.PesquisarBt.TabIndex = 12;
            this.PesquisarBt.Text = "Pesquisar";
            this.PesquisarBt.UseVisualStyleBackColor = false;
            // 
            // telaPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.PesquisarBt);
            this.Controls.Add(this.BtVoltar);
            this.Controls.Add(this.Lcpf);
            this.Controls.Add(this.MtxtCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "telaPonto";
            this.Text = "telaPonto";
            this.Load += new System.EventHandler(this.telaPonto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHSOLUTIONSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHSOLUTIONSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pONTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rHSOLUTIONSDataSetBindingSource;
        private RHSOLUTIONSDataSet rHSOLUTIONSDataSet;
        private System.Windows.Forms.BindingSource pONTOBindingSource;
        private RHSOLUTIONSDataSetTableAdapters.PONTOTableAdapter pONTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasTrabalhadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primeiraBatidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundaBatidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terceiraBatidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quartaBatidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox MtxtCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lcpf;
        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.Button PesquisarBt;
    }
}