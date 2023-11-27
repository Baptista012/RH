
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
            this.MtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lcpf = new System.Windows.Forms.Label();
            this.BtVoltar = new System.Windows.Forms.Button();
            this.PesquisarBt = new System.Windows.Forms.Button();
            this.GridPonto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridPonto)).BeginInit();
            this.SuspendLayout();
            // 
            // MtxtCpf
            // 
            this.MtxtCpf.Location = new System.Drawing.Point(67, 87);
            this.MtxtCpf.Mask = "000.000.000-00";
            this.MtxtCpf.Name = "MtxtCpf";
            this.MtxtCpf.Size = new System.Drawing.Size(206, 20);
            this.MtxtCpf.TabIndex = 4;
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
            this.PesquisarBt.Click += new System.EventHandler(this.PesquisarBt_Click);
            // 
            // GridPonto
            // 
            this.GridPonto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPonto.Location = new System.Drawing.Point(29, 116);
            this.GridPonto.Name = "GridPonto";
            this.GridPonto.Size = new System.Drawing.Size(1025, 481);
            this.GridPonto.TabIndex = 13;
            // 
            // telaPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.GridPonto);
            this.Controls.Add(this.PesquisarBt);
            this.Controls.Add(this.BtVoltar);
            this.Controls.Add(this.Lcpf);
            this.Controls.Add(this.MtxtCpf);
            this.Controls.Add(this.label1);
            this.Name = "telaPonto";
            this.Text = "telaPonto";
            this.Load += new System.EventHandler(this.telaPonto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox MtxtCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lcpf;
        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.Button PesquisarBt;
        private System.Windows.Forms.DataGridView GridPonto;
    }
}